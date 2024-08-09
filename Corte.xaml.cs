using Microsoft.Maui.Controls;
using System;

namespace Equipe2_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Handle save logic here
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Handle cancel logic here
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Handle delete logic here
            ProductTypeEntry.Text = string.Empty;
            DescriptionEntry.Text = string.Empty;
            ProductCodeEntry.Text = string.Empty;
            QuantityPicker.SelectedIndex = -1;
        }
    }
}
