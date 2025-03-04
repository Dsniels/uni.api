using Microsoft.EntityFrameworkCore;
using uni.learn.api.Extensions;
using uni.learn.business.logic.Context;
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
builder.Services.AddIdentityUser();
builder.Services.AddSecurity();


var app = builder.Build();
using(var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MainDbContext>();
    var identityContext = services.GetRequiredService<SecurityDbContext>();
    await identityContext.Database.MigrateAsync();
    await context.Database.MigrateAsync();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapOpenApi();
app.UseHttpsRedirection();
app.Run();

