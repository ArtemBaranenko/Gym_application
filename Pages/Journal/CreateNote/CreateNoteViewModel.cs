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

    public ObservableCollection<Notes> Notes { get; set; } = new();
    public ICommand SaveCommand { get; }
    public ICommand RefreshCommand { get; }

    public CreateNoteViewModel()
    {
        SaveCommand = new Command(async () => await SaveNoteAsync());

        RefreshCommand = new Command(async () => await UpdateNotes());
    }

    private async Task SaveNoteAsync()
    {
        Notes note = new Notes
        {
            Note = NoteText,
            NoteDate = DateTime.Now
        };

        await App.DatabaseService.SaveAsync(note);

        UpdateNotes();
        NoteText = string.Empty;
    }
    private async Task UpdateNotes()
    {
        var notesUpdated = await App.DatabaseService.GetNotesAsync();

        Notes.Clear();

        foreach (var note in notesUpdated)
        {
            Notes.Add(note);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }




    // private async void onRefreshClicked(object sender, EventArgs e)
    // {
    //     await UpdateNotes();
    // }


    // private void onSave()
    // {
    //     await SaveNote();
    // }



}