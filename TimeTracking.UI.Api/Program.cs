using TimeTracking.Core.Interfaces.Brokers;
using TimeTracking.Data.Brokers;
using CoreResource = TimeTracking.Core.Services.Resources;
using CoreActivityType = TimeTracking.Core.Services.ActivityTypes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TimeTracking.API", Version = "v1" });
});

builder.Services.AddScoped<IBroker, Broker>();

builder.Services.AddScoped<CoreResource.IResourceService, CoreResource.ResourceService>();
builder.Services.AddScoped<CoreActivityType.IActivityTypeService, CoreActivityType.ActivityTypeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TimeTracking.API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
