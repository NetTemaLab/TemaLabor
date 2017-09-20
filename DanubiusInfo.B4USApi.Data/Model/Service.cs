using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DanubiusInfo.B4USApi.Data.Model
{
    [Table("servicestable")]
    public class Service : Entity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
