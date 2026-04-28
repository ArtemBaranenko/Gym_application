using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace gym_assistant;

public class JournalViewModel : INotifyPropertyChanged
{
    private readonly INavigationService _navigation;
    public ObservableCollection<Notes> Notes { get; set; } = new();

    public ICommand OpenCreateNoteCommand { get; }
    public ICommand OpenNoteCommand { get; }

    public JournalViewModel(INavigationService navigation)
    {
        _navigation = navigation;

        OpenCreateNoteCommand = new Command(async () => await _navigation.GoToAsync(nameof(CreateNotePage)));

        OpenNoteCommand = new Command<Notes>(async (selectedNote) =>
        {
            if (selectedNote == null)
                return;
            await _navigation.OpenNoteDetailsAsync(selectedNote);
        });
    }

    public async Task UpdateNotes()
    {
        var notesUpdated = await App.DatabaseService.GetNotesAsync();

        Notes.Clear();

        for (int i = notesUpdated.Count - 1; i >= 0; i--)
        {
            var notes = notesUpdated[i];
            Notes.Add(notes);
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}