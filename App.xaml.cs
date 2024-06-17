using Microsoft.Maui.Controls;

namespace Notepad__easy_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NewNotePage), typeof(NewNotePage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(NotePage), typeof(NotePage));
            Routing.RegisterRoute(nameof(Create_NewNote), typeof(Create_NewNote));
            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            const int newHeight = 700;
            const int newWidth = 1150;

            window.Height = newHeight;
            window.Width = newWidth;

            window.MinimumHeight = newHeight;
            window.MinimumWidth = newWidth;

            window.MaximumHeight = newHeight;
            window.MaximumWidth = newWidth;

            return window;
        }
    }
}
