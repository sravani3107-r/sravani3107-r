public class Todo
{
    public int Id { get; set; }
    public string? Question { get; set; }
    public string? Correctanswer { get; set; }
    public string? A1 { get; set; }
    public string? B1 { get; set; }
    //public List<string>? IncorrectAnswers { get; set; }
    public bool IsComplete { get; set; }
}