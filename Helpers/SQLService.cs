using SQLite;

// public class SQLService<T>
public class SQLService
{
    SQLiteAsyncConnection _database;
    public SQLService(string databasePath)
    {
        _database = new SQLiteAsyncConnection(databasePath);

    }

    public async Task InitAsync()
    {
        await _database.CreateTableAsync<Notes>();
        await _database.CreateTableAsync<WorkoutPrograms>();
        await _database.CreateTableAsync<WorkoutExercises>();

    }

    public async Task<List<Notes>> GetNotesAsync()
    {
        return await _database.Table<Notes>().ToListAsync();
    }

    public async Task DeleteNoteAsync(Notes note)
    {
        await _database.DeleteAsync(note);
    }

    public async Task<int> SaveAsync(Notes notes)
    {
        if (notes.Id != 0)
        {
            return await _database.UpdateAsync(notes);
        }
        else
        {
            return await _database.InsertAsync(notes);
        }
    }

    public async Task<List<WorkoutPrograms>> GetWorkoutProgramsAsync()
    {
        return await _database.Table<WorkoutPrograms>().ToListAsync();
    }

    public async Task<int> SaveWorkoutProgramsAsync(WorkoutPrograms workoutPrograms)
    {
        if (workoutPrograms.WorkoutId != 0)
        {
            return await _database.UpdateAsync(workoutPrograms);
        }
        else
        {
            return await _database.InsertAsync(workoutPrograms);
        }
    }

    public async Task<int> SaveWorkoutExercisesAsync(WorkoutExercises workoutExercises)
    {
        if (workoutExercises.ExerciseId != 0)
        {
            return await _database.UpdateAsync(workoutExercises);
        }
        else
        {
            return await _database.InsertAsync(workoutExercises);
        }
    }

    //TODO: Add delete function
    // public async Task<int> DeleteNoteAsync(Journal journal)
    // {

    // }
}
