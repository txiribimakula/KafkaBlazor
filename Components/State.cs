namespace BlazorApp;

public class State
{
    public static string[] ExistingTopics = new string[] { "topic.pruebas.con.1.particion", "topic.pruebas.con.3.particiones" };

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

    public void AddPartition(int index) {
        partitions.Add(new Model.Partition(index));
        StateHasChanged();
    }

    public void AddMessage(int partitionIndex, Model.Message message) {
        partitions[partitionIndex].Messages.Add(message);
        StateHasChanged();
    }

    public void Clear() {
        partitions.Clear();
        StateHasChanged();
    }
}
