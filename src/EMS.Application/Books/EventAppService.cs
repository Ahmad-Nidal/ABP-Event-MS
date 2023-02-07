using System;
using EMS.Events;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EMS.Books;

public class EventAppService :
    CrudAppService<
    Event,
    EventDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateUpdateEventDto>,
    IEventAppService
{
    public EventAppService(IRepository<Event, Guid> repository) : base(repository)
    {
    }
}