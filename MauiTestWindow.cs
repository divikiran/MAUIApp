using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiChapter1
{
    public class MauiTestWindow
        : Window
    {
        public MauiTestWindow() : base()
        {
            
        }

        public MauiTestWindow(Page page) : base(page) {
            this.Created += PxWindow_Created;
            this.Activated += PxWindow_Activated;
            this.Deactivated += PxWindow_Deactivated;
            this.Stopped += PxWindow_Stopped;
            this.Resumed += PxWindow_Resumed;
            this.Destroying += PxWindow_Destroying;
        }

        private void PxWindow_Resumed(object sender, EventArgs e)
        {
            Debug.WriteLine("Resumed******************");
        }

        private void PxWindow_Stopped(object sender, EventArgs e)
        {
            Debug.WriteLine("Stopped******************");
        }

        private void PxWindow_Deactivated(object sender, EventArgs e)
        {
            Debug.WriteLine("Deactivated******************");
        }

        private void PxWindow_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Activated******************");
        }

        private void PxWindow_Created(object sender, EventArgs e)
        {
            Debug.WriteLine("Created******************");
        }

        private void PxWindow_Destroying(object sender, EventArgs e)
        {
            Debug.WriteLine("Destroying******************");
        }

        protected override void OnCreated()
        {
            base.OnCreated();
            Debug.WriteLine("OnCreated******************");
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            Debug.WriteLine("OnActivated******************");
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
            Debug.WriteLine("OnDeactivated******************");
        }

        protected override void OnStopped()
        {
            base.OnStopped();
            Debug.WriteLine("OnStopped******************");

        }

        protected override void OnResumed()
        {
            base.OnResumed();
            Debug.WriteLine("OnResumed******************");

        }

        protected override void OnDestroying()
        {
            base.OnDestroying();
            Debug.WriteLine("OnDestroying******************");

        }
    }
}
