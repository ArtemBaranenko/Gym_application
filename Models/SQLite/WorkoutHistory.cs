using SQLite;

public class WorkoutHistory
{
    [PrimaryKey, AutoIncrement]
    public int SessionId { get; set; }
    [Indexed]
    public int WorkoutId { get; set; }
    public double Length { get; set; }
    public DateTime? StartDate { get; set; }
    [Indexed]
    public string? NoteId { get; set; }
    public bool Finished { get; set; }
}