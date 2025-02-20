class History
{
    private Stack<EditorMemento> _undoStack = new Stack<EditorMemento>();
    private Stack<EditorMemento> _redoStack = new Stack<EditorMemento>();

    public void SaveState(TextEditor editor)
    {
        _undoStack.Push(editor.Save());
        _redoStack.Clear(); 
    }

    public void Undo(TextEditor editor)
    {
        if (_undoStack.Count > 0)
        {
            _redoStack.Push(editor.Save()); 
            editor.Restore(_undoStack.Pop());
        }
    }

    public void Redo(TextEditor editor)
    {
        if (_redoStack.Count > 0)
        {
            _undoStack.Push(editor.Save()); 
            editor.Restore(_redoStack.Pop());
        }
    }
}