using Microsoft.Maui.Controls;

namespace Eq2
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public MateriaPrimaPage()
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
