namespace BlazorApp.Model;

public class Message {
    public Message(string value)
    {
        Value = value;
    }

    public string Value { get; set; }
}