using Mobile_AP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mobile_AP.Views
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