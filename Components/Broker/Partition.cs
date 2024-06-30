using System.Collections.Specialized;

namespace BlazorApp.Model;

public class Partition {
    public Partition(int index)
    {
        Index = index;
        Messages = new Dictionary<Guid, Message>();
    }

    public int Index { get; set; }

    public Dictionary<Guid, Message> Messages { get; set; }

    public void AddMessage(Message message)
    {
        Messages.Add(message.Id, message);
    }
}