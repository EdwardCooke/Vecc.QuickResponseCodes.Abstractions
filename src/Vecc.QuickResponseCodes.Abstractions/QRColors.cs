namespace Vecc.QuickResponseCodes.Abstractions
{
    public static class QRColors
    {
        public static QRColor Black => new QRColor(0, 0, 0);
        public static QRColor Blue => new QRColor(0, 0, 255);
        public static QRColor Green => new QRColor(0, 255, 0);
        public static QRColor Red => new QRColor(255, 0, 0);
        public static QRColor Transparent => new QRColor(0, 0, 0, 0);
        public static QRColor White => new QRColor(255, 255, 255);
    }
}
