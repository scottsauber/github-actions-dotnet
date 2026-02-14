namespace GitHubActionsDotNet.Api.Models;

public record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; init; }
}

//hello world
// hello world 2 
//this is a new feature
//this is a new feature 2