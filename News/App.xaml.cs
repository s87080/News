using Microsoft.Extensions.DependencyInjection;
using News.NewsPages;

namespace News
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            bool isLoggedIn = Preferences.Get("isLoggedIn", false);

            if (isLoggedIn)
                return new Window(new AppShell());
            else
                return new Window(new NavigationPage(new First()));
        }
    }
}