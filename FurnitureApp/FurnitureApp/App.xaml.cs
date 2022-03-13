using FreshMvvm;
using FurnitureApp.PageModels;
using FurnitureApp.Services.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("OpenSansBold.ttf", Alias = "OpenSansBold")]
[assembly: ExportFont("OpenSansLight.ttf", Alias = "OpenSansLight")]
[assembly: ExportFont("OpenSansRegular.ttf", Alias = "OpenSansRegular")]
[assembly: ExportFont("OpenSansSemiBold.ttf", Alias = "OpenSansSemiBold")]
[assembly: ExportFont("Fuse_display_regular.ttf", Alias = "FuseDisplayRegular")]
[assembly: ExportFont("FontAwesomeRegular.ttf", Alias = "FontAwesomeRegular")]
[assembly: ExportFont("FontAwesomeSolid.ttf", Alias = "FontAwesomeSolid")]

namespace FurnitureApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IDataService, SampleDataService>();

            MainPage = new FreshNavigationContainer(
                FreshPageModelResolver.ResolvePageModel<MainPageModel>());
                //FreshPageModelResolver.ResolvePageModel<FurnitureItemPageModel>());
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
