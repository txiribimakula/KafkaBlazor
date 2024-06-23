namespace BlazorApp;

public class State
{
    public State()
    {
        partitions = new List<Model.Partition>();
    }

    private List<Model.Partition> partitions;

    public IEnumerable<Model.Partition> Partitions => partitions;

    public void AddPartition() {
        partitions.Add(new Model.Partition());
    }

    public void AddMessage(int partitionIndex) {
        partitions[partitionIndex].Messages.Add(new Model.Message("new content"));
    }
}
