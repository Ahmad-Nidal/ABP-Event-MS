using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace EMS.Events;

public class Event : AuditedAggregateRoot<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Location Location { get; set; }
    public DateTime Date { get; set; }
}