

namespace Equipe2_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClienteClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage= new ClientePage();
            // Navigate to the Cliente page
            // Navigation.PushAsync(new ClientePage());
        }

        private void OnFornecedorClicked(object sender, EventArgs e)
        { 
			Application.Current.MainPage= new FornecedorPage();
            // Navigate to the Fornecedor page
            // Navigation.PushAsync(new FornecedorPage());
        }

        private void OnEstoqueClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage= new EstoquePage();
            // Navigate to the Estoque page
            // Navigation.PushAsync(new EstoquePage());
        }

        private void OnCorteClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage= new CortePage();
            // Navigate to the Corte page
            // Navigation.PushAsync(new CortePage());
        }

        private void OnBordadoClicked(object sender, EventArgs e)
        {
            // Navigate to the Bordado page
            // Navigation.PushAsync(new BordadoPage());
        }
    }
}
