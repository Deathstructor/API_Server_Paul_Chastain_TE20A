WebApplication app = WebApplication.Create();

app.Urls.Add("https://localhost:3000");
app.Urls.Add("https://*:3000");

app.MapGet("/", Answer);
app.MapGet("/spicy/", () => { return "Habanero"; });

app.Run();

static string Answer()
{
    return "Test";
}