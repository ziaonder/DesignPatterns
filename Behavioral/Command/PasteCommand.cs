public class PasteCommand : ICommand
{
    private readonly TextEditor _editor;

    public PasteCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.PasteText();
    }
}