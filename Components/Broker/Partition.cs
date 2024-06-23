namespace BlazorApp.Model;

public class Partition {
    public Partition()
    {
        Messages = new List<Message>() {
            new Message(),
            new Message()
        };
    }

    public List<Message> Messages { get; set; }

}