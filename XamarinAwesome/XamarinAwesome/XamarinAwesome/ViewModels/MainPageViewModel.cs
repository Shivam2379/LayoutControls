using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAwesome.Views;

namespace XamarinAwesome.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //public ICommand NavigateCommand { get; private set; }
        private INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            //NavigateCommand = new Command<Type>(OnNavigateCommand);
        }

        //private async void OnNavigateCommand(Type obj)
        //{
        //    Page page = (Page)Activator.CreateInstance(obj);
        //    await _navigationService.NavigateAsync(page.ToString());
        //}
        public DelegateCommand TinderNavigateCommand => new DelegateCommand(async () =>
        {
            await _navigationService.NavigateAsync(nameof(TinderPage));
        });
        public DelegateCommand SimpleNavigateCommand => new DelegateCommand(async () =>
        {
            await _navigationService.NavigateAsync(nameof(SimplePage));
        });
        public DelegateCommand ColorsNavigateCommand => new DelegateCommand(async () =>
        {
            await _navigationService.NavigateAsync(nameof(ColorsPage));
        });
        public DelegateCommand CustomNavigateCommand => new DelegateCommand(async () =>
        {
            await _navigationService.NavigateAsync(nameof(CustomizablePage));
        });
    }
}
