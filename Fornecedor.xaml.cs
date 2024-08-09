using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace  Equipe2_1
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> materiaPrimaList;

        public MainPage()
        {
            InitializeComponent();
            materiaPrimaList = new ObservableCollection<string>();
            MateriaPrimaList.ItemsSource = materiaPrimaList;
        }

        private async void OnAddMateriaPrimaClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Matéria Prima", "Adicionar nova matéria prima:");
            if (!string.IsNullOrWhiteSpace(result))
            {
                materiaPrimaList.Add(result);
            }
        }
    }
}
