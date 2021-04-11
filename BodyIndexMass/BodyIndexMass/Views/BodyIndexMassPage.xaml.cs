using BodyIndexMass.Database;
using BodyIndexMass.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BodyIndexMass.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BodyIndexMassPage : ContentPage
    {
        BodyIndexMassEntityViewModel bimp = new BodyIndexMassEntityViewModel();

        public BodyIndexMassPage()
        {
            InitializeComponent();

            BindingContext = bimp;
        }


        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            bimp.Save();
            await DisplayAlert("Saved", "Save successfully", "Ok");
        }
    }
}