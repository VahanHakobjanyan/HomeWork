namespace Task3
{
    internal class Program
    {
        //Task3: Custom Enum Properties
        static void Main(string[] args)
        {
            Languages language = Languages.Spanish;
            string translatedHello = TranslateHello(language);

            string isoName = GetIsoName(language);
            string isoCode = GetIsoCode(language);

            Console.WriteLine($"Language - {language}, Code - {isoCode}, Official name - {isoName}, word example - {translatedHello}");

            Console.ReadKey();
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

        static string GetIsoName(Languages language)
        {
            switch (language)
            {
                case Languages.English:
                    return "English";
                case Languages.Spanish:
                    return "Spanish";
                case Languages.French:
                    return "French";
                default:
                    return "INVALID LANGUAGE";
            }
        }
        static string GetIsoCode(Languages language)
        {
            //return ISO code !!(only set 1)!!
            switch (language)
            {
                case Languages.English:
                    return "en";
                case Languages.French:
                    return "fr";
                case Languages.Spanish:
                    return "es";
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
