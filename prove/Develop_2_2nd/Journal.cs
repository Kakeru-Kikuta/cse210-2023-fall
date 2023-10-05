using system;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public PromptGenerator prompt = new PromptGenerator();
    public void Write()
    {
        string p = prompt.GetPrompt();
        Console.WriteLine(p);
        Entry.prompt = p;
        entries.Add(Entry);
    }

    public void Display()
    {

    }

    public void Save()
    {

    }

    public void Load()
    {

    }

    
}