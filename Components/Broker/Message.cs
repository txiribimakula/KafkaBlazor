namespace BlazorApp.Model;

public class Message {
    public Message(string key, string value, Guid id, int duration)
    {
        Id = id;

        Key = key;
        Value = value;

        CommittedBy = new HashSet<string>();

        Duration = duration;
    }

    public string Key { get; set; }

    public string Value { get; set; }


    public Guid Id { get; set; }
    public int Offset { get; set; } = -1;

    public HashSet<string> CommittedBy { get; set; }

    public int Duration { get; set; }
}