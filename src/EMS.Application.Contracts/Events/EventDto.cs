using System;
using Volo.Abp.Application.Dtos;

namespace EMS.Events;

public class EventDto : AuditedEntityDto<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Location Location { get; set; }
    public DateTime Date { get; set; }
}