namespace gym_assistant;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage()
    {
        InitializeComponent();
        // BindingContext = new Model();
    }

    private async void OnCreateWorkoutClicked(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CreateWorkoutPage());
    }
    private async void OnExerciseModeClicked(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ExerciseModePage());
    }
};