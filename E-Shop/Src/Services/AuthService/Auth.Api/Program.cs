using Auth.Application.Handlers.Commands.User;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//                                                                  Configure services 

builder.Services.AddControllers();

builder.Services.AddMediatR(typeof(UserHandler).GetTypeInfo().Assembly);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//                                                                 HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
