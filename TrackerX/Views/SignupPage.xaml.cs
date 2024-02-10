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
    public partial class SignupPage : ContentPage
    {
        

        public SignupPage()
        {
            InitializeComponent();
            Checkbox.CheckedChanged += Checkbox_CheckedChanged;

        }

        private void Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            

            if (e.Value)
            {
                PasswordEntry.IsPassword = false;
            }
            else
            {
                PasswordEntry.IsPassword = true;
            }


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (UsernameEntry.Text == "admin" && NumberEntry.Text == "0763228773" &&  PasswordEntry.Text == "123" && ComfirmPasswordEntry.Text == "123")
            {
 
                Navigation.PushAsync(new ItemDetailPage());
            }
            else
            {
                DisplayAlert("Oops..", "Incorrect data", "Ok");
            }
            

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());

        }

        private async void Forgotpasswordbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPassPage());

        }
    }
}