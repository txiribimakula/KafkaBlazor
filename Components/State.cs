namespace BlazorApp;

public class State
{
    public State()
    {
        partitions = new List<Model.Partition>();
    }

    private List<Model.Partition> partitions;

    public IEnumerable<Model.Partition> Partitions => partitions;
    
    public event EventHandler? StateChanged;

    private void StateHasChanged() {
        StateChanged?.Invoke(this, EventArgs.Empty);
    }


    public void AddPartition() {
        partitions.Add(new Model.Partition());
        StateHasChanged();
    }

    public void AddMessage(int partitionIndex, string message) {
        partitions[partitionIndex].Messages.Add(new Model.Message(message));
        StateHasChanged();
    }

    public void Clear() {
        partitions.Clear();
        StateHasChanged();
    }
}
