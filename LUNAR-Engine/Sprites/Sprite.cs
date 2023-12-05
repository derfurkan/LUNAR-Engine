using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LUNAR_Engine.Engine.Sprites
{
    public class Sprite
    {

        public BitmapImage BitmapImage;

        public Sprite(BitmapImage bitmapImage) { BitmapImage = bitmapImage; }

        private List<SpriteModification> SpriteModifications { get; set; } = new();

        public Image BuildImage()
        {
            var image = new Image();
            image.Source = BitmapImage;
            ApplyImageModifications(image);
            return image;
        }

        public void AddSpriteModification(SpriteModification modification)
        {
            if (!SpriteModifications.Contains(modification))
                SpriteModifications.Add(modification);
        }

        public void RemoveSpriteModification(SpriteModification modification)
        {
            SpriteModifications.Remove(modification);
        }

        private void ApplyImageModifications(Image image)
        {
            foreach (var modification in SpriteModifications)
            {
                switch (modification)
                {
                    case SpriteModification.FlipHorizontally:
                        image.RenderTransform = new System.Windows.Media.ScaleTransform(-1, 1);
                        break;
                    case SpriteModification.FlipVertically:
                        image.RenderTransform = new System.Windows.Media.ScaleTransform(1, -1);
                        break;
                }
            }
        }



        public enum SpriteModification
        {
            FlipHorizontally,
            FlipVertically
        }


    }
}
