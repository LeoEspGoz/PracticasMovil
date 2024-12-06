using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void OnSumButtonClick(object sender, RoutedEventArgs e)
        {
            // Obtiene los valores ingresados
            string input1 = Number1TextBox.Text;
            string input2 = Number2TextBox.Text;

            // Convierte los valores a enteros
            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                // Calcula la suma
                int sum = number1 + number2;

                // Muestra el resultado
                ResultTextBlock.Text = $"La suma de {number1} y {number2} es {sum}";
            }
            else
            {
                // Muestra un mensaje de error si los valores no son válidos
                ResultTextBlock.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}
