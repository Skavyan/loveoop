namespace ObjectOrientedPractics1.Services
{
    public static class IdGenerator
    {
        private static int _currentId = 0;

        public static int GetNextId()
        {
            return ++_currentId;
        }
    }
}