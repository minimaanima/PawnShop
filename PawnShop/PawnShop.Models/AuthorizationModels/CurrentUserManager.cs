using PawnShop.Models.BusinessModels;

namespace PawnShop.Models.AuthorizationModels
{
    public static class CurrentUserManager
    {
        public static  User CurrentUser { get; set; }
    }
}
