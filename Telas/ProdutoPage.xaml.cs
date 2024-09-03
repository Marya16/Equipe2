using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class ProdutoPage : ContentPage
    {
        public ProdutoPage()
        {
            InitializeComponent();
        }

        private void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            // Logic to save data
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            // Logic to clear data
            TipoProdutoEntry.Text = string.Empty;
            FornecedorEntry.Text = string.Empty;
            CodigoProdutoEntry.Text = string.Empty;
            MarcaEntry.Text = string.Empty;
            UnidadePicker.SelectedIndex = -1;
        }
          private void Voltar1Clicked (object sender, EventArgs e)  
      {
        Application.Current.MainPage= new MainPage();
      }
      private async void OnRegisdter3Clicke(object sender, EventArgs e)
        {
            // Registration logic here
            await DisplayAlert("Cadastro", "Salvo com sucesso!", "OK");
        }
    }
}
