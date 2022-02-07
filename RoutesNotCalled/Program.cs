var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", context =>
{
    context.Response.Redirect("/foo/metadata");
    return Task.CompletedTask;
});


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.Run();