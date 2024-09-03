using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class BordadoPage : ContentPage
    {
        public BordadoPage ()
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
            PrazoEntry.Text = string.Empty;
            EntradaEntry.Text = string.Empty;
            ProdutoEntry.Text = string.Empty;
           
        }
          private void Voltar4Clicked (object sender, EventArgs e)  
      {
        Application.Current.MainPage= new MainPage();
      }
       private async void OnSalvar5Clicked(object sender, EventArgs e)
        {
            // Registration logic here
            await DisplayAlert("Cadastro", " Salvo com sucesso!", "OK");
        }
    }
}
