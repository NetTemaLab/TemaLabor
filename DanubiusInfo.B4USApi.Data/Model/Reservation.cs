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
        [Column("ClientKey")]
        public string ClientKey { get; set; }
        [Column("ScheduleId")]
        public int ScheduleId { get; set; }
        [Column("EventTitle")]
        public string EventTitle { get; set; }
        [Column("EventEnd")]
        public DateTime EventEnd { get; set; }
        [Column("EventStart")]
        public DateTime EventStart { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("UserEmail")]
        public string UserEmail { get; set; }
        [Column("UserTel")]
        public string UserTel { get; set; }
        [Column("Comment")]
        public string Comment { get; set; }
        [Column("LastModified")]
        public string LastModified { get; set; }
        public Location Location { get; set; }
    }
}
