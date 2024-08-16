using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class CadastroEstoquePage : ContentPage
    {
        public CadastroEstoquePage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Registration logic here
            await DisplayAlert("Cadastro", "Produto cadastrado com sucesso!", "OK");
        }
    }
}
