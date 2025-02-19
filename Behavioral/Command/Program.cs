namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            ICommand copyCommand = new CopyCommand(editor);
            ICommand pasteCommand = new PasteCommand(editor);

            Button copyButton = new Button(copyCommand);
            Button pasteButton = new Button(pasteCommand);

            Console.WriteLine("Clicking 'Copy' button...");
            copyButton.Click();

            Console.WriteLine("\nClicking 'Paste' button...");
            pasteButton.Click();
        }
    }
}
