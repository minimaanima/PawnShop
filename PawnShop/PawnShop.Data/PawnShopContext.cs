namespace PawnShop.Data
{
    using System.Data.Entity;
    using Models.AuthorizationModels;
    using Models.BusinessModels;


    public class PawnShopContext : DbContext
    {
        public PawnShopContext()
            : base("name=PawnShopContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Credentials> Credentials { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<Address> Addresses { get; set; }

        public virtual IDbSet<CashBox> CashBoxes { get; set; }

        public virtual IDbSet<CashOperation> CashOperations { get; set; }

        public virtual IDbSet<Client> Clients { get; set; }

        public virtual IDbSet<Contract> Contracts { get; set; }

        public virtual IDbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Offices)
                .WithMany(o => o.Clients)
                .Map(m =>
                {
                    m.ToTable("ClientsOffices");
                    m.MapLeftKey("ClientId");
                    m.MapRightKey("OfficeId");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}