public class WorkoutService
{
    // private List<WorkoutExercise> workoutExercises = new List<WorkoutExercise>();

    public List<WorkoutTemplate> Workouts = new List<WorkoutTemplate>();
    public List<WorkoutSession> WorkoutSession = new List<WorkoutSession>();

    public WorkoutService()
    {
        Workouts.Add(new WorkoutTemplate(1,
        "Test Workout",
        new List<TemplateExercise>
        {
            new TemplateExercise { ExerciseName = "Exercise1", Sets = 3, Reps = 12, TargetWeight = 25 },
            new TemplateExercise { ExerciseName = "Exercise2", Sets = 4, Reps = 8, TargetWeight = 15 },
            new TemplateExercise { ExerciseName = "Exercise3", Sets = 3, Reps = 10, TargetWeight = 35 },
            new TemplateExercise { ExerciseName = "Exercise4", Sets = 3, Reps = 8, TargetWeight = 20 }
        },
        "Weightlifting"));
    }

    public void CreateWorkout(WorkoutTemplate workoutId)
    {

    }
    public void StartWorkout(int workoutId)
    {
        // for (int i = 0; i < Workouts.Count; i++)
        // {
        //     if (Workouts[i].IdWorkout == workoutId)
        //     {
        //         WorkoutSession.Add(new WorkoutSession(1, 1, 0.0, new DateTime(2022, 5, 10), "Note", false));

        //         //TODO: Find out how u can display it simunteniosly and allow user to enter the note whenever he want
        //         new WorkoutExercise
        //         {
        //             Exercise = Workouts[i].Exercises,
        //             Note = "Note"
        //         };

        //     }
        // }


    }

    public void FinishWorkout(WorkoutSession workoutSession)
    {

    }

    public void PreviousWorkouts()
    {
        //return workouts
    }

    public void DisplayCurentExercise(WorkoutExercise workoutExercise)
    {

    }

    // public List<WorkoutExercise> SwitchExercise()
    // {
    //     return workoutExercises;
    // }

    public List<WorkoutTemplate> ShowWorkout()
    {
        return Workouts;
    }

}