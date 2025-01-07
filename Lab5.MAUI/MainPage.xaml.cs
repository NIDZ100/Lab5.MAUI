
using Lab5.MAUI.ViewModels;
//using Lab5.MAUIData.Interfaces;
//using Lab5.MAUIData.Services;
using Lab5.MAUI.ViewModels;
using Newtonsoft.Json;


namespace Lab5.MAUI;

    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _viewModel;

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }
    }


