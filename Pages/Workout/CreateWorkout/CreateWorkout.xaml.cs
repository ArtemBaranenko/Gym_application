namespace gym_assistant;

public partial class CreateWorkoutPage : ContentPage
{
    private readonly CreateWorkoutViewModel _createWorkoutModel;

    public CreateWorkoutPage()
    {
        InitializeComponent();

        _createWorkoutModel = new CreateWorkoutViewModel(new NavigationService());
        BindingContext = _createWorkoutModel;
    }
};