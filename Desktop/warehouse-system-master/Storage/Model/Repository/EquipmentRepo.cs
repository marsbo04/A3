using System;
using System.Collections.Generic;
using System.Text;
using Storage.Model.Interface;
using Storage.Model;
using System.Security.RightsManagement;
namespace Storage.Model
{
    public class EquipmentRepo : IEquipmentRepository
    {
        private List<Equipment> _equipment; 
        public List<Equipment> GetAllEquipment() => _equipment;
        public Equipment GetEquipmentById(int ID) => _equipment.FirstOrDefault(x => x.ID == ID);

        public void LoadFromDatabase()
        { }

    }
}
