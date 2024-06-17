namespace RebeBA_ApuntesApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.RebeBA_NotePage), typeof(Views.RebeBA_NotePage));
        }
    }
}
