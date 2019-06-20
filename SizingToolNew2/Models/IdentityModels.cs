using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SizingToolNew2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class SizingDbContext : IdentityDbContext<ApplicationUser>
    {

        public SizingDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)


        {


        }
        
        public DbSet<AcctCust> AcctCusts { get; set; }
        public DbSet <Sizing> Sizings { get; set; }
        public DbSet <SizingDetail> SizingDetails { get; set; }
        public DbSet<SizingType> SizingTypes { get; set; }
      //  public DbSet<NbieSizer> NbieSizers { get; set; }
      //   public DbSet<NbieRate> NbieRates { get; set; }
        public DbSet<AvProduct> AvProducts { get; set; }
        public DbSet<AvProdComponent> AvProdComponents { get; set; }
        public DbSet<ProdVendor> ProdVendors { get; set; }
        public DbSet<ProdCategory> ProdCategorys { get; set; }
        public DbSet<LaborDelivery> LaborDeliverys { get; set; }
        public DbSet<ConfigTable> ConfigTables { get; set; }
        public DbSet<CustAcct> CustAccts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SecurityService> SecurityServices { get; set; }
        public DbSet<StatusState> StatusStates { get; set; }
        public DbSet<ConfigMaster> ConfigMasters { get; set; }
        public DbSet<TnTWorksheet> TnTWorksheet { get; set; }
        public DbSet<LaborDeliveryType> LaborDeliveryTypes { get; set; }





        public static SizingDbContext Create()
        {



            return new SizingDbContext();

        }

        public System.Data.Entity.DbSet<SizingToolNew2.ViewModels.SizingComponent5VM> SizingComponent5VM { get; set; }

        public System.Data.Entity.DbSet<SizingToolNew2.ViewModels.TestVM10> TestVM10 { get; set; }


       



        //  protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //  {
        //     modelBuilder.Entity<Sizing>()
        //                 .HasRequired(s1 => s1.SizingDetail)
        //                 .WithRequiredPrincipal(s2 => s2.Sizing);
    }
    //  public System.Data.Entity.DbSet<SizingToolNew2.Models.SizingComponentViewModel> SizingComponentViewModels { get; set; }

    // public System.Data.Entity.DbSet<SizingToolNew2.Models.SizingVM> SizingVMs { get; set; }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<SizingDetail>().HasRequired(x => x.Sizing);
    //    base.OnModelCreating(modelBuilder);
    //}

    //     protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //  modelBuilder.Entity<Sizing>()
    //      .HasRequired(c1 => c1.SizingDetail)
    //      .WithRequiredPrincipal(c2 => c2.Sizing);
    //    }

    //  public System.Data.Entity.DbSet<SizingToolNew2.Models.SizingVM> SizingVMs { get; set; }

    //   protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //   {
    //      modelBuilder.Entity<Sizing>()
    //               .HasRequired(s => s.Detail)
    ///                .WithRequiredPrincipal(ad => ad.Sizing);
    //   }
}


