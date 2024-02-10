using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerX.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackerX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            Checkbox.CheckedChanged += Checkbox_CheckedChanged;
        }


        private void Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //Button clickedButton = (Button)sender;

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

            if (UsernameEntry.Text == "admin" && PasswordEntry.Text == "123")
            {
                Navigation.PushAsync(new ItemDetailPage());
            }
            else
            {
                DisplayAlert("Oops..", "Username or Password is incorrect", "Ok");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());

        }

        private async void Forgotpasswordbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPassPage());
            
            
        }
    }
}