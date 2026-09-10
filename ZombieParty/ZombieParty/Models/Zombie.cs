using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class Zombie
    {

        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Zombie Type")]
        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }
        public int Point { get; set; }
    }
}
