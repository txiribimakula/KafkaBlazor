namespace BlazorApp;

public class State
{
    public static string[] ExistingTopics = new string[] { "topic.pruebas.con.1.particion", "topic.pruebas.con.3.particiones" };

    private bool isBrokerReady = false;
    public bool IsBrokerReady
    {
        get => isBrokerReady;
        set
        {
            isBrokerReady = value;
            StateHasChanged();
        }
    }
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
        message.Offset = partitions[partitionIndex].Messages.Count;
        partitions[partitionIndex].AddMessage(message);
        StateHasChanged();
    }

    public void Commit(int partitionIndex, Guid messageId, string groupId)
    {
        partitions[partitionIndex].Messages.TryGetValue(messageId, out var message);
        var index = partitions[partitionIndex].Messages.Values.ToList().IndexOf(message);
        if(index > 0)
        {
            partitions[partitionIndex].Messages.Values.ToList()[index - 1].CommittedBy.Remove(groupId);
        }
        message.CommittedBy.Add(groupId);
        StateHasChanged();
    }

    public void Clear() {
        partitions.Clear();
        StateHasChanged();
    }
}
