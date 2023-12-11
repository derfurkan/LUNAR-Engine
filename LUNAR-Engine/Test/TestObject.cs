using LUNAR_Engine.Engine.Animations;
using LUNAR_Engine.Engine.GameObjects;
using LUNAR_Engine.Engine.Scenary;
using LUNAR_Engine.Engine.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUNAR_Engine.Test
{
    public class TestObject : IGameObject
    {

        public List<ObjectAttributes> ObjectAttributes { get; set; }
        public Animator? ObjectAnimator { get; set; }
        public ObjectBoundaries ObjectBoundaries { get; set; }
        public GameScene? GameScene { get; set; }
        public Sprite InitialSprite { get; set; }
        public ObjectLocation ObjectLocation { get; set; }
        public int ObjectId { get; set; }


        public TestObject(ObjectLocation objectLocation,GameScene gameScene) {
            ObjectLocation = objectLocation;
            ObjectId = RandomManager.GetRandomInt(0,100);
            ObjectAttributes = new();
            ObjectBoundaries = new(100, 100);
            InitialSprite = SpriteFactory.Create("C:\\Users\\Furkan\\Pictures\\180016.jpg");
            GameScene = gameScene;
        }

    public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
