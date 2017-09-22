using DanubiusInfo.B4USApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanubiusInfo.B4USApi.Data;
using System.Data.Entity;

namespace DanubiusInfo.B4USApi.Providers
{
    public class ReservationProvider : GenericProvider<Reservation>, IReservationProvider
    {
        public ReservationProvider(B4USContext context) : base(context)
        {
        }

        public Reservation Get(int id)
        {
            return this.dbset.Include(p =>p.Location).FirstOrDefault(p => p.Id == id); //linq
        }
    }
}
