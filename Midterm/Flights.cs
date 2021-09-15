using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Midterm
{
    class Flights
    {
        private int id;
        private int airlineId;
        private string departurecity;
        private string destinationcity;
        private string departuredate;
        private double flighttime;

        public Flights(int id , int airlineId,string departurecity,string destinationcity,string departuredate,double flighttime)
        {
            Id = id;
            AirlineId = airlineId;
            Departurecity = departurecity;
            Destinationcity = destinationcity;
            Departuredate = departuredate;
            Flighttime = flighttime;


        }
        public Flights()
        {

        }
        public int Id {

            get { return this.id; }
            set { this.id = value; }
        }
        public int AirlineId
        {

            get { return this.airlineId; }
            set { this.airlineId = value; }
        }

        public string Departurecity
        {
            get { return this.departurecity; }
            set { this.departurecity = value; }
        }
        public string Destinationcity
        {
            get { return this.destinationcity; }
            set { this.destinationcity = value; }
        }
        public string Departuredate
        {
            get { return this.departuredate; }
            set { this.departuredate = value; }
        }

        public double Flighttime
        {
            get { return this.flighttime; }
            set { this.flighttime = value; }
        }

        public override string ToString()
        {
            return $"Id:{Id}\tAirlineId:{AirlineId}\tDepartureCity:{Departurecity}\tDestinationCity:{Destinationcity}\tDepartureDate:{Departuredate}\tFlightTime:{Flighttime}";
        }

        public List<Flights> getFlight()
        {
            List<Flights> flist = new List<Flights> {
             new Flights(1,1,"Toronto","London","3-3-2020",12),
            new Flights(2,2,"Delhi","NewYork","4-5-2020",5),
            new Flights(3,3,"Alberta","Spain","6-5-2020",10)
            };
            return flist;
        }
    }
}
