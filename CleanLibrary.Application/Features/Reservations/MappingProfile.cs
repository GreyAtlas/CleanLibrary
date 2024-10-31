using AutoMapper;
using CleanLibrary.Application.Features.Books;
using CleanLibrary.Application.Features.Reservations.CreateReservation;
using CleanLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Reservations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ReservationDTO, Reservation>();
            CreateMap<CreateReservationCommand, Reservation>();
            CreateMap<ReservationDTO, CreateReservationCommand>();
        }
    }
}
