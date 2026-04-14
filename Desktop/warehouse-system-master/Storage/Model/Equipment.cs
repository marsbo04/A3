
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Model
{
    public class Equipment
    {

        public int ID { get; set; }
        public String Note { get; set; }
        public Equipment(int ID, string Note) { 
            this.ID = ID;
            this.Note = Note;
        
        }
    }
}
