using BodyIndexMass.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BodyIndexMass.Views
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