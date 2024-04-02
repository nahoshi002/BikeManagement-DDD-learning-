using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using BikeManagement.Api.Extentions;
using BikeManagement.Api.Options;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.RegisterPipelineComponents(typeof(Program));

app.Run();
