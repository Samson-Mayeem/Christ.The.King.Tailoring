using CommerceUI.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CommerceUI.Views
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