namespace ZoomoAssessment
{
    public static class Question1
    {
        public static bool isNullorEmpty(string input)
        {
            if (input == null)
            {
                return true;
            }

            if (input.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
