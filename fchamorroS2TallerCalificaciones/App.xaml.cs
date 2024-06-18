namespace fchamorroS2TallerCalificaciones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new VIEWS.Login1());
        }
    }
}
