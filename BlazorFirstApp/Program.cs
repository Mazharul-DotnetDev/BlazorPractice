var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//app.MapGet("/", () => "Hello World!");
app.MapBlazorHub();

//this line ensures that any requests that don't match specific routes defined in the application are routed to the _Host.cshtml page, allowing Blazor Server to handle them appropriately.

//At first, this _Host.cshtml is called.. then App.razor....MainLayout.razor

app.MapFallbackToPage("/_Host");

app.Run();



