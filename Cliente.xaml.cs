using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Equipe2_1
{
    public partial class ClientePage : ContentPage
    {
        public ObservableCollection<string> Clientes { get; set; }

        public ClientePage()
        {
            InitializeComponent();
            Clientes = new ObservableCollection<string>
            {
                "Josefina...",
                "Josefina..."
                // Adicione mais clientes conforme necessário
            };
            BindingContext = this;
        }
    }
}
