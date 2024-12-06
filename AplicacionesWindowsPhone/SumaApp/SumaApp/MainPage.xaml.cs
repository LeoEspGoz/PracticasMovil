using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SumaApp
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
        private async void OnLoadImageButtonClick(object sender, RoutedEventArgs e)
        {
            // URL de la imagen
            string imageUrl = "http://www.itsur.edu.mx/noticias/certificacion_Lean_Six_Sigma/index.php";

            // Crea un nuevo objeto BitmapImage
            BitmapImage bitmapImage = new BitmapImage();

            // Configura la fuente de la imagen
            bitmapImage.UriSource = new Uri(imageUrl, UriKind.Absolute);

            // Asigna la imagen al control Image
            ImageControl.Source = bitmapImage;
        }

    }
}
