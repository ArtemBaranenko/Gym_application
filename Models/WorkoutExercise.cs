public class WorkoutExercise
{
    public int ExerciseOrder { get; set; }
    public List<TemplateExercise> Exercise { get; set; } = new();
    public string? Note { get; set; }


}