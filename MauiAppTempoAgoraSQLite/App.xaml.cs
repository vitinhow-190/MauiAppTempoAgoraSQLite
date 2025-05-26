namespace MauiAppTempoAgoraSQLite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public static object Db { get; internal set; }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}