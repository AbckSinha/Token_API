using SampleApi.Dao;
using SampleApi.Model;

namespace SampleApi.ObjectMapper;

public interface IQuestionObjectMapper{
    public GetQuestionDbRequest createGetQuestionDbRequest(QuestionRequest questionRequest);
    public QuestionResponse createQuestionResponse(GetQuestionDbResponse getQuestionDbResponse);
}