namespace gym_assistant;

public partial class ExerciseModePage : ContentPage
{
    public ExerciseModePage()
    {
        InitializeComponent();
        // BindingContext = new Model();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//WorkoutPage");
    }
};