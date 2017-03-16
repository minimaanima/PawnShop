using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawnShop.Models.BusinessModels
{
    public class Office
    {
        public Office()
        {
            this.Employees = new HashSet<User>();
            this.Contracts = new HashSet<Contract>();
            this.Clients = new HashSet<Client>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Id")]
        public virtual Address Address { get; set; }

        [InverseProperty("Office")]
        public virtual ICollection<User> Employees { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
