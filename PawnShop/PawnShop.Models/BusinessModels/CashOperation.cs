namespace PawnShop.Models.BusinessModels
{
    using System.ComponentModel.DataAnnotations;
    using Enums;

    public class CashOperation
    {
        [Key]
        public int Id { get; set; }

        public OperationType OperationType { get; set; }    

        public string Details { get; set; }

        public int CashBoxId { get; set; }

        public virtual CashBox CashBox { get; set; }

        public void WithdrawMoney(decimal money)
        {
            //TODO:
        }

        public void DepositMoney(decimal money)
        {
            //TODO:
        }

        public void PayRent(decimal money)
        {
            //TODO:
        }

        public void GiveSalaries(decimal money)
        {
            //TODO:
        }
    }
}
