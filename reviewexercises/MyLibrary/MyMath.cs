namespace MyLibrary
{
    public static class MyMath
    {
        public static float CalculateTriangleArea(float baseInput, float heightInput)
        {
            return baseInput * heightInput / 2;
        }

        public static double CelsiusToFahrenheit(double celsiusInput)
        {
            return (celsiusInput * 9 / 5) + 32;
        }

    }
}
