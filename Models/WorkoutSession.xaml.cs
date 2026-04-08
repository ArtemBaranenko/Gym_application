public class WorkoutSession
{
    public int id { get; set; }
    public int Length { get; set; }
    public DateTime Date { get; set; }
    public string? Note { get; set; }
    public bool Started { get; set; }
    public bool Finished { get; set; }
}