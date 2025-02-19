public class TextEditor
{
    private string _clipboard;

    public void CopyText()
    {
        _clipboard = "Some text to be copied";  
        Console.WriteLine("Text copied to clipboard: " + _clipboard);
    }

    public void PasteText()
    {
        if (string.IsNullOrEmpty(_clipboard))
        {
            Console.WriteLine("No text to paste.");
        }
        else
        {
            Console.WriteLine("Pasting text: " + _clipboard);
        }
    }
}
