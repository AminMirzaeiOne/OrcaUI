using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcaUI.WinForms.Animation
{
    /// <summary>
    /// Settings of animation
    /// </summary>
    public class OUIAnimation
    {
        private static readonly DesignerSerializationVisibility Visibility = DesignerSerializationVisibility.Visible;
        private static readonly EditorBrowsableState BrowseState = EditorBrowsableState.Advanced;

        [DesignerSerializationVisibility(Visibility), EditorBrowsable(BrowseState), TypeConverter(typeof(PointFConverter))]
        public PointF SlideCoeff { get; set; }

        public float RotateCoeff { get; set; }
        public float RotateLimit { get; set; }

        [DesignerSerializationVisibility(Visibility), EditorBrowsable(BrowseState), TypeConverter(typeof(PointFConverter))]
        public PointF ScaleCoeff { get; set; }

        public float TransparencyCoeff { get; set; }
        public float LeafCoeff { get; set; }

        [DesignerSerializationVisibility(Visibility), EditorBrowsable(BrowseState), TypeConverter(typeof(PointFConverter))]
        public PointF MosaicShift { get; set; }

        [DesignerSerializationVisibility(Visibility), EditorBrowsable(BrowseState), TypeConverter(typeof(PointFConverter))]
        public PointF MosaicCoeff { get; set; }

        public int MosaicSize { get; set; }

        [DesignerSerializationVisibility(Visibility), EditorBrowsable(BrowseState), TypeConverter(typeof(PointFConverter))]
        public PointF BlindCoeff { get; set; }

        public float TimeCoeff { get; set; }
        public float MinTime { get; set; } = 0f;
        public float MaxTime { get; set; } = 1f;
        public Padding Padding { get; set; } = new Padding(0);
        public bool AnimateOnlyDifferences { get; set; } = true;

        public bool IsNonLinearTransformNeeded =>
            BlindCoeff != PointF.Empty ||
            MosaicCoeff != PointF.Empty && MosaicSize != 0 ||
            TransparencyCoeff != 0f ||
            LeafCoeff != 0f;

        public Animation Clone() => (Animation)MemberwiseClone();

        private static Animation Create(Action<Animation> setup)
        {
            var anim = new Animation();
            setup(anim);
            return anim;
        }

        public static Animation Rotate => Create(a =>
        {
            a.RotateCoeff = 1f;
            a.TransparencyCoeff = 1;
            a.Padding = new Padding(50);
        });

        public static Animation HorizSlide => Create(a => a.SlideCoeff = new PointF(1, 0));
        public static Animation VertSlide => Create(a => a.SlideCoeff = new PointF(0, 1));
        public static Animation Scale => Create(a => a.ScaleCoeff = new PointF(1, 1));

        public static Animation ScaleAndRotate => Create(a =>
        {
            a.ScaleCoeff = new PointF(1, 1);
            a.RotateCoeff = 0.5f;
            a.RotateLimit = 0.2f;
            a.Padding = new Padding(30);
        });

        public static Animation HorizSlideAndRotate => Create(a =>
        {
            a.SlideCoeff = new PointF(1, 0);
            a.RotateCoeff = 0.3f;
            a.RotateLimit = 0.2f;
            a.Padding = new Padding(50);
        });

        public static Animation ScaleAndHorizSlide => Create(a =>
        {
            a.ScaleCoeff = new PointF(1, 1);
            a.SlideCoeff = new PointF(1, 0);
            a.Padding = new Padding(30, 0, 0, 0);
        });

        public static Animation Transparent => Create(a => a.TransparencyCoeff = 1);
        public static Animation Leaf => Create(a => a.LeafCoeff = 1);

        public static Animation Mosaic => Create(a =>
        {
            a.MosaicCoeff = new PointF(100f, 100f);
            a.MosaicSize = 20;
            a.Padding = new Padding(30);
        });

        public static Animation Particles => Create(a =>
        {
            a.MosaicCoeff = new PointF(200f, 200f);
            a.MosaicSize = 1;
            a.MosaicShift = new PointF(0, 0.5f);
            a.Padding = new Padding(100, 50, 100, 150);
            a.TimeCoeff = 2;
        });

        public static Animation VertBlind => Create(a => a.BlindCoeff = new PointF(0f, 1f));
        public static Animation HorizBlind => Create(a => a.BlindCoeff = new PointF(1f, 0f));

        public void Add(Animation other)
        {
            SlideCoeff = AddPoints(SlideCoeff, other.SlideCoeff);
            RotateCoeff += other.RotateCoeff;
            RotateLimit += other.RotateLimit;
            ScaleCoeff = AddPoints(ScaleCoeff, other.ScaleCoeff);
            TransparencyCoeff += other.TransparencyCoeff;
            LeafCoeff += other.LeafCoeff;
            MosaicShift = AddPoints(MosaicShift, other.MosaicShift);
            MosaicCoeff = AddPoints(MosaicCoeff, other.MosaicCoeff);
            MosaicSize += other.MosaicSize;
            BlindCoeff = AddPoints(BlindCoeff, other.BlindCoeff);
            TimeCoeff += other.TimeCoeff;
            Padding += other.Padding;
        }

        private static PointF AddPoints(PointF p1, PointF p2) => new(p1.X + p2.X, p1.Y + p2.Y);
    }

}
