using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanubiusInfo.B4USApi.Data.Model
{
    [Table("reservations")]
    public class Reservation: Entity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        public Location Location { get; set; }
    }
}
