using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanubiusInfo.B4USApi.DTO
{
    class ScheduleDTO   //Schedule Tábla
    {
        //Kulcs ID
        public int Id { get; set; }     
        
        //TODO: Servicetoloc idegen kulcs

        //Ismétlődés (órarend) kezdő dátuma.
        public DateTime StartDate { get; set; }

        //Ismétlődés (órarend) kezdő ideje.
        public int StartTime { get; set; }

        //Ismétlődés (órarend) utolsó dátuma.
        public DateTime EndDate { get; set; }

        //Ismétlődés(órarend) utolsó ideje.
        public int EndTime { get; set; }

        //Az ismétlődésre maximum ennyi személy foglalhat. (Felülírja a Location tábla ConcurrentNum értékét).
        public int ConcurrentNum { get; set; }

        //Az ismétlődés típusa (napi/heti/havi).
        public int Frequency { get; set; }

        //Az ismétlődés frekvenciája (frq*frqNum).
        public int FrequencyNum { get; set; }

        //Jelöli, hogy melyik napokon ismétlődik a szolgáltatás.
        public int DaysOfWeek { get; set; }

        //Megjegyzés
        public String Note { get; set; }
    }
}
