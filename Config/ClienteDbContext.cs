using Microsoft.EntityFrameworkCore;
using NuevoIntento.Models;
using System.Collections.Generic;

namespace NuevoIntento.Config
{
    public class ClienteDbContext: DbContext
    {
        public ClienteDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
