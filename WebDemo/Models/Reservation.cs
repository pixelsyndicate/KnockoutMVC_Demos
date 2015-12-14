using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }

    public class ReservationRespository
    {
        private static ReservationRespository _repo = new ReservationRespository();

        public static ReservationRespository Current { get { return _repo; } }

        private List<Reservation> data = new List<Reservation>
        {
            new Reservation
            {
                ReservationId = 1, ClientName = "Adam", Location = "Board Room"
            },
            new Reservation
            {
                ReservationId = 2, ClientName = "Jacqui", Location = "Lecture Hall"
            },
            new Reservation
            {
                ReservationId = 3, ClientName = "Russel", Location = "Meeting Room"
            },
        };

        public IEnumerable<Reservation> GetAll()
        {
            return data;
        }

        public Reservation Get(int id)
        {
            return data.FirstOrDefault(r => r.ReservationId == id);
        }

        public Reservation Add(Reservation item)
        {
            item.ReservationId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            Reservation item = Get(id);
            if (item != null)
                data.Remove(item);
        }

        public bool Update(Reservation item)
        {
            Reservation storedItem = Get(item.ReservationId);
            if (storedItem != null)
            {
                storedItem.ClientName = item.ClientName;
                storedItem.Location = item.Location;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
