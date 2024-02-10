using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackerX.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBusPage : ContentPage

	{ public IList<String> IList { get; set; }
		public SearchBusPage ()
		{
			InitializeComponent ();
            IList = new List<String> ();
       
          
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemDetailPage());
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }
    }
}