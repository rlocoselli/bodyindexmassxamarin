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
        Models.BodyIndexMassEntity bimp = new Models.BodyIndexMassEntity();

        BodyIndexMassData db = new BodyIndexMassData();

        public BodyIndexMassPage()
        {
            InitializeComponent();

            BindingContext = bimp;
        }

        public async void Calculate_Cliked(object sender, EventArgs e)
        {
            lblResult.Text = bimp.Result.ToString("0.00");
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            bimp.DateTime = DateTime.Now;
            await db.SaveBodyAsync(bimp);
            DisplayAlert("Saved", "Save successfully", "Ok");
        }
    }
}