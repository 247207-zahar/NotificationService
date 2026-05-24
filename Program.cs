using NotificationService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ✅ NotificationConfig register karo (Singleton - ek hi instance)
builder.Services.AddSingleton<NotificationConfig>();

// ✅ NotificationService register karo (Scoped)
builder.Services.AddScoped<NotificationService.Services.NotificationService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<NotificationService.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();