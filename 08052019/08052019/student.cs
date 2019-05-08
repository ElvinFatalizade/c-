using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08052019
{
    class student
    {
        private string _Name { get; set; }

        public string Surname { get; set; }

        private int Age { get; set; }

       public String Name {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
    }          

    }

    class car
    {
        private double _fuelusage;
        private double _fullcapacity;
        private double _currentfuel =90;


        public double currentfuel
        {
            get
            {
                return _currentfuel;
            }
            
        }

        public void AddFuel(double litr)
        {
            if (_currentfuel + litr >= this._fullcapacity)
            {
                return;
            }
            this._currentfuel += litr;
        }
        private double _globalkm;

        public double globalkm
        {
            get
            {
                return this._globalkm;
            }
        }
        private double _localkm;

        public double localkm
        {
            get
            {
                return _localkm;
            }
        }
        public void Resetlocal()
        {
            this._localkm = 0;
        }

    }
}
