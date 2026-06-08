using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class WorkoutSession
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [Indexed]
    public int WorkoutId { get; set; }

    [Indexed]
    public int ExerciseId { get; set; }
    public string? Sets { get; set; }
    public string? Reps { get; set; }
    public string? Weight { get; set; }
    public int Order { get; set; }
}