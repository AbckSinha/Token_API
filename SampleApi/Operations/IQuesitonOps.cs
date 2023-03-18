using SampleApi.Model;

namespace SampleApi.Operations;

public interface IQuestionOps{
    public QuestionResponse getQuestion(QuestionRequest questionRequest);
}