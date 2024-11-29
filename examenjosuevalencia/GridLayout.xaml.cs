namespace examenjosuevalencia
{
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            string firstName = FirstNameEntry.Text;
            string secondName = SecondNameEntry.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(secondName))
            {
                await DisplayAlert("Error", "Por favor, ingrese todos los datos.", "OK");
                return;
            }

            await DisplayAlert("Datos Guardados", $"Primer Nombre: {firstName}\nSegundo Nombre: {secondName}", "OK");
        }
    }
}
