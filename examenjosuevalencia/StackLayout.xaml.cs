using System.IO;

namespace examenjosuevalencia
{
    public partial class StackLayout : ContentPage
    {
        public StackLayout()
        {
            InitializeComponent();
        }

        private async void JBtn_Recargar_Click(object sender, EventArgs e)
        {
            string numero = JTex_NumeroJValencia.Text;
            string nombre = JTex_NombreJValencia.Text;

            if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(nombre))
            {
                await DisplayAlert("Error", "Por favor, ingrese todos los datos.", "OK");
                return;
            }

            string fileName = $"{nombre.Replace(" ", "")}.txt"; // Crear el archivo con el nombre
            string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

            // Escribir en el archivo
            File.WriteAllText(filePath, $"Nombre: {nombre}\nNúmero: {numero}");

            // Mostrar mensaje de confirmación
            await DisplayAlert("Recarga Exitosa", "La recarga se realizó correctamente.", "OK");

            // Actualizar el resumen
            JLbl_ResumenJValencia.Text = $"La última recarga realizada fue:\nNombre: {nombre}\nNúmero: {numero}";

            // Limpiar los campos
            JTex_NumeroJValencia.Text = string.Empty;
            JTex_NombreJValencia.Text = string.Empty;
        }
    }
}
