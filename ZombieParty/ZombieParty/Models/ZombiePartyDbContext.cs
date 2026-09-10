using Microsoft.EntityFrameworkCore;
namespace ZombieParty.Models
{
    public class ZombiePartyDbContext() : DbContext
    {



        public DbSet<Zombie> Zombies { get; set; }




    }



}
