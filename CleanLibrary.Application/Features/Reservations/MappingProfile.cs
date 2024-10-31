using AutoMapper;
using CleanLibrary.Application.Features.Reservations.CreateReservation;
using CleanLibrary.Domain.Entities;


namespace CleanLibrary.Application.Features.Reservations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ReservationDTO, Reservation>();
            CreateMap<CreateReservationCommand, Reservation>();
            CreateMap<ReservationDTO, CreateReservationCommand>()
                .ForMember(d => d.ReservationStartDate, o => o.MapFrom(s => s.ReservationStartDate))
                .ForMember(d => d.ReservationEndDate, o => o.MapFrom(s => s.ReservationEndDate));
        }
    }
}
