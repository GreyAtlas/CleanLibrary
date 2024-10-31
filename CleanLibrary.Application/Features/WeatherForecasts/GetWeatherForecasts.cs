using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanLibrary.Domain.Entities;

namespace CleanLibrary.Application.Features.WeatherForecasts
{
    public record GetWeatherForecasts : IRequest<List<WeatherForecast>>;
}
