using DialogPrismSample.ViewModels;
using DialogPrismSample.Views;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;

namespace DialogPrismSample
{
    [AutoRegisterForNavigation]
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<DialogView, DialogViewModel>();
            containerRegistry.RegisterForNavigation<ModalPage, ModalPageViewModel>();
        }
    }
}