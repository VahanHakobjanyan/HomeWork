namespace Task18
{
    internal class Program
    {
        //Task18: Flags for UI Elements
        static void Main(string[] args)
        {
            UiElements elements = new UiElements();

            //Making all elements visible
            elements = UiElements.Button | UiElements.TextBox | UiElements.CheckBox;
            Console.WriteLine(elements);

            //Hiding textBox
            elements ^= UiElements.TextBox;
            Console.WriteLine(elements);

            //checking if CheckBox is visible
            Console.WriteLine((elements &= UiElements.CheckBox) == UiElements.CheckBox);
            Console.WriteLine(elements);

            //Adding textBox
            elements |= UiElements.TextBox;
            Console.WriteLine(elements);

            Console.ReadKey();
        }
    }

    [Flags]
    enum UiElements
    {
        Button = 1,
        TextBox = 2,
        CheckBox = 4,
    }
}
