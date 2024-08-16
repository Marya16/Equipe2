using Microsoft.Maui.Controls;

namespace Equipe2_1
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
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
            CorEntry.Text = string.Empty;
        }
    }
}
