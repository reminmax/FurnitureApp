using FreshMvvm;
using FurnitureApp.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace FurnitureApp.PageModels
{
    internal class FurnitureItemPageModel : FreshBasePageModel
    {
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        public FurnitureItem FurnitureItem { get; private set; }
        public ObservableCollection<string> ColorList { get; set; }

        private string _mainImageSource;
        private string _name;
        private string _description;
        private string _selectedColor;
        private int _number;

        public FurnitureItemPageModel()
        {
            ChangeNumberCommand = CommandFactory.Create<string>(ChangeNumber);
            NavigateBackCommand = CommandFactory.Create(NavigateBackAsync);
            Number = 1;
        }

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                RaisePropertyChanged();
            }
        }

        public string SelectedColor
        {
            get => _selectedColor;
            set
            {
                _selectedColor = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }

        public string MainImageSource
        {
            get => _mainImageSource;
            set
            {
                _mainImageSource = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ChangeNumberCommand { get; set; }
        public IAsyncCommand NavigateBackCommand { get; }

        private async Task NavigateBackAsync()
        {
            await CoreMethods.PopPageModel();
        }

        private void ChangeNumber(string mode)
        {
            if (mode == "inc")
                Number++;
            else
                Number = Number == 1 ? 1 : Number-1;
        }

        public override void Init(object initData)
        {
            if (initData is null) return;

            if (initData is FurnitureItem furnitureItem)
            {
                FurnitureItem = furnitureItem;
                Name = furnitureItem.Name;
                Description = furnitureItem.Description;
                Image1 = FurnitureItem.Images[0];
                Image2 = FurnitureItem.Images[1];
                Image3 = FurnitureItem.Images[2];

                ColorList = new ObservableCollection<string>(furnitureItem.ColorsList);
                if (ColorList.Any())
                    SelectedColor = ColorList.FirstOrDefault();
            }

            base.Init(initData);
        }

    }
}
