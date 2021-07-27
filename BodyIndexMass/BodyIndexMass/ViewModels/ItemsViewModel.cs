using BodyIndexMass.Database;
using BodyIndexMass.Models;

using BodyIndexMass.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BodyIndexMass.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private BodyIndexMassEntity _selectedItem;

        public ObservableCollection<BodyIndexMassEntity> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<BodyIndexMassEntity> ItemTapped { get; }

        public ItemsViewModel()
        {
            Title = AppResources.Historical;
            Items = new ObservableCollection<BodyIndexMassEntity>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                BodyIndexMassData db = new BodyIndexMassData();
                var items = await db.GetBodyAsync();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public BodyIndexMassEntity SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
            }
        }
    }
}