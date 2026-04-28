using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class WorkoutPrograms
{
    [PrimaryKey, AutoIncrement]
    public int WorkoutId { get; set; }
    public string? WorkoutName { get; set; }
    public string? WorkoutType { get; set; }
    public string? WarmUp { get; set; }
    public string? CoolDown { get; set; }
    public string? RestBetweenSets { get; set; }
}