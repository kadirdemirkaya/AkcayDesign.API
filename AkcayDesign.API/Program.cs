using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Filters.ModelValidationFilter;
using DataAccessLayer.Extensions;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidateModelAttribute>();
});

builder.Services.DataAccessLayerExtension(builder.Configuration);
builder.Services.BusinessLogicLayerExtension();


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
