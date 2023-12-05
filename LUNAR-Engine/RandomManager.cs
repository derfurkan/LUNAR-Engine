namespace LUNAR_Engine
{
    public static class RandomManager
    {

        public static Random Random = new Random();

        public static int GetRandomInt(int min, int max)
        {
            return Random.Next(min, max);
        }

        public static double GetRandomDouble(double min, double max)
        {
            return Random.NextDouble() * (max - min) + min;
        }

    }
}
