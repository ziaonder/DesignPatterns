public class CopyCommand : ICommand
{
    private readonly TextEditor _editor;

    public CopyCommand(TextEditor editor)
    {
        _editor = editor;
    }

    public void Execute()
    {
        _editor.CopyText();
    }
}