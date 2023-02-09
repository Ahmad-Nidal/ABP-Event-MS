using AutoMapper;
using EMS.Events;

namespace EMS;

public class EMSApplicationAutoMapperProfile : Profile
{
    public EMSApplicationAutoMapperProfile()
    {
        CreateMap<Event, EventDto>();
        CreateMap<Event, CreateUpdateEventDto>();
    }
}
