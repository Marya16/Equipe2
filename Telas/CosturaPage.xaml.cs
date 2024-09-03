using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class CosturaPage : ContentPage
    {
        public CosturaPage()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Logic to save data
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Logic to handle cancellation
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            // Logic to clear data
            ProdutoEntry.Text = string.Empty;
            EntradaEntry.Text = string.Empty;
            QuantidadePicker.SelectedIndex = -1;
            PrazoEntry.Text = string.Empty;
        }
         private void Voltar2Clicked (object sender, EventArgs e)  
      {
        Application.Current.MainPage= new MainPage();
      }
      private async void OnSalvar1Clicked(object sender, EventArgs e)
        {
            // Registration logic here
            await DisplayAlert("Cadastro", "Salvo com sucesso!", "OK");
        }
    }
}
