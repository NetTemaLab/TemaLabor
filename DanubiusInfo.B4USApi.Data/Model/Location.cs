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
        [Column("Type")]
        public byte Type { get; set; }
        [Column("DayStart")]
        public int DayStart { get; set; }
        [Column("DayEnd")]
        public int DayEnd { get; set; }
        [Column("HasFullTimeTable")]
        public byte HasFullTimeTable { get; set; }
        [Column("SlotMinutes")]
        public int SlotMinutes { get; set; }
        [Column("ConcurrentNum")]
        public int ConcurrentNum { get; set; }
        [Column("HasUserViewSlotMinutes")]
        public byte HasUserViewSlotMinutes { get; set; }
        [Column("ReadOnlyCal")]
        public byte ReadOnlyCal { get; set; }
        [Column("MinTimeReserve")]
        public int MinTimeReserve { get; set; }
        [Column("MinTimeModify")]
        public int MinTimeModify { get; set; }
        [Column("WeekendDisabled")]
        public byte WeekendDisabled { get; set; }
        [Column("WeeksForward")]
        public int WeeksForward { get; set; }

        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
