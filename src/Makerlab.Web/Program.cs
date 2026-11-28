using Makerlab.Infrastructure;
using Makerlab.Web.Components;
using Microsoft.EntityFrameworkCore;


DotNetEnv.Env.TraversePath().Load();
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default")
                       ?? throw new InvalidOperationException("Connection string 'Default' not found.");

builder.Services.AddInfrastructure(connectionString);


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



var app = builder.Build();


// Auto migrate and seed
using (var scope = app.Services.CreateScope())
{
    var factory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<MakerLabDBContext>>();
    using var db = factory.CreateDbContext();
    db.Database.Migrate();
    MainSeeder.Seed(db);
}




if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
