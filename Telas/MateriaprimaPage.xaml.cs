using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class MateriaprimaPage : ContentPage
    {
        public MateriaprimaPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Save logic here
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            // Cancel logic here
            bool result = await DisplayAlert("Cancelar", "Tem certeza que deseja cancelar?", "Sim", "Não");
            if (result)
            {
                // Logic to handle cancellation
            }
        }
    }
}
