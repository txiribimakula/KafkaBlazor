namespace BlazorApp.Model;

public class Message {
    public Message(string key, string value, Guid id)
    {
        Id = id;

        Key = key;
        Value = value;

        CommittedBy = new HashSet<string>();
    }

    public string Key { get; set; }

    public string Value { get; set; }


    public Guid Id { get; set; }
    public int Offset { get; set; } = -1;

    public HashSet<string> CommittedBy { get; set; }
}