using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;


public class WorkoutDetailsViewModel : INotifyPropertyChanged
{
    public WorkoutPrograms SelectedWorkout { get; set; }
    public ICommand SaveCommand { get; }
    public ICommand DeleteCommand { get; }

    public WorkoutDetailsViewModel(WorkoutPrograms workoutPrograms)
    {
        SelectedWorkout = workoutPrograms;

        SaveCommand = new Command(async () => await SaveAsync());
        DeleteCommand = new Command(async () => await DeleteAsync());
    }

    private async Task SaveAsync()
    {
        await App.DatabaseService.SaveworkoutProgramAsync(SelectedWorkout);
    }

    private async Task DeleteAsync()
    {
        await App.DatabaseService.DeleteWorkoutProgramAsync(SelectedWorkout);
        await Shell.Current.Navigation.PopAsync();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}