using System.Diagnostics;

namespace MauiChapter1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            //Window window = base.CreateWindow(activationState);
            //window.Created += Window_Created;
            //window.Activated += Window_Activated;
            //window.Deactivated += Window_Deactivated;
            //window.Stopped += Window_Stopped;
            //window.Resumed += Window_Resumed;
            //window.Destroying += Window_Destroying;


            //return window;

            return new MauiTestWindow(new MainPage());
        }

        protected override void OnStart()
        {
            base.OnStart();
            Debug.WriteLine("OnStart *****************");

        }

        protected override void OnSleep()
        {
            base.OnSleep();
            Debug.WriteLine("OnSleep *****************");

        }

        protected override void OnResume()
        {
            base.OnResume();
            Debug.WriteLine("OnResume *****************");

        }


        private void Window_Destroying(object sender, EventArgs e)
        {
            Debug.WriteLine("Destroying");
        }

        private void Window_Resumed(object sender, EventArgs e)
        {
            Debug.WriteLine("Resumed");
        }

        private void Window_Stopped(object sender, EventArgs e)
        {
            Debug.WriteLine("Stopped");
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Debug.WriteLine("Deactivated");
        }

        private void Window_Created(object sender, EventArgs e)
        {
            Debug.WriteLine("Created");
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("Activated");
        }
    }
}