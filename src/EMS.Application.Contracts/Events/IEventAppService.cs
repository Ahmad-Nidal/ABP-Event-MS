using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EMS.Events;

public interface IEventAppService : 
    ICrudAppService<
    EventDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateUpdateEventDto>
{
    
}