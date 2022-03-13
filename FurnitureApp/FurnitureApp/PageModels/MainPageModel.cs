using FreshMvvm;
using FurnitureApp.Models;
using FurnitureApp.Services.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace FurnitureApp.PageModels
{
    internal class MainPageModel : FreshBasePageModel
    {
        public ObservableCollection<FurnitureCategory> Categories { get; private set; }
        public ObservableCollection<FurnitureItem> FurnitureItems { get; private set; }

        private IDataService _sampleDataService;
        private FurnitureCategory _selectedCategoryItem;

        public MainPageModel(IDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;

            Categories = new ObservableCollection<FurnitureCategory>();
            FurnitureItems = new ObservableCollection<FurnitureItem>();

            FurnitureItemSelectionChangedCommand = CommandFactory.Create<FurnitureItem>(ExecuteFurnitureItemSelectionChangedAsync);
        }

        private async Task ExecuteFurnitureItemSelectionChangedAsync(FurnitureItem selectedItem)
        {
            await CoreMethods.PushPageModel<FurnitureItemPageModel>(selectedItem);
        }

        public IAsyncCommand<FurnitureItem> FurnitureItemSelectionChangedCommand { get; }

        public FurnitureCategory SelectedCategoryItem
        {
            get => _selectedCategoryItem;
            set
            {
                _selectedCategoryItem = value;
                RaisePropertyChanged();

                //ExecuteSelectCategoryItem();
            }
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            FillCategoriesCollection();
            FillFurnitureItemsCollection();
        }

        private void FillFurnitureItemsCollection()
        {
            FurnitureItems.Clear();

            List<FurnitureItem> items = _sampleDataService.GetItems();
            foreach (var item in items)
            {
                FurnitureItems.Add(item);
            }
        }

        private void FillCategoriesCollection()
        {
            Categories.Clear();

            List<FurnitureCategory> categories = _sampleDataService.GetCategories();
            foreach (var item in categories)
            {
                Categories.Add(item);
            }

            if (Categories.Any())
            {
                //SelectedCategoryItem = Categories.First();
                SelectedCategoryItem = Categories.Where(p => p.IsSelected).FirstOrDefault();
            }
        }
    }
}
