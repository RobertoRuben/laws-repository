namespace BusinessLayer.Utilities
{
    public static class TextTransformer
    {
        // Método para transformar el texto a formato título (Title Case)
        public static string TransformToTitleCase(string text)
        {
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1).ToLower();
                }
            }
            string result = string.Join(" ", words);
            return result;
        }
        // Método para capitalizar solo la primera letra del texto completo
        public static string CapitalizeFirstLetter(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return text[0].ToString().ToUpper() + text.Substring(1);
            }
            return text;
        } 
    }
}