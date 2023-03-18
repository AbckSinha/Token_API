using SampleApi.Dao;
using SampleApi.Model;
using SampleApi.ObjectMapper;

namespace SampleApi.Operations;

public class QuestionOps : IQuestionOps
{
    private readonly IQuestionDao questionDao;
    private readonly IQuestionObjectMapper questionObjectMapper;

    public QuestionOps(IQuestionDao questionDao, IQuestionObjectMapper questionObjectMapper)
    {
        this.questionDao = questionDao;
        this.questionObjectMapper = questionObjectMapper;
    }
    public QuestionResponse getQuestion(QuestionRequest questionRequest)
    {
        GetQuestionDbRequest getQuestionDbRequest = this.questionObjectMapper.createGetQuestionDbRequest(questionRequest);
        GetQuestionDbResponse getQuestionDbResponse = this.questionDao.getQuestion(getQuestionDbRequest);
        QuestionResponse questionResponse = this.questionObjectMapper.createQuestionResponse(getQuestionDbResponse);
        return questionResponse;
    }
}