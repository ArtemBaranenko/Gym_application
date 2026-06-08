namespace gym_assistant;

public partial class CreateWorkoutPage : ContentPage
{
    private readonly CreateWorkoutViewModel _createWorkoutModel;

    public CreateWorkoutPage()
    {
        InitializeComponent();

        _createWorkoutModel = new CreateWorkoutViewModel(new NavigationService(), new ExerciseAPIService());

        BindingContext = _createWorkoutModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        _createWorkoutModel.IsDropDownVisible = false;
    }
};