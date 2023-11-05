using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServicesSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          

        }
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
                resultLabel.Text = "El escáner QR no está disponible en este dispositivo .";
            }
        }
    }
}
