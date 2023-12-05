using System.IO;
using System.Windows.Media.Imaging;

namespace LUNAR_Engine.Engine.Sprites
{
    public static class SpriteFactory
    {

        public static Sprite Create(string imagePath)
        {
            return new Sprite(CreateBitmap(imagePath));
        }

        public static Sprite CreateFromBitmap(BitmapImage bitmapImage)
        {
            return new Sprite(bitmapImage);
        }

        public static BitmapImage CreateBitmap(string imagePath)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imagePath);
            bitmapImage.EndInit();
            return bitmapImage;
        }

        public static BitmapImage CreateBitmap(CroppedBitmap croppedBitmap)
        {
            BitmapSource bitmapSource = BitmapFrame.Create(croppedBitmap);

            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            MemoryStream memoryStream = new MemoryStream();
            BitmapImage bImg = new BitmapImage();

            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
            encoder.Save(memoryStream);

            memoryStream.Position = 0;
            bImg.BeginInit();
            bImg.StreamSource = memoryStream;
            bImg.EndInit();

            memoryStream.Close();


            return bImg;
        }

    }
}
