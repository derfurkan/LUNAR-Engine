using LUNAR_Engine.Engine.Animations;
using LUNAR_Engine.Engine.Scenary;
using LUNAR_Engine.Engine.Sprites;

namespace LUNAR_Engine.Engine.GameObjects;

public interface IGameObject
{

    public ObjectLocation ObjectLocation { get; set; }

    public int ObjectId { get; set; }

    public List<ObjectAttributes> ObjectAttributes { get; set; }

    public Animator? ObjectAnimator { get; set; }

    public ObjectBoundaries ObjectBoundaries { get; set; }

    public GameScene? GameScene { get; set; }

    public Sprite InitialSprite { get; set; }

    public void Render();

    public void Update();

    public void Destroy();

}