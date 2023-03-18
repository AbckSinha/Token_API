using SampleApi.Dao;
using SampleApi.Model;

namespace SampleApi.ObjectMapper;

public class QuestionObjectMapper : IQuestionObjectMapper
{
    public GetQuestionDbRequest createGetQuestionDbRequest(QuestionRequest questionRequest)
    {
        throw new NotImplementedException();
    }

    public QuestionResponse createQuestionResponse(GetQuestionDbResponse getQuestionDbResponse)
    {
        throw new NotImplementedException();
    }
}