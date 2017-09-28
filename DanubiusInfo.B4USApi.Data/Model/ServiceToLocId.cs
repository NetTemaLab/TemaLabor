using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanubiusInfo.B4USApi.Data.Model
{
    [Table("servicestoloc")]
    class ServiceToLocId
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("ServiceId")]
        public int ServiceId { get; set; }

        [Column("LocId")]
        public int LocId{ get; set; }
    }
}
