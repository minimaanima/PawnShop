using System.Collections.Generic;

namespace PawnShop.Models.BusinessModels
{
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        public Address()
        {
            this.Clients = new HashSet<Client>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
