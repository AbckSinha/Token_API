namespace SampleApi.Model;

public class QuestionRequest{
    public int Id { get; set; }

}
public class QuestionResponse{
    public string? Description { get; set; }
    public string? Answer { get; set; }
}