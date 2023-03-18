using System.Text.Json;

namespace SampleApi.Dao;

public class QuestionDao : IQuestionDao
{
    private readonly IBaseDao baseDao;

    public QuestionDao(IBaseDao baseDao)
    {
        this.baseDao = baseDao;
    }
    public GetQuestionDbResponse getQuestion(GetQuestionDbRequest getQuestionDbRequest)
    {
        GetQuestionDbResponse getQuestionDbResponse =(GetQuestionDbResponse) this.baseDao.queryDb(JsonSerializer.Serialize(getQuestion));
        return getQuestionDbResponse;
    }
}
public class GetQuestionDbRequest{
    public int Id { get; set; }
}
public class GetQuestionDbResponse{
    public string? Description { get; set; }
    public string? Answer { get; set; }
}