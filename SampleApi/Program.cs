using SampleApi.Dao;
using SampleApi.ObjectMapper;
using SampleApi.Operations;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection
builder.Services.AddSingleton<IQuestionOps,QuestionOps>();
builder.Services.AddSingleton<IQuestionObjectMapper,QuestionObjectMapper>();
builder.Services.AddSingleton<IQuestionDao,QuestionDao>();
builder.Services.AddSingleton<IBaseDao,BaseDao>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
