using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZXing.Mobile;

namespace DependencyServicesSample
{
    public class QRScanner : IQRScanner
    {
        public async Task<string> ScanAsync()
        {
            try
            {
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();

                if (result != null)
                {
                    return result.Text;
                }
                else
                {
                    return "No se ha escaneado ningún código QR.";
                }
            }
            catch (Exception ex)
            {
                return "Error al escanear el código QR: " + ex.Message;
            }
        }
    }
}
