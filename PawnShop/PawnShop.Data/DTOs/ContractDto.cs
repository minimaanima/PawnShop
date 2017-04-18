using PawnShop.Models.BusinessModels;
using PawnShop.Models.Enums;

namespace PawnShop.Data.DTOs
{
    public class ContractDto
    {
        public int ContractId { get; set; }

<<<<<<< HEAD
        public string Client { get; set; }
=======
        public Client Client { get; set; }
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee

        public string DateOfRegistrationAndExpiring { get; set; }

        public decimal PropertyValue { get; set; }

        public decimal Interest { get; set; }

        public int Days { get; set; }

        public string PledgedProperty { get; set; }

        public Status Status { get; set; }
    }
}
