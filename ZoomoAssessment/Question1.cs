namespace ZoomoAssessment
{
    public static class Question1
    {
        /// <summary>
        /// Check if a string is null or empty.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the string is null or empty, false otherwise.</returns>
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
