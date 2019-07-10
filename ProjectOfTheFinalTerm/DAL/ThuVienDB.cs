namespace DAL
{
    using System.Data.Entity;

    public class ThuVienDB : DbContext
    {
        // Your context has been configured to use a 'ThuVienDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.ThuVienDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ThuVienDB' 
        // connection string in the application configuration file.
        public ThuVienDB()
            : base("name=ThuVienDB")
        {
            Database.SetInitializer<ThuVienDB>(new BuidDb());
            //Database.SetInitializer<ThuVienDB>(new CreateDatabaseIfNotExists<ThuVienDB>());
        }
        public class BuidDb : CreateDatabaseIfNotExists<ThuVienDB>
        {
            protected override void Seed(ThuVienDB context)
            {
                //base.Seed(context);

                context.LoaiSachs.Add(new LoaiSach { MaLoai = "sdsa", TenLoai = "sdasd" });

                context.SaveChanges();
            }
        }

        //public virtual DbSet<DocGia> DocGias { get; set; }
        //public virtual DbSet<NhanVien> NhanViens { get; set; }
        //public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<LoaiSach> LoaiSachs { get; set; }
        //public virtual DbSet<MuonTra> MuonTras { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // configures one-to-many relationship
        //    modelBuilder.Entity<Sach>()
        //        .HasRequired<LoaiSach>(s => s.LoaiSach)
        //        .WithMany(g => g.Sachs)
        //        .HasForeignKey<LoaiSach>(s => s.LoaiSach);

        //    modelBuilder.Entity<DocGia>()
        //                .HasRequired(s => s.MuonTra)
        //                .WithRequiredPrincipal(ad => ad.DocGia);
        //    modelBuilder.Entity<NhanVien>()
        //                .HasRequired(s => s.MuonTra)
        //                .WithRequiredPrincipal(ad => ad.NhanVien);
        //    modelBuilder.Entity<Sach>()
        //                .HasRequired(s => s.MuonTra)
        //                .WithRequiredPrincipal(ad => ad.Sach);
        //}
       
    }



    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    // public virtual DbSet<MyEntity> MyEntities { get; set; }
}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
