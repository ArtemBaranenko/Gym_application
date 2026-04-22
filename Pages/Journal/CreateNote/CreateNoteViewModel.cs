using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;

public class CreateNoteViewModel : INotifyPropertyChanged
{
    private string? _noteText;
    public string? NoteText
    {
        get => _noteText;
        set
        {
            _noteText = value;
            OnPropertyChanged();
        }
    }
    private string? _noteTitle;
    public string? NoteTitle
    {
        get => _noteTitle;
        set
        {
            _noteTitle = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<Notes> Notes { get; set; } = new();
    public ICommand SaveCommand { get; }

    public CreateNoteViewModel()
    {
        SaveCommand = new Command(async () => await SaveNoteAsync());
    }

    private async Task SaveNoteAsync()
    {
        Notes note = new Notes
        {
            Title = NoteTitle,
            Note = NoteText,
            NoteDate = DateTime.Now
        };

        await App.DatabaseService.SaveAsync(note);

        NoteTitle = string.Empty;
        NoteText = string.Empty;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}