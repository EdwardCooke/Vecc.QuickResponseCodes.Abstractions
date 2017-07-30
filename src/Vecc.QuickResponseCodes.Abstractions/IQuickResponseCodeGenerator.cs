using System.Threading.Tasks;

namespace Vecc.QuickResponseCodes.Abstractions
{
    public interface IQuickResponseCodeGenerator
    {
        /// <summary>
        ///     Gets a QR Code containing the specified data.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorToleranceLevel">Error tolerance of the QR code.</param>
        /// <param name="codeImageFormat">Image format to return the QR code in</param>
        /// <param name="dimensions">Width/height of the QR code. It is always a square.</param>
        /// <param name="border">Pixels surrounding the QR code.</param>
        /// <param name="backgroundColor">Color for the background of the image. Defaults to transparent.</param>
        /// <param name="foregroundColor">Color for the foreground of the image. Defaults to black.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQuickResponseCodeAsync(string data,
                                               ErrorToleranceLevel errorToleranceLevel = ErrorToleranceLevel.VeryLow,
                                               CodeImageFormat codeImageFormat = CodeImageFormat.Png,
                                               int dimensions = 100,
                                               int border = 4,
                                               Color backgroundColor = null,
                                               Color foregroundColor = null);

        /// <summary>
        ///     Gets a QR Code containing the specified data.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorToleranceLevel">Error tolerance of the QR code.</param>
        /// <param name="codeImageFormat">Image format to return the QR code in</param>
        /// <param name="dimensions">Width/height of the QR code. It is always a square.</param>
        /// <param name="border">Pixels surrounding the QR code.</param>
        /// <param name="backgroundColor">Color for the background of the image. Defaults to transparent.</param>
        /// <param name="foregroundColor">Color for the foreground of the image. Defaults to black.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQuickResponseCodeAsync(byte[] data,
                                               ErrorToleranceLevel errorToleranceLevel = ErrorToleranceLevel.VeryLow,
                                               CodeImageFormat codeImageFormat = CodeImageFormat.Png,
                                               int dimensions = 100,
                                               int border = 4,
                                               Color backgroundColor = null,
                                               Color foregroundColor = null);
    }
}
