public class WorkoutTemplate
{
    public int IdWorkout { get; set; }
    public string? WorkoutName { get; set; }
    public List<TemplateExercise>? Exercises { get; set; }
    public string? Type { get; set; }

    public WorkoutTemplate()
    {
        IdWorkout = 0;
        WorkoutName = "Test Workout";
        Exercises = new List<TemplateExercise>
        {
            new TemplateExercise { ExerciseName = "Exercise1", Sets = 3, Reps = 12, TargetWeight = 25 },
            new TemplateExercise { ExerciseName = "Exercise2", Sets = 4, Reps = 8, TargetWeight = 15 },
            new TemplateExercise { ExerciseName = "Exercise3", Sets = 3, Reps = 10, TargetWeight = 35 },
            new TemplateExercise { ExerciseName = "Exercise4", Sets = 3, Reps = 8, TargetWeight = 20 }
        };
        Type = "Weightlifting";
    }

    public WorkoutTemplate(int idWorkout, string workoutName, List<TemplateExercise>? exercises, string type)
    {
        IdWorkout = idWorkout;
        WorkoutName = name;
        Exercises = exercises;
        Type = type;
    }

    public override string ToString()
    {
        var exercisesStr = string.Join(",", Exercises.Select(exercisesStr => e.ExerciseName));
        return $"Workout Name: {WorkoutName} | Exercises: {exercisesStr}, Type: {Type}";
    }

}

