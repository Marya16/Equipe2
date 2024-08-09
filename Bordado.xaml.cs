using Microsoft.Maui.Controls;

namespace Eq2
{
    public partial class EmbroideryPage : ContentPage
    {
        public EmbroideryPage()
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
            QuantidadePicker.SelectedIndex = -1;
        }
    }
}
