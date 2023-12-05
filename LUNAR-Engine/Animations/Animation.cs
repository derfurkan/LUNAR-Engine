
using LUNAR_Engine.Engine.Sprites;

namespace LUNAR_Engine.Engine.Animations
{
    public class Animation
    {

        public List<Sprite> AnimationFrames = new();

        public int TicksPerFrame { get; set; } = 3;

        public int CurrentFrame { get; set; } = 0;

        public bool loop = true;

        public Animation(List<Sprite> animationFrames, int tpf)
        {
            AnimationFrames = animationFrames;
            TicksPerFrame = tpf;
        }

        public Sprite? GetNextFrame()
        {
            if (AnimationFrames.Count == 0)
                return null;
            if (CurrentFrame >= AnimationFrames.Count)
            {
                if (loop)
                    CurrentFrame = 0;
                else
                    return null;
            }
            var frame = AnimationFrames[CurrentFrame];
            CurrentFrame++;
            return frame;
        }

    }
}
