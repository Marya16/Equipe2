using Microsoft.Maui.Controls;
using Modelos;
using Equipe2_1;

namespace Equipe2_1
{
    public partial class CadastrarClientePage : ContentPage
    {
        public CadastrarClientePage()
        {
            InitializeComponent();
           
        }

         protected override void OnAppearing()
  {
    base.OnAppearing();

    if (cliente != null)
    {
      //IdLabel.Text        = cliente.ID.ToString();
      NomeEntry.Text      = cliente.Nome;
      SobrenomeEntry.Text = cliente.Sobrenome;
      TelefoneEntry.Text  = cliente.Telefone;
      CPFEntry.Text  = cliente.CPF;
    }
        }
          private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    
      var cliente = new Modelos.Cliente();
      
      cliente.ID      = 0;
      cliente.Nome      = NomeEntry.Text;
      cliente.Sobrenome      = SobrenomeEntry.Text;
      cliente.CPF  = CPFEntry.Text;
      cliente.Telefone  = TelefoneEntry.Text;
      
      
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
  }
         public Cliente cliente { get; set; }
        private void VoltarClicked (object sender, EventArgs e)  
      {
        Application.Current.MainPage= new MainPage();
      }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Lógica para salvar os dados
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            // Lógica para registrar o cliente
        }

        private void OnAlreadyRegisteredClicked(object sender, EventArgs e)
        {
            // Lógica para redirecionar para a página de login ou outra página
        }
        private async void OnRegister1Clicked(object sender, EventArgs e)
        {
            // Registration logic here
            await DisplayAlert("Cadastro", "Salvo com sucesso!", "OK");
        }
        
          
    }
}
