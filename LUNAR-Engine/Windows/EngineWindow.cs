using LUNAR_Engine.Engine.GameObjects;
using LUNAR_Engine.Engine.Scenary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace LUNAR_Engine.Windows
{
    public class EngineWindow : Window
    {
        public SceneManager SceneManager { get; set; }

        public EngineWindow(string title, ObjectLocation objectLocation, ObjectBoundaries objectBoundaries)
        {
            SceneManager = new SceneManager(this);
            this.Title = title;

            this.Left = objectLocation.X;
            this.Top = objectLocation.Y;
            this.MinWidth = objectBoundaries.Width;
            this.MinHeight = objectBoundaries.Height;
            this.MaxWidth = objectBoundaries.Width;
            this.MaxHeight = objectBoundaries.Height;
            new Application().Run(this);

        }


    }
}
