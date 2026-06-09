namespace gym_assistant;

public class NavigationService : INavigationService
{
    public async Task GoToAsync(string route)
    {
        await Shell.Current.GoToAsync(route);
    }
    public async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
    public async Task OpenNoteDetailsAsync(Notes note)
    {
        await Shell.Current.Navigation.PushAsync(new NoteDetailsPage(note));
    }
    public async Task OpenWorkoutDetailsAsync(WorkoutPrograms workoutPrograms)
    {
        await Shell.Current.Navigation.PushAsync(new WorkoutDetailsPage(workoutPrograms));
    }
}