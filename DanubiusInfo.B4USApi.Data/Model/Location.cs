using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DanubiusInfo.B4USApi.Data.Model
{
    [Table("locations")]
    public class Location : Entity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
