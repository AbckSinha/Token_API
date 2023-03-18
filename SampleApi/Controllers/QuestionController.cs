using Microsoft.AspNetCore.Mvc;
using SampleApi.Model;
using SampleApi.Operations;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly IQuestionOps questionOps;
    private readonly ILogger<QuestionController> logger;
    public QuestionController(IQuestionOps questionOps, ILogger<QuestionController> logger)
    {
        this.questionOps = questionOps;
        this.logger = logger;
    }

    [HttpPost(Name = "GetQuestion")]
    public ActionResult<QuestionResponse> GetQuestion([FromBody]QuestionRequest questionRequest)
    {
        return StatusCode(200,this.questionOps.getQuestion(questionRequest));
    }
}
