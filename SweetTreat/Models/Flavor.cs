using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetTreat.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
     [Required(ErrorMessage = "The treat's name can't be empty!")]
    public string Name { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add a flavor to your treat. Have you created any flavors yet?")]
    public int TreatId { get; set; }
    public Treat Treat { get; set; }
    public List<FlavorTreat> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}