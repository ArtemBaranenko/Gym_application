namespace gym_assistant;

public partial class WorkoutPage : ContentPage
{
    private readonly WorkoutViewModel __workoutModel;

    public WorkoutPage()
    {
        InitializeComponent();

        __workoutModel = new WorkoutViewModel(new NavigationService());
        BindingContext = __workoutModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await App.DatabaseService.InitAsync();
        await __workoutModel.UpdateWorkouts();
    }

    // private async void OnExerciseModeClicked(object? sender, EventArgs e)
    // {
    //     await Navigation.PushModalAsync(new ExerciseModePage());
    // }
    // private void OnShowWorkoutClicked(object? sender, EventArgs e)
    // {
    //     WorkoutPreview.ItemsSource = null;
    //     WorkoutPreview.ItemsSource = _workoutService.ShowWorkout();
    // }
}