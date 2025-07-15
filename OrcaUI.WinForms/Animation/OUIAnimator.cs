using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcaUI.WinForms.Animation
{
    /// <summary>
    /// Animation manager
    /// </summary>
    [ProvideProperty("Decoration", typeof(System.Windows.Forms.Control))]
    public class OUIAnimator : Component, IExtenderProvider
    {
        private readonly List<QueueItem> queue = new();
        private readonly List<QueueItem> requests = new();
        private readonly Dictionary<Control, DecorationControl> DecorationByControls = new();
        private Thread thread;
        private Control invokerControl;
        private System.Windows.Forms.Timer timer;

        public event EventHandler<AnimationCompletedEventArg> AnimationCompleted;
        public event EventHandler AllAnimationsCompleted;
        public event EventHandler<TransfromNeededEventArg> TransfromNeeded;
        public event EventHandler<NonLinearTransfromNeededEventArg> NonLinearTransfromNeeded;
        public event EventHandler<MouseEventArgs> MouseDown;
        public event EventHandler<PaintEventArgs> FramePainted;

        [DefaultValue(1500)]
        public int MaxAnimationTime { get; set; } = 1500;

        [DefaultValue(10)]
        public int Interval { get; set; } = 10;

        [DefaultValue(0.02f)]
        public float TimeStep { get; set; } = 0.02f;

        public bool Upside { get; set; } = false;
        public Cursor Cursor { get; set; } = Cursors.Default;
        public Animation DefaultAnimation { get; set; } = new();
        public bool IsCompleted => queue.Count == 0;

        private AnimationType animationType;
        public AnimationType AnimationType
        {
            get => animationType;
            set
            {
                animationType = value;
                InitDefaultAnimation(value);
            }
        }

        public Animator() => Init();
        public Animator(IContainer container)
        {
            container.Add(this);
            Init();
        }

        private void Init()
        {
            AnimationType = AnimationType.VertSlide;
            timer = new System.Windows.Forms.Timer { Interval = 1 };
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                invokerControl = new Control();
                invokerControl.CreateControl();
                Start();
            };
            timer.Start();
            Disposed += (_, _) => DisposeAnimator();
        }

        private void Start()
        {
            thread = new Thread(Work)
            {
                IsBackground = true,
                Name = "Animator thread"
            };
            thread.Start();
        }

        private void DisposeAnimator()
        {
            ClearQueue();
            thread?.Abort();
        }

        private void Work()
        {
            while (true)
            {
                Thread.Sleep(Interval);
                try
                {
                    List<QueueItem> completed = [], actived = [];
                    lock (queue)
                    {
                        bool wasActive = false;
                        foreach (var item in queue)
                        {
                            if (item.IsActive) wasActive = true;

                            if (item.controller?.IsCompleted == true ||
                                item.IsActive && (DateTime.Now - item.ActivateTime).TotalMilliseconds > MaxAnimationTime)
                                completed.Add(item);
                            else if (!item.IsActive && !wasActive)
                            {
                                item.IsActive = true;
                                actived.Add(item);
                                break;
                            }
                            else if (item.IsActive)
                                actived.Add(item);
                        }
                    }

                    foreach (var item in completed) OnCompleted(item);
                    foreach (var item in actived)
                        invokerControl?.BeginInvoke(new MethodInvoker(() => DoAnimation(item)));

                    if (queue.Count == 0 && completed.Count > 0)
                    {
                        OnAllAnimationsCompleted();
                        CheckRequests();
                    }
                }
                catch { /* form closed */ }
            }
        }

        private void DoAnimation(QueueItem item)
        {
            lock (item)
            {
                try
                {
                    item.controller ??= CreateDoubleBitmap(item.control, item.mode, item.animation, item.clipRectangle);
                    if (!item.controller.IsCompleted)
                        item.controller.BuildNextFrame();
                }
                catch
                {
                    item.controller?.Dispose();
                    OnCompleted(item);
                }
            }
        }

        private Controller CreateDoubleBitmap(Control control, AnimateMode mode, Animation animation, Rectangle clipRect)
        {
            var ctrl = new Controller(control, mode, animation, TimeStep, clipRect)
            {
                Upside = this.Upside,
                DoubleBitmap = { Cursor = Cursor }
            };

            ctrl.TransfromNeeded += OnTransformNeeded;
            ctrl.NonLinearTransfromNeeded += OnNonLinearTransfromNeeded;
            ctrl.MouseDown += OnMouseDown;
            ctrl.FramePainted += OnFramePainted;

            return ctrl;
        }

        private void CheckRequests()
        {
            lock (requests)
            {
                var dict = requests
                    .Where(r => r.control != null)
                    .GroupBy(r => r.control)
                    .Select(g => g.Last())
                    .ToList();

                var toRemove = new List<QueueItem>(requests);

                foreach (var item in dict)
                {
                    if (item.control != null && !IsStateOK(item.control, item.mode))
                        invokerControl?.Invoke(new MethodInvoker(() => RepairState(item.control, item.mode)));
                    else
                        toRemove.Remove(item);
                }

                foreach (var item in toRemove)
                    requests.Remove(item);
            }
        }

        private static bool IsStateOK(Control control, AnimateMode mode) => mode switch
        {
            AnimateMode.Hide => !control.Visible,
            AnimateMode.Show => control.Visible,
            _ => true
        };

        private static void RepairState(Control control, AnimateMode mode)
        {
            try
            {
                control.Visible = mode == AnimateMode.Show;
            }
            catch { }
        }

        private void InitDefaultAnimation(AnimationType type) =>
            DefaultAnimation = type switch
            {
                AnimationType.Rotate => Animation.Rotate,
                AnimationType.HorizSlide => Animation.HorizSlide,
                AnimationType.VertSlide => Animation.VertSlide,
                AnimationType.Scale => Animation.Scale,
                AnimationType.ScaleAndRotate => Animation.ScaleAndRotate,
                AnimationType.HorizSlideAndRotate => Animation.HorizSlideAndRotate,
                AnimationType.ScaleAndHorizSlide => Animation.ScaleAndHorizSlide,
                AnimationType.Transparent => Animation.Transparent,
                AnimationType.Leaf => Animation.Leaf,
                AnimationType.Mosaic => Animation.Mosaic,
                AnimationType.Particles => Animation.Particles,
                AnimationType.VertBlind => Animation.VertBlind,
                AnimationType.HorizBlind => Animation.HorizBlind,
                _ => DefaultAnimation
            };

        private void OnCompleted(QueueItem item)
        {
            item.controller?.Dispose();
            lock (queue) queue.Remove(item);
            AnimationCompleted?.Invoke(this, new AnimationCompletedEventArg { Animation = item.animation, Control = item.control, Mode = item.mode });
        }

        private void OnAllAnimationsCompleted() => AllAnimationsCompleted?.Invoke(this, EventArgs.Empty);
        private void OnTransformNeeded(object sender, TransfromNeededEventArg e) => e.UseDefaultMatrix = TransfromNeeded == null;
        private void OnNonLinearTransfromNeeded(object sender, NonLinearTransfromNeededEventArg e) => e.UseDefaultTransform = NonLinearTransfromNeeded == null;
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Controller db)
            {
                var loc = e.Location;
                loc.Offset(db.DoubleBitmap.Left - db.AnimatedControl.Left, db.DoubleBitmap.Top - db.AnimatedControl.Top);
                MouseDown?.Invoke(sender, new MouseEventArgs(e.Button, e.Clicks, loc.X, loc.Y, e.Delta));
            }
        }

        private void OnFramePainted(object sender, PaintEventArgs e) => FramePainted?.Invoke(sender, e);

        public void Show(Control control, bool parallel = false, Animation animation = null) =>
            AddToQueue(control, AnimateMode.Show, parallel, animation);

        public void Hide(Control control, bool parallel = false, Animation animation = null) =>
            AddToQueue(control, AnimateMode.Hide, parallel, animation);

        public void ShowSync(Control control, bool parallel = false, Animation animation = null)
        {
            Show(control, parallel, animation);
            WaitAnimation(control);
        }

        public void HideSync(Control control, bool parallel = false, Animation animation = null)
        {
            Hide(control, parallel, animation);
            WaitAnimation(control);
        }

        public void BeginUpdate(Control control, bool parallel = false, Animation animation = null, Rectangle clipRect = default)
        {
            AddToQueue(control, AnimateMode.BeginUpdate, parallel, animation, clipRect);
            WaitWhile(() => queue.Any(q => q.control == control && q.mode == AnimateMode.BeginUpdate && q.controller == null));
        }

        public void EndUpdate(Control control)
        {
            lock (queue)
            {
                foreach (var item in queue.Where(q => q.control == control && q.mode == AnimateMode.BeginUpdate))
                {
                    item.controller.EndUpdate();
                    item.mode = AnimateMode.Update;
                }
            }
        }

        public void EndUpdateSync(Control control)
        {
            EndUpdate(control);
            WaitAnimation(control);
        }

        public void WaitAllAnimations() => WaitWhile(() => !IsCompleted);

        public void WaitAnimation(Control control) =>
            WaitWhile(() => queue.Any(q => q.control == control));

        private static void WaitWhile(Func<bool> condition)
        {
            while (condition()) Application.DoEvents();
        }

        public void AddToQueue(Control control, AnimateMode mode, bool parallel = true, Animation animation = null, Rectangle clipRect = default)
        {
            if (control is IFakeControl) { control.Visible = false; return; }
            animation ??= DefaultAnimation;

            if ((mode == AnimateMode.Show && control.Visible) || (mode == AnimateMode.Hide && !control.Visible))
            {
                OnCompleted(new QueueItem { control = control, mode = mode });
                return;
            }

            var item = new QueueItem
            {
                control = control,
                animation = animation,
                mode = mode,
                clipRectangle = clipRect,
                IsActive = parallel
            };

            lock (queue) queue.Add(item);
            lock (requests) requests.Add(item);
        }

        public void ClearQueue()
        {
            List<QueueItem> items;
            lock (queue)
            {
                items = new List<QueueItem>(queue);
                queue.Clear();
            }

            foreach (var item in items)
            {
                item.control?.BeginInvoke(new MethodInvoker(() =>
                {
                    item.control.Visible = item.mode == AnimateMode.Show;
                }));
                AnimationCompleted?.Invoke(this, new AnimationCompletedEventArg { Animation = item.animation, Control = item.control, Mode = item.mode });
            }

            if (items.Count > 0)
                OnAllAnimationsCompleted();
        }

        public bool CanExtend(object extendee) => extendee is Control;

        public DecorationType GetDecoration(Control control) =>
            DecorationByControls.TryGetValue(control, out var wrapper) ? wrapper.DecorationType : DecorationType.None;

        public void SetDecoration(Control control, DecorationType decoration)
        {
            if (decoration == DecorationType.None)
            {
                if (DecorationByControls.TryGetValue(control, out var wrapper))
                    wrapper.Dispose();
                DecorationByControls.Remove(control);
            }
            else
            {
                if (!DecorationByControls.TryGetValue(control, out var wrapper))
                    wrapper = new DecorationControl(decoration, control);

                wrapper.DecorationType = decoration;
                DecorationByControls[control] = wrapper;
            }
        }

        protected class QueueItem
        {
            public Animation animation;
            public Controller controller;
            public Control control;
            public AnimateMode mode;
            public Rectangle clipRectangle;

            private bool isActive;
            public bool IsActive
            {
                get => isActive;
                set
                {
                    if (isActive == value) return;
                    isActive = value;
                    if (value) ActivateTime = DateTime.Now;
                }
            }

            public DateTime ActivateTime { get; private set; }

            public override string ToString() => $"{control?.GetType().Name} {mode}";
        }
    }


}
