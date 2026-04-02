using News.NewsPages;

namespace News
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Dashboard", typeof(Dashboard));
        }
    }
}
