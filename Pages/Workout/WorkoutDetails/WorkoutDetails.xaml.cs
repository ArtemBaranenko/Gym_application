namespace gym_assistant;

public partial class WorkoutDetailsPage : ContentPage
{
    public WorkoutDetailsPage(WorkoutPrograms selectedWorkout)
    {
        InitializeComponent();
        BindingContext = new WorkoutDetailsViewModel(selectedWorkout);
    }
}