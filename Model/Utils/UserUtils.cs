namespace ZooProject.Model.Utils
{
    public static class UserUtils
    {
        private static Random s_Random = new Random();

        public static int Next(int minValue, int maxValue)
        {
            return s_Random.Next(minValue, maxValue);
        }
    }
}
