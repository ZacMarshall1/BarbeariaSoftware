using Microsoft.EntityFrameworkCore;

class BarbeariaContext : DbContext
{
    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }

    public BarbeariaContext(DbContextOptions<BarbeariaContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseMySql("server=localhost;port=3306;user=root;password=1204;database=localhost;");
    }
}