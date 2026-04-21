using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class WorkoutPrograms
{
    [PrimaryKey, AutoIncrement]
    public int WorkoutId { get; set; }
    public string? WorkoutName { get; set; }
    public string? Type { get; set; }
}