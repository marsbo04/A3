using System;
using System.Collections.Generic;
using System.Text;

namespace car_rental
{
    public class Journal
    {

        public int km { get; private set; }

        public string Model { get; private set; }   

        public string Nummerplade { get; private set; }

        private List<Journal> _journal = new List<Journal>();

        public Journal(){}
        public Journal(int km, string Model, String Nummerplade) 
        {
            this.km = km;
            this.Model = Model;
            this.Nummerplade = Nummerplade;
            _journal.Add(this);
        }
        public List<Journal> GetJournal() => _journal;

        public void Add(Journal s) => _journal.Add(s);

        public override string ToString()
        {
            return $"{km} km, Model: {Model}, Nummerplade: {Nummerplade}";
        }

    }
}
