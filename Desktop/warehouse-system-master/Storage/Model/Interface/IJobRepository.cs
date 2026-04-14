using System;
using System.Collections.Generic;
using System.Text;
using Storage.Model; 
namespace Storage.Model.Interface
{
    public interface IJobRepository
    {
        public List<Job> GetAllJobs();
        public Job GetJobById(int id);
        public void AddJob(Job job);
        public void UpdateJob(Job job);
        public void DeleteJob(int ID);
        public void SaveToDatabase();
        public void LoadFromDatabase(); 


    }
}
