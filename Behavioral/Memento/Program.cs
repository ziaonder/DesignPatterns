namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            History history = new History();

            editor.Type("Hello", history);
            editor.Type("World!", history);

            Console.WriteLine("Current Content: " + editor.GetContent());

            history.Undo(editor);
            Console.WriteLine("After Undo: " + editor.GetContent());

            history.Redo(editor);
            Console.WriteLine("After Redo: " + editor.GetContent());
        }
    }
}
