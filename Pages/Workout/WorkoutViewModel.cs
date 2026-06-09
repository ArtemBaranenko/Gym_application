using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;

public class WorkoutViewModel : INotifyPropertyChanged
{

    private readonly INavigationService _navigation;
    public ObservableCollection<WorkoutHistory> WorkoutHistory { get; set; } = new();
    public ObservableCollection<WorkoutPrograms> WorkoutPrograms { get; set; } = new();

    public ICommand OpenWorkoutCommand { get; }
    public ICommand OpenCreateWorkoutCommand { get; }

    public WorkoutViewModel(INavigationService navigation)
    {
        _navigation = navigation;

        OpenWorkoutCommand = new Command<WorkoutPrograms>(async (selectedWorkout) =>
        {
            if (selectedWorkout == null)
                return;
            await _navigation.OpenWorkoutDetailsAsync(selectedWorkout);
        });

        OpenCreateWorkoutCommand = new Command(async () => await _navigation.GoToAsync(nameof(CreateWorkoutPage)));
    }

    public async Task UpdateWorkouts()
    {
        var workoutsUpdated = await App.DatabaseService.GetWorkoutSessionsAsync();

        WorkoutPrograms.Clear();

        for (int i = workoutsUpdated.Count - 1; i >= 0; i--)
        {
            var workoutProgram = workoutsUpdated[i];
            WorkoutPrograms.Add(workoutProgram);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? properyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
    }

    // private async void OnCreateWorkoutClicked(object? sender, EventArgs e)
    // {
    //     await Navigation.PushModalAsync(new CreateWorkoutPage());
    // }
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
