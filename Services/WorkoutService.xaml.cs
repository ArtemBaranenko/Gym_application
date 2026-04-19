public class WorkoutService
{
    private List<WorkoutExercise> workoutExercises = new List<WorkoutExercise>();

    public void CreateWorkout(WorkoutTemplate workoutTemplate)
    {

    }
    public void StartWorkout(WorkoutSession workoutSession)
    {

        int id = 1;
        string workoutName = "Default";
        float length = 0.0;
        DateTime date = DateTime.Now;
        string note = "Note";
        bool finished = false;

        var workoutSession = new WorkoutSession
        {
            Id = id,
            WorkoutName = workoutName,
            Length = length,
            Date = date,
            Note = note,
            Finished = finished
        };

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

    public List<WorkoutExercise> SwitchExercise()
    {
        return workoutExercises;
    }


}