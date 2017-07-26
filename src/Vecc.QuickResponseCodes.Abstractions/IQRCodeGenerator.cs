using System.Threading.Tasks;

namespace Vecc.QuickResponseCodes.Abstractions
{
    public interface IQRCodeGenerator
    {
        /// <summary>
        ///     Gets a QR Code containing the specified data. Defaults to VeryLow error tollerance and a png image format.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(string data);

        /// <summary>
        ///     Gets a QR Code containing the specified data. Defaults to VeryLow error tollerance and a png image format.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(byte[] data);

        /// <summary>
        ///     Gets a QR Code containing the specified data with the allowed error tollerance. Defaults to a png image format.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorTolleranceLevel">Error tollerance of the QR code.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(string data, ErrorTolleranceLevel errorTolleranceLevel);

        /// <summary>
        ///     Gets a QR Code containing the specified data with the allowed error tollerance. Defaults to a png image format.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorTolleranceLevel">Error tollerance of the QR code.</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(byte[] data, ErrorTolleranceLevel errorTolleranceLevel);

        /// <summary>
        ///     Gets a QR Code containing the specified data with the allowed error tollerance using the specified image format.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorTolleranceLevel">Error tollerance of the QR code.</param>
        /// <param name="imageFormat">Image format to return the QR code in</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(string data, ErrorTolleranceLevel errorTolleranceLevel, QRCodeImageFormat imageFormat);

        /// <summary>
        ///     Gets a QR Code containing the specified data with the allowed error tollerance using the specified image format.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="errorTolleranceLevel">Error tollerance of the QR code.</param>
        /// <param name="imageFormat">Image format to return the QR code in</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(byte[] data, ErrorTolleranceLevel errorTolleranceLevel, QRCodeImageFormat imageFormat);

        /// <summary>
        ///     Gets a QR Code containing the specified data using the specified image format. Defaults to a VeryLow error tollerance.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="imageFormat">Image format to return the QR code in</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(string data, QRCodeImageFormat imageFormat);

        /// <summary>
        ///     Gets a QR Code containing the specified data using the specified image format. Defaults to a VeryLow error tollerance.
        /// </summary>
        /// <param name="data">Data to put in the QR image.</param>
        /// <param name="imageFormat">Image format to return the QR code in</param>
        /// <returns>A byte array containing the QR code.</returns>
        Task<byte[]> GetQRCodeAsync(byte[] data, QRCodeImageFormat imageFormat);
    }
}
