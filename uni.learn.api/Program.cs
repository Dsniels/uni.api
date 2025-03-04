using uni.learn.api.Extensions;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddCors(opts=>{
    opts.AddDefaultPolicy(builder=>{
        builder.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod();

    });
});
builder.Services.AddInfraestructure(builder.Configuration);


var app = builder.Build();
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapOpenApi();
app.UseHttpsRedirection();
app.Run();

