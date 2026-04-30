using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;

// TODO: Create Note service?

public class NoteDeatailsViewModel : INotifyPropertyChanged
{
    public Notes SelectedNote { get; set; }
    public ICommand SaveCommand { get; }
    public ICommand DeleteCommand { get; }

    public NoteDeatailsViewModel(Notes note)
    {
        SelectedNote = note;

        SaveCommand = new Command(async () => await SaveAsync());
        DeleteCommand = new Command(async () => await DeleteAsync());
    }

    private async Task SaveAsync()
    {
        await App.DatabaseService.SaveAsync(SelectedNote);
    }

    private async Task DeleteAsync()
    {
        await App.DatabaseService.DeleteNoteAsync(SelectedNote);
        await Shell.Current.Navigation.PopAsync();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}