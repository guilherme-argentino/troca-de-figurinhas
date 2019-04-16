using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace troca_de_figurinhas.Models
{
    public class ContextoFigurinhas : DbContext
    {
        public ContextoFigurinhas(DbContextOptions<ContextoFigurinhas> options)
            : base(options)
        { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Figurinha> Figurinhas { get; set; }
    }

    public class Member
    {
        public int MemberId { get; set; }

        public string Nome { get; set; }
        
        public string login { get; set; }
        
        public string senha { get; set; }

        public List<Figurinha> Figurinhas { get; set; }
    }

    public class Figurinha
    {
        public int FigurinhaId { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Quantidade { get; set; }
        public string Content { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}