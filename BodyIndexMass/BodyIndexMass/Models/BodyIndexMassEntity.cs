using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyIndexMass.Models
{
    public class BodyIndexMassEntity
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public double Weight { get; set; }
        public DateTime DateTime { get; set; }
        public double Height { get; set; }
        public double Result { 
            get
            {
                double hsquared = Math.Pow((double)((Height / 100)), 2);
                if (Height > 0) return (double)(Weight / hsquared);

                return 0;
            }
        }
    }
}
