using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class EstoquePage : ContentPage
    {
        public EstoquePage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Registration logic here
            await DisplayAlert("Cadastro", "Cadastrado com sucesso!", "OK");
        }
         private void VoltarClicked (object sender, EventArgs e)  
      {
        Application.Current.MainPage= new MainPage();
      }
    }
}
