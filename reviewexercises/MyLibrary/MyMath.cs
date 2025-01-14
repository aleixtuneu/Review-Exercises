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

        public static double CelsiusToKelvin(double celsiusInput)
        {
            return celsiusInput + 273.15;
        }

        public static double KelvinToFahrenheit(double kelvinInput)
        {
            return (kelvinInput - 273.15) * 9 / 5 + 32;
        }

        public static double CalculateDiscount(double priceInput, double discountedPriceInput)
        {
            return ((priceInput - discountedPriceInput) / priceInput) * 100;
        }

        public static string DecimalToHexadecimal(int decimalNumberInput)
        {
            string hexadecimalChars = "";

            if (decimalNumberInput == 0)
            {
                return "";
            }

            return DecimalToHexadecimal(decimalNumberInput / 16) + hexadecimalChars[decimalNumberInput % 16];
        }

    }
}
