using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace Storage.Model
{
    public class Job
    {
        public int ID { get; set;}
        public string Name {  get; set;}
        public DateTime StarDateTime { get; set;}
        public DateTime EndDateTime { get; set;}
        public int AudienceSize { get; set;}
        public bool IsPacked {  get; set;}
        public string Note { get; set;}



        public Job(int ID, string Name, DateTime StartDateTime, DateTime EndDateTime, int AudienceSize, bool IsPacked, String Note)
        {
            this.ID = ID;
            this.Name = Name;
            this.StarDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.AudienceSize = AudienceSize;
            this.IsPacked = IsPacked;
            this.Note = Note; 
        }
    }
}
