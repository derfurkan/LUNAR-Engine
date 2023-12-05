
using LUNAR_Engine.Engine.GameObjects;

namespace LUNAR_Engine.Engine.Animations;

public class Animator
{

    private IGameObject _gameObject { get; set; }

    public Animation? CurrentlyPlayingAnimation { get; set; }

    public List<Animation> AnimationQueue = new();

    public Animator(IGameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public void QueueAnimation(Animation animation)
    {
        AnimationQueue.Add(animation);
        if (CurrentlyPlayingAnimation == null)
        {
            CurrentlyPlayingAnimation = AnimationQueue[0];
        }
    }

    public void ForcePlayAnimation(Animation animation)
    {
        CurrentlyPlayingAnimation = animation;
    }

    public void TickAnimation()
    {
        if (CurrentlyPlayingAnimation == null)
        {
            return;
        }
        var nextFrame = CurrentlyPlayingAnimation.GetNextFrame();
        if (nextFrame == null)
        {
            if (AnimationQueue.Count > 0)
            {
                CurrentlyPlayingAnimation = AnimationQueue[0];
                AnimationQueue.RemoveAt(0);
                return;
            }
            else
            {
                CurrentlyPlayingAnimation = null;
                return;
            }
        }
        _gameObject.InitialSprite = nextFrame;
    }

    public void StopAnimation()
    {
        CurrentlyPlayingAnimation = null;
    }



}