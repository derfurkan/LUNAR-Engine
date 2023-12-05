using LUNAR_Engine.Engine.GameObjects;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LUNAR_Engine.Engine.Scenary;

public class GameScene
{

    public Grid Content = new();

    public Dictionary<IGameObject, Image> GameObjectsDictionary = new();

    public string SceneName;

    public GameScene(string sceneName, System.Drawing.Color backgroundColor)
    {
        SceneName = sceneName;
        Content.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(backgroundColor.A, backgroundColor.R, backgroundColor.G, backgroundColor.B));
    }

    public void AddGameObject(IGameObject gameObject)
    {
        var image = gameObject.InitialSprite.BuildImage();
        image.Width = gameObject.ObjectBoundaries.Width;
        image.Height = gameObject.ObjectBoundaries.Height;
        image.Margin = new Thickness(gameObject.ObjectLocation.X, gameObject.ObjectLocation.Y, 0, 0);

        image.RenderTransformOrigin = new Point(0.5, 0.5);
        GameObjectsDictionary.Add(gameObject, image);
        Content.Children.Add(image);
    }

    public void UpdateGameObject(IGameObject gameObject)
    {
        RemoveGameObject(gameObject);
        AddGameObject(gameObject);
    }

    public void RemoveGameObject(IGameObject gameObject)
    {
        Content.Children.Remove(GameObjectsDictionary[gameObject]);
        GameObjectsDictionary.Remove(gameObject);
    }

    public void UpdateAllGameObjects()
    {
        foreach (var gameObject in new List<IGameObject>(GameObjectsDictionary.Keys))
        {
            UpdateGameObject(gameObject);


        }
    }



}