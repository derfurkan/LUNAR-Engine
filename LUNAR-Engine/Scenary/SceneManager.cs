using System.Windows;

namespace LUNAR_Engine.Engine.Scenary
{
    internal class SceneManager
    {

        public GameScene? CurrentGameScene { get; set; }
        public MenuScene? CurrentMenuScene { get; set; }

        private Window ManagerWindow;

        public SceneManager(Window managerWindow)
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
                // ManagerWindow.UpdateGameScene();
            }
        }




    }
}
