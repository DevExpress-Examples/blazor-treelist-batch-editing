using Microsoft.EntityFrameworkCore;
using TreeListBatchEditing.Components;
using TreeListBatchEditing.Services;
using TreeListBatchEditing.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDevExpressBlazor(options => {
    options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
});
builder.Services.AddScoped<CitiesService>();
builder.Services.AddDbContextFactory<CitiesContext>(opt =>
        opt.UseSqlite($"Data Source=Cities.db"), ServiceLifetime.Scoped);
builder.Services.AddMvc();

var app = builder.Build();

using (var scope = app.Services.CreateScope()) {
    var citiesService = scope.ServiceProvider.GetRequiredService<CitiesService>();
    citiesService.SeedData();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
