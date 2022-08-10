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
        public ObservableRangeCollection<string> Coffee { get; }
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer);
            Coffee = new ObservableRangeCollection<string>();

            Title = "Coffee Equipment";
        }

        public ICommand CallServerCommand { get; }

        async Task CallServer()
        {
            var items = new List<string> { "Yes", "Duncan", "Blue Bottle" };
            Coffee.AddRange(items);
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
