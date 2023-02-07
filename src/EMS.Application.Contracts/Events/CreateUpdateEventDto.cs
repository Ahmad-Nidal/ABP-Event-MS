using System;
using System.ComponentModel.DataAnnotations;

namespace EMS.Events;

public class CreateUpdateEventDto
{
    [Required]
    [MaxLength(128)]
    public string Title { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public Location Location { get; set; } = Location.Undefined;
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; } = DateTime.Now;
}