namespace GitHubActionsDotNet.Api.Models;

public record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.555633);

    public string? Summary { get; init; }
}

