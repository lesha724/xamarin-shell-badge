using App2.Resources;
using App2.Services;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;

namespace App2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            LocalizationResourceManager.Current.Init(AppResource.ResourceManager);
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
