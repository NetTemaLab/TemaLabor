namespace DanubiusInfo.B4USApi.DTO
{
    public class LocationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public int DayStart { get; set; }
        public int DayEnd { get; set; }
        public byte HasFullTimeTable { get; set; }
        public int SlotMinutes { get; set; }
        public int ConcurrentNum { get; set; }
        public byte HasUserViewSlotMinutes { get; set; }
        public byte ReadOnlyCal { get; set; }
        public int MinTimeReserve { get; set; }
        public int MinTimeModify { get; set; }
        public byte WeekendDisabled { get; set; }
        public int WeeksForward { get; set; }
    }
}
