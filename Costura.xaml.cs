using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class SewingPage : ContentPage
    {
        public SewingPage()
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
    }
}
