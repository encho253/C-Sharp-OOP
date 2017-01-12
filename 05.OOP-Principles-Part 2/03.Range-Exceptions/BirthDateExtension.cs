namespace _03.Range_Exceptions
{
    using System;
    using System.Globalization;

    public static class BirthDateExtension
    {
        public static DateTime ConvertStringToDate(this string text)
        {
            string stringFormat = "MM.dd.yyyy";
            DateTime birthDate = DateTime.ParseExact(text, stringFormat, CultureInfo.InvariantCulture);

            return birthDate;
        }
    }
}