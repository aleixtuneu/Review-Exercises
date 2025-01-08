namespace MyLibrary
{
    public static class MyMath
    {
        public static string SecondsToHoursAndMinutes(int secondsInput)
        {
            int hours = secondsInput / 3600;
            int minutes = (secondsInput % 3600)/60;
            int seconds = secondsInput % 60;

            return $"{hours} hores, {minutes} minuts, {seconds} segons.";
        }
    }
}
