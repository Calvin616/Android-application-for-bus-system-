using System.ComponentModel;
using TrackerX.ViewModels;
using Xamarin.Forms;

namespace TrackerX.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }


        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FindRoutePage());
        }

        private void Button_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SearchBusPage());
        }

        private void Button_Clicked_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CreateJourneyPage());
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AddBusPage());
            
            

        }
    }
}