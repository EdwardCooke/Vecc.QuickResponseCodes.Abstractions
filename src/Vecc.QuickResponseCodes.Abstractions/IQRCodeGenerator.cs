using System.Threading.Tasks;

namespace Vecc.QuickResponseCodes.Abstractions
{
    public interface IQRCodeGenerator
    {
        /// <summary>
        ///     Gets a QR Code containing the specified data.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorTolleranceLevel">Error tollerance of the QR code.</param>
        /// <param name="imageFormat">Image format to return the QR code in</param>
        /// <param name="dimensions">Width/height of the QR code. It is always a square.</param>
        /// <param name="border">Pixels surrounding the QR code.</param>
        /// <param name="pixelSize">Width/height of the pixel in the QR image.</param>
        /// <param name="backgroundColor">Color for the background of the image. Defaults to transparent.</param>
        /// <param name="foregroundColor">Color for the foreground of the image. Defaults to black.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(string data,
                                    ErrorTolleranceLevel errorTolleranceLevel = ErrorTolleranceLevel.VeryLow,
                                    QRCodeImageFormat imageFormat = QRCodeImageFormat.Png,
                                    int dimensions = 100,
                                    int border = 4,
                                    int pixelSize = 4,
                                    QRColor backgroundColor = null,
                                    QRColor foregroundColor = null);

        /// <summary>
        ///     Gets a QR Code containing the specified data.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorTolleranceLevel">Error tollerance of the QR code.</param>
        /// <param name="imageFormat">Image format to return the QR code in</param>
        /// <param name="dimensions">Width/height of the QR code. It is always a square.</param>
        /// <param name="border">Pixels surrounding the QR code.</param>
        /// <param name="pixelSize">Width/height of the pixel in the QR image.</param>
        /// <param name="backgroundColor">Color for the background of the image. Defaults to transparent.</param>
        /// <param name="foregroundColor">Color for the foreground of the image. Defaults to black.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(byte[] data,
                                    ErrorTolleranceLevel errorTolleranceLevel = ErrorTolleranceLevel.VeryLow,
                                    QRCodeImageFormat imageFormat = QRCodeImageFormat.Png,
                                    int dimensions = 100,
                                    int border = 4,
                                    int pixelSize = 4,
                                    QRColor backgroundColor = null,
                                    QRColor foregroundColor = null);
    }
}
