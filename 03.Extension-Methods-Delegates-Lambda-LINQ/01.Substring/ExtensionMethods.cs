namespace Substring
{
    using System.Text;
    using System;

    public static class ExtensionMethods
    {
        public static StringBuilder SubstringMethod(this string text,int index,int lenght = 0)
        {
            var builder = new StringBuilder();
            
            if ((index < 0 || lenght < 0) || (lenght > text.Length || index > text.Length))
            {
                throw new IndexOutOfRangeException();
            }
            if (lenght == 0)
            {
                lenght = text.Length;
            }

            for (int i = index; i < lenght; i++)
            {
                builder.Append(text[i]);
            }

            return new StringBuilder(builder.ToString());
        }
    }
}
