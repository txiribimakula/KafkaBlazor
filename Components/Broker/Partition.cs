namespace BlazorApp.Model;

public class Partition {
    public Partition()
    {
        Messages = new List<Message>();
    }

    public List<Message> Messages { get; set; }

}