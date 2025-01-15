namespace MyLibrary
{
    public static class MyMath
    {
        public static bool IsSorted(int[] arrayInput)
        {
            for (int i = 0; i < arrayInput.Length - 1; i++)
            {
                if (arrayInput[i] > arrayInput[i+1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
