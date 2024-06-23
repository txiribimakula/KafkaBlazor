namespace BlazorApp.Model;

public class Partition {
    public Partition()
    {
        Messages = new List<Message>() {
            new Message("content 1"),
            new Message("content 2")
        };
    }

    public List<Message> Messages { get; set; }

}