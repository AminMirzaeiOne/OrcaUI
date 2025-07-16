using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OrcaUI.Animation
{
    /// <summary>
    /// Animation manager
    /// </summary>
    [ProvideProperty("Decoration", typeof(System.Windows.Forms.Control))]
    public class OCAnimator : Component, IExtenderProvider
    {
        IContainer components = null;
        protected List<QueueItem> queue = new List<QueueItem>();
        private Thread thread;
        System.Windows.Forms.Timer timer;
        private AnimationType animationType;
        Control invokerControl;
        int counter;
        List<QueueItem> requests = new List<QueueItem>();


    }
}
