namespace Task2
{
    internal class Program
    {
        //Task2: Language Translation Enum
        static void Main(string[] args)
        {
            Languages language = Languages.Spanish;
            string translatedHello = TranslateHello(language);
            Console.WriteLine(translatedHello);
            Console.WriteLine("-----------------------------------");
        }

        static string TranslateHello(Languages language)
        {
            switch (language)
            {
                case Languages.English:
                    return "Hello";
                case Languages.French:
                    return "Bonjour";
                case Languages.Spanish:
                    return "Hola";
                default:
                    return "INVALID LANGUAGE";
            }
        }
    }

    public enum Languages
    {
        English,
        Spanish,
        French
    }
}
