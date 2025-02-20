class TextEditor
{
    private string _content = "";

    public void Type(string words, History history)
    {
        history.SaveState(this); 
        _content += words + " ";
    }

    public string GetContent()
    {
        return _content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)
    {
        _content = memento.Content;
    }
}