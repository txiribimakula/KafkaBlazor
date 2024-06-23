namespace BlazorApp;

public class State
{
    public State()
    {
        Partitions = new List<Model.Partition>();
    }

    public List<Model.Partition> Partitions { get; set; }
}
