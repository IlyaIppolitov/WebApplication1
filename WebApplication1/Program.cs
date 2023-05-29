var builder = WebApplication.CreateBuilder(args);
// builder - паттерн проектирование Строитель (Builder)

var app = builder.Build();
var curDate = DateTime.Now.ToString();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/", () => DateTime.Now.ToString());
app.MapGet("/new_year", getDaysTillNewYear);

app.Run();

string getDaysTillNewYear()
{
    /// Текущий год
    var year = DateTime.Now.Year;
    /// Текущая дата
    var newYear = new DateTime(year, 12, 31);
    /// Расчёт количества дней до ноговго года
    var days = (newYear - DateTime.Now).Days;

    return $"До нового года осталось {days} дней!";
}