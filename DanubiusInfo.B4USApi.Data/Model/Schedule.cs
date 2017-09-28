using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanubiusInfo.B4USApi.Data.Model
{
    [Table("schedules")]
    class Schedule : Entity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
                
        [Column("ServiceToLocId")]
        public int ServiceToLocId { get; set; }

        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("StartTime")]      
        public int StartTime { get; set; }

        [Column("EndDate")]        
        public DateTime EndDate { get; set; }

        [Column("EndTime")]        
        public int EndTime { get; set; }

        [Column("ConcurrentNum")]        
        public int ConcurrentNum { get; set; }

        [Column("Frequency")]
        public int Frequency { get; set; }

        [Column("FrequencyNum")]
        public int FrequencyNum { get; set; }

        [Column("DaysOfWeek")]
        public int DaysOfWeek { get; set; }

        [Column("Note")]        
        public String Note { get; set; }
    }
}
