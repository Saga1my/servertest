using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using ahhhh;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", GetSometing);
app.MapGet("/HELLO", () => "GODDBYE");
app.MapGet("/cats/{number}", GetCats);

app.Urls.Add("http://*5148");

app.Run();

static string GetSometing()
{
    return "hello";
}
static IResult GetCats(int number)
{
    List<cats> cats = new List<cats>(){
    new cats(){name = "Findus", HitPoints = 100},
    new cats(){name = "Pettson", HitPoints = 50},
    new cats(){name = "Muckla", HitPoints = 50},
    };

    if (number<0 || number >= cats.Count)
    {
        return Results.NotFound();
    }
   
    return Results.Ok( cats[number]);

}