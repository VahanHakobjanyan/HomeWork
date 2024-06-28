namespace Task9
{
    internal class Program
    {
        //Task9: File Extensions Enum:
        static void Main(string[] args)
        {
            FileExtensions file = FileExtensions.txt;
            Console.WriteLine("Upload any text file for translation");
            if (file.Equals(FileExtensions.txt) || file.Equals(FileExtensions.pdf))
            {
                Console.WriteLine("Your translation will be ready soon");
            }
            else
            {
                Console.WriteLine("Unsupported file format");
            }

            Console.ReadKey();
        }
    }

    enum FileExtensions
    {
        txt,
        pdf,
        jpg,
        mp3,
        mp4
    }
}
