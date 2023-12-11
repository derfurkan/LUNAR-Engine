
using LUNAR_Engine.Engine.Sprites;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LUNAR_Engine.Engine.Animations
{
    public class AnimationFactory
    {

        public static Animation CreateFromAtlas(Image atlasImage, int numColumns, int numRows, int ticksPerFrame)
        {
            if (atlasImage == null)
            {
                throw new ArgumentNullException(nameof(atlasImage), "Source image cannot be null.");
            }

            if (numColumns <= 0 || numRows <= 0)
            {
                throw new ArgumentException("Number of columns and rows must be greater than zero.");
            }

            double imageWidth = atlasImage.ActualWidth;
            double imageHeight = atlasImage.ActualHeight;

            double pieceWidth = imageWidth / numColumns;
            double pieceHeight = imageHeight / numRows;

            List<Sprite> pieces = new List<Sprite>();

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numColumns; col++)
                {
                    Int32Rect sourceRect = new Int32Rect((int)(col * pieceWidth), (int)(row * pieceHeight), (int)pieceWidth, (int)pieceHeight);
                    CroppedBitmap croppedBitmap = new CroppedBitmap((BitmapSource)atlasImage.Source, sourceRect);

                    pieces.Add(SpriteFactory.CreateFromBitmap(SpriteFactory.CreateBitmap(croppedBitmap)));
                }
            }

            return new Animation(pieces, ticksPerFrame);
        }

        public static Animation CreateFromImagePath(string[] imagePath, int ticksPerFrame)
        {
            List<Sprite> sprites = new List<Sprite>();
            foreach (var path in imagePath)
            {
                sprites.Add(SpriteFactory.Create(path));
            }
            return new Animation(sprites, ticksPerFrame);
        }

        public static Animation CreateFromDirectory(string directoryPath, int ticksPerFrame)
        {
            List<Sprite> sprites = new List<Sprite>();
            foreach (var item in Directory.GetFiles(directoryPath))
            {
                if (Regex.IsMatch(item, @"\.png$|\.jpg$"))
                {
                    sprites.Add(SpriteFactory.Create(item));
                }
            }
            return new Animation(sprites, ticksPerFrame);
        }
    }
}
