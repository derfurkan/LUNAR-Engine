using LUNAR_Engine.Engine.GameObjects;
using LUNAR_Engine.Windows;
using System.Windows;
using System.Windows.Controls;

namespace LUNAR_Engine.Engine.Scenary
{
    public class SceneManager
    {

        public GameScene? CurrentGameScene { get; set; }
        public MenuScene? CurrentMenuScene { get; set; }

        private EngineWindow ManagerWindow;

        public SceneManager(EngineWindow managerWindow)
        {
            ManagerWindow = managerWindow;
        }

        public void SwitchToScene(object scene)
        {

            if (scene == null) return;

            if (scene is MenuScene menuScene)
            {

            }
            else if (scene is GameScene gameScene)
            {
                CurrentGameScene = gameScene;
                ManagerWindow.Content = gameScene.Content;
                gameScene.Content.Visibility = Visibility.Visible;
                ManagerWindow.UpdateLayout();
            }
        }




    }
}
