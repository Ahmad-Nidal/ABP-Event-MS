using System;
using System.Threading.Tasks;
using EMS.Events;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace EMS;

public class EMSDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Event, Guid> _eventRepository;

    public EMSDataSeederContributor(IRepository<Event, Guid> eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _eventRepository.GetCountAsync() <= 0)
        {
            await _eventRepository.InsertAsync(
                new Event
                {
                    Title = "Amman Event",
                    Location = Location.Amman,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus quis malesuada risus.",
                    Date = new DateTime(2023, 3, 24)
                },
                autoSave: true
            );

            await _eventRepository.InsertAsync(
                new Event
                {
                    Title = "Zarq Event",
                    Location = Location.Zarqa,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus quis malesuada risus.",
                    Date = new DateTime(2023, 4, 23)
                },
                autoSave: true
            );
        }
    }
}