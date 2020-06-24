using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace GantChart.Controllers
{
    class ImageController
    {
        public static byte[] ConvertToByteArray(Image image)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] _byte = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            return _byte;
        }
        public static Image ConvertToImage(byte[] _byte)
        {
            return (Bitmap)((new ImageConverter()).ConvertFrom(_byte));
        }
    }
}