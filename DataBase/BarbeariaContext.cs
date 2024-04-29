using Microsoft.EntityFrameworkCore;

class BarbeariaContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(
            "server=localhost;port=3306;database=barbearia;user=root;password=1204");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agendamento>().HasNoKey();
        modelBuilder.Entity<Cliente>().HasNoKey();
        modelBuilder.Entity<Servico>().HasNoKey();
        modelBuilder.Entity<Funcionario>().HasNoKey();
    }


    public BarbeariaContext(DbContextOptions<BarbeariaContext> options) : base(options)
    {
    }


    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }
}