using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class WorkoutExercises
{
    [PrimaryKey, AutoIncrement]
    public int ExerciseId { get; set; }
    [Indexed]
    public string? WorkoutTitle { get; set; }
    public string? Exercise { get; set; }
    public string? Sets { get; set; }
    public string? Reps { get; set; }
    [Indexed]
    public int NoteId { get; set; }
    public int Order { get; set; }
}
