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

        public static bool ValidatePostalCode(string postalCodeInput)
        {
            // Comprovar si la longitud és 5
            if (postalCodeInput.Length != 5)
            {
                return false;
            }

            // Comprovar si té dígits numèrics
            foreach (char c in postalCodeInput)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static double CalculateTip(double priceInput, int peopleCountInput)
        {
            return (priceInput * 20 / 100) / peopleCountInput;
        }

    }
}
