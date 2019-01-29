using Prism;
using Prism.Ioc;
using XamarinAwesome.ViewModels;
using XamarinAwesome.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinAwesome
{
    public partial class App
    {
        public static double ScreenHeight;
        public static double ScreenWidth;
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SimplePage, SimplePageViewModel>();
            containerRegistry.RegisterForNavigation<TinderPage, TinderPageViewModel>();
            containerRegistry.RegisterForNavigation<ColorsPage, ColorsPageViewModel>();
            containerRegistry.RegisterForNavigation<CustomizablePage, CustomizablePageViewModel>();
        }
    }
}
