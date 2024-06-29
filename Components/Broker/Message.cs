namespace BlazorApp.Model;

public class Message {
    public Message(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; set; }

    public string Value { get; set; }
}