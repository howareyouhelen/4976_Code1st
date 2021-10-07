using System.ComponentModel.DataAnnotations.Schema;

public class Player {
   public int PlayerId { get; set; } //if this follows rule of [name of class] + Id, it'll automatically know this is PK
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string Position { get; set; }

// relationship
   public string TeamName { get; set; }

   [ForeignKey("TeamName")]
   public Team Team { get; set; }
}