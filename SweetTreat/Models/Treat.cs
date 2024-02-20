using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetTreat.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat's description can't be empty!")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add a flavor to your treat. Have you created any flavors yet?")]
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; }
    //public List<?> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}