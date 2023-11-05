using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependencyServicesSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRScannerDemo : ContentPage
    {

        private async void ScanButton_Clicked(object sender, EventArgs e)
        {
            var scanner = DependencyService.Get<IQRScanner>();
            if (scanner != null)
            {
                string result = await scanner.ScanAsync();
                resultLabel.Text = result;
            }
            else
            {
                resultLabel.Text = "El escáner QR no está disponible en este dispositivo.";
            }
        }
    }
}