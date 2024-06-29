namespace BlazorApp.Model;

public class Partition {
    public Partition(int index)
    {
        Index = index;
        Messages = new List<Message>();
    }

    public int Index { get; set; }

    public List<Message> Messages { get; set; }

}