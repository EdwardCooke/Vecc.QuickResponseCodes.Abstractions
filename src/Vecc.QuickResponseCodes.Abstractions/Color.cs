namespace Vecc.QuickResponseCodes.Abstractions
{
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public Color()
        {

        }

        public Color(byte red, byte green, byte blue)
            : this(red, green, blue, 255)
        {
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Blue = blue;
            this.Green = green;
            this.Red = red;
            this.Alpha = alpha;
        }
    }
}
