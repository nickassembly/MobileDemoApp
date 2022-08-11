using MobileAppDemo.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileAppDemo.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Coffee> Coffee { get; }
        public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; }
       
        public AsyncCommand RefreshCommand { get; }

        public CoffeeEquipmentViewModel()
        {

            Title = "Coffee Equipment";
            Coffee = new ObservableRangeCollection<Coffee>();
            CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();

            var image = "https://www.yesplz.coffee/app/uploads/202/11/emptybag-min.jpg";

            Coffee.Add(new Models.Coffee { Roaster = "Yes Plz", Name = "Sip of Sunshine", Image = "" });
            Coffee.Add(new Models.Coffee { Roaster = "Yes Plz", Name = "Potent Potable", Image = "" });
            Coffee.Add(new Models.Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu H", Image = "" });

            // TODO : Add grouping code 5:30 episode 8
           // CoffeeGroups.Add(new Grouping<string, Coffee>("Blue Bottle", new[] { }));

            RefreshCommand = new AsyncCommand(Refresh);
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }

        public ICommand IncreaseCount { get; }

        int count = 0;

        string countDisplay = "Click Me!";
        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} times";
        }
    }
}
