using SQLite;

public class Notes
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Note { get; set; }
    public DateTime? NoteDate { get; set; }
    public string? Type { get; set; }
}