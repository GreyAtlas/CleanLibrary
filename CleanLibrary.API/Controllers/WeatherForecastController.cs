using Microsoft.AspNetCore.Mvc;
using CleanLibrary.Application;
using MediatR;
using System.Collections.Generic;
using System;
using CleanLibrary.Application.Features.WeatherForecasts;
using CleanLibrary.Domain.Entities;


namespace CleanLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<WeatherForecast>>> Get()
        {
            return await _mediator.Send(new GetWeatherForecasts { });
        }
    }
}
