using Microsoft.EntityFrameworkCore;

class BarbeariaContext : DbContext
{

    public BarbeariaContext(DbContextOptions<BarbeariaContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agendamento>().HasNoKey();
        modelBuilder.Entity<Cliente>().HasNoKey();
        modelBuilder.Entity<Servico>().HasNoKey();
        modelBuilder.Entity<Funcionario>().HasNoKey();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        string connectionString = "Server=barbearia;Port=3306;Database=barbearia;Uid=root;Pwd=positivo";
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }
}