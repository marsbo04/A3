using System;
using System.Collections.Generic;
using System.Text;
using Storage.Model; 
namespace Storage.Model.Interface
{
    public interface IEquipmentRepository
    {
        public List<Equipment> GetAllEquipment();
        public Equipment GetEquipmentById(int ID);
        public void LoadFromDatabase(); 
    }
}
