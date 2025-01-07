using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Lab5.MAUI.Interfaces;
using Lab5.MAUI.Models;

namespace Lab5.MAUI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDataRepository _dataRepository;

        public MainPageViewModel(IDataRepository dataRepository)
        {
            Title = "Loading ...";
            _dataRepository = dataRepository;

            LoadCommand = new RelayCommand(LoadData);
          //  SelectOwnerCommand = new RelayCommand(ShowDetails);

            LoadData();
        }

       /* public async void ShowDetails()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "Owner", SelectedOwner }
            };

            await Shell.Current.GoToAsync("//AnimalssPage", navigationParameter);
        } */

        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private Owner[] _owners;

        public Owner[] Owners
        {
            get
            {
                return _owners;
            }
            set
            {
                _owners = value;
                OnPropertyChanged();
            }
        }

        private Owner _selectedOwner;
        public Owner SelectedOwner
        {
            get
            {
                return _selectedOwner;
            }
            set
            {
                _selectedOwner = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadCommand { get; }

        public ICommand SelectOwnerCommand { get; }

        public async void LoadData()
        {
            Title = "Loading ...";

            var data = await _dataRepository.GetOwnersAsync();
            Owners = data;
            Title = "Number of owners: " + data.Length;
        }
    }
}

