using PawnShop.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawnShop.Models.AuthorizationModels;

namespace PawnShop.Data.Initializers
{
    class PawnShopIni: DropCreateDatabaseAlways<PawnShopContext>
    {
        protected override void Seed(PawnShopContext context)
        {
            var user = new User()
            {
                Credentials = new Credentials()
                {
                    Email="Leonid@yambol.yl",
                    Password="Leonid1"
                }
            };
            context.Users.Add(user);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
