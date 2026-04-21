using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class WorkoutExercises
{
    [PrimaryKey, AutoIncrement]
    public int ExerciseId { get; set; }
    [Indexed]
    public int WorkoutId { get; set; }
    public string? ExerciseName { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    [Indexed]
    public int NoteId { get; set; }
    public int Order { get; set; }
}
