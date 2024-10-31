using CleanLibrary.Application.Interfaces;
using CleanLibrary.Domain.Entities;
using MediatR;
using System.Reflection.Metadata;


namespace CleanLibrary.Application.Features.WeatherForecasts
{
    public class GetWeatherForecastsHandler : IRequestHandler<GetWeatherForecasts,List<WeatherForecast>>
    { 
        //private readonly ILibraryDataContext _libraryDataContext;
        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

/*        public GetWeatherForecastsHandler(ILibraryDataContext libraryDataContext)
        {
            _libraryDataContext = libraryDataContext;
        }*/

        public async Task<List<WeatherForecast>> Handle(GetWeatherForecasts request, CancellationToken cancellationToken)
        {

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList();
        }
    }
}
