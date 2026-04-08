namespace gym_assistant;

public partial class CreateWorkoutPage : ContentPage
{
    public CreateWorkoutPage()
    {
        InitializeComponent();
        // BindingContext = new Model();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//WorkoutPage");
    }
};