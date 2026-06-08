using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class WorkoutExercises
{
    [PrimaryKey, AutoIncrement]
    public int ExerciseId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Difficulty { get; set; }
    public string? Instructions { get; set; }
    public string? Equipments { get; set; }
    public string? Safety_info { get; set; }
}
