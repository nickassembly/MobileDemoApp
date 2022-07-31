using MobileAppDemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileAppDemo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}