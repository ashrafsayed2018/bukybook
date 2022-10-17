namespace bukyBookWeb.data
{
    public class DbContextOptions
    {

        public DbContextOptions(DbContextOptions<ApplicationDbContext> options) base(options)
        {

        }
    public DbSet <Category> categories { get; set; }
}
}