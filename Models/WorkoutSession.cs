using System;
using SQLite;

public class WorkoutSession
{
    [PrimaryKey, AutoIncrement]
    public int SessionId { get; set; }
    [Indexed]
    public int WorkoutId { get; set; }
    public double Length { get; set; }
    public DateTime? StartDate { get; set; }
    [Indexed]
    public string? NoteId { get; set; }
    public bool Finished { get; set; }

    public WorkoutSession(int sessionid, int workoutId, double length, DateTime? startDate, string note, bool finished)
    {
        SessionId = sessionid;
        WorkoutId = workoutId;
        Length = length;
        StartDate = startDate;
        NoteId = note;
        Finished = finished;
    }
}