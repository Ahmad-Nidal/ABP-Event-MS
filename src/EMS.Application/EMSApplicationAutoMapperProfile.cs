using AutoMapper;
using EMS.Events;

namespace EMS;

public class EMSApplicationAutoMapperProfile : Profile
{
    public EMSApplicationAutoMapperProfile()
    {
        CreateMap<EventDto, Event>();
        CreateMap<CreateUpdateEventDto, Event>();
    }
}
