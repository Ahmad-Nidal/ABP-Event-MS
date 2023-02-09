using System;
using EMS.Events;
using EMS.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EMS.Events;

public class EventAppService :
    CrudAppService<
        Event,
        EventDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateEventDto>,
    IEventAppService
{
    public EventAppService(IRepository<Event, Guid> repository) 
        : base(repository)
    {
        // GetPolicyName = EMSPermissions.Events.Default;
        // GetListPolicyName = EMSPermissions.Events.Default;
        // CreatePolicyName = EMSPermissions.Events.Create;
        // UpdatePolicyName = EMSPermissions.Events.Edit;
        // DeletePolicyName = EMSPermissions.Events.Delete;
    }
}