using System;
using System.Collections.Generic;
using System.Text;
using Storage.Model.Interface;
using Storage.Model;
namespace Storage.Model
{
    public class JobRepo : IJobRepository
    {
        private List<Job> _jobs;

        public List<Job> GetAllJobs() => _jobs;
        public Job GetJobById(int ID) => _jobs.FirstOrDefault(x => x.ID == ID);

        public void AddJob(Job job) => _jobs.Add(job);

        public void DeleteJob(int Id)
        => _jobs.FirstOrDefault(x => x.ID == Id);
      
        public void UpdateJob(Job job)
        {
            throw new NotImplementedException();
            //not implemented 
        }

        public void SaveToDatabase()
        {
            throw new NotImplementedException();
            //not implemented 
        }

        public void LoadFromDatabase()
        {
            throw new NotImplementedException();
            //not implemented 
        }

    }
}