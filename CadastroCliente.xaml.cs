using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class CadastrarClientePage : ContentPage
    {
        public CadastrarClientePage()
        {
            InitializeComponent();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            SobrenomeEntry.Text = string.Empty;
            CPFEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
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
    }
}
