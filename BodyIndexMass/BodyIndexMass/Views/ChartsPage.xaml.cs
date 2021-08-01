using BodyIndexMass.Models;
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
	public partial class Charts : ContentPage
	{
		public ChartDatabase chart = new ChartDatabase();
		
		public Charts ()
		{
			BindingContext = chart;
			
			InitializeComponent ();
		}
	}
}