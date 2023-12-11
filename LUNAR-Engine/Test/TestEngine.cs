using LUNAR_Engine.Engine.GameObjects;
using LUNAR_Engine.Engine.Scenary;
using LUNAR_Engine.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUNAR_Engine.Test
{
    public static class TestEngine
    {
        [STAThread]
        public static void Main(string[] args)
        {
            EngineWindow engineWindow = new("Test", new(100, 100), new(800, 600));
            GameScene gameScene = new("Test", System.Drawing.Color.Black);
            TestObject testObject = new(new(100, 100), gameScene);
            gameScene.AddGameObject(testObject);
            engineWindow.SceneManager.SwitchToScene(gameScene);

        }

    }
}
