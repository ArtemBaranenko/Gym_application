using System;

public class WorkoutSession
{
    public int Id { get; set; }
    public int WorkoutId { get; set; }
    public double Length { get; set; }
    public DateTime? StartDate { get; set; }
    public string? Note { get; set; }
    public bool Finished { get; set; }

    public WorkoutSession(int id, int workoutId, double length, DateTime? startDate, string note, bool finished)
    {
        Id = id;
        WorkoutId = workoutId;
        Length = length;
        StartDate = startDate;
        Note = note;
        Finished = finished;
    }
}