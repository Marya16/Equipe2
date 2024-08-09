using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class ConfirmationPage : ContentPage
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        private async void OnYesButtonClicked(object sender, EventArgs e)
        {
            // Handle Yes button click
            await DisplayAlert("Confirmed", "You have confirmed the action.", "OK");
        }

        private async void OnNoButtonClicked(object sender, EventArgs e)
        {
            // Handle No button click
            await Navigation.PopAsync();
        }
    }
}
