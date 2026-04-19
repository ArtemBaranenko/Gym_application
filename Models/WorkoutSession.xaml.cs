public class WorkoutSession
{
    public int Id { get; set; }
    public string? WorkoutId { get; set; }
    public int Length { get; set; }
    public DateTime Date { get; set; }
    public string? Note { get; set; }
    public bool Finished { get; set; }
}