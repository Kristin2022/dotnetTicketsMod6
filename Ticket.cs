
public class Ticket
{
    public string Id, Summary, Status, Priority, Subitter, Assigned, Watching;
    private string Submitter;

    public Ticket (string id, string summary, string status, string priority, string submitter, string assigned, string watching)
    {
        Id = id;
        Summary = summary;
        Status = status;
        Priority = priority;
        Submitter = submitter;
        Assigned = assigned;
        Watching = watching; 
    }
    public override string ToString()
    {
        return $"{Id},{Summary}, {Status}, {Priority}, {Submitter}, {Assigned}, {Watching}";
    }
}
