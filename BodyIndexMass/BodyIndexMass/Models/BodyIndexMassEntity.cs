using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BodyIndexMass.Models
{
    public class BodyIndexMassEntity
    {
        private double _result = 0;
        private double _weight = 0;
        private double _height = 0;
        private string _classification = "";

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public double Weight { 
            get 
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        
        }
        
        public DateTime DateTime { get; set; }
        
        public double Height {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public double Result { 
            get
            {
                return _result;
            }
            set
            {
                _result = value;    
            }
        }

        public string Classification
        {
            get
            {
                return _classification;
            }
            set
            {
                _classification = value;
            }
        }
    }
}
