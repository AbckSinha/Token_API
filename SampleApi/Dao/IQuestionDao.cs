namespace SampleApi.Dao;

public interface IQuestionDao{
    public GetQuestionDbResponse getQuestion(GetQuestionDbRequest getQuestionDbRequest);
}