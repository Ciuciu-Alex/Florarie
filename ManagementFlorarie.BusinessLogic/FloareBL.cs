using ManagementFlorarie.Models;
using ManagementFlorarie.Repository;
using System;
using System.Collections.Generic;

namespace ManagementFlorarie.BusinessLogic
{
    public class FloareBL
    {
        private FloareRepo _floareRepo;

        public FloareBL ()
        {
            _floareRepo = new FloareRepo();
        }

        public Floare ReadFloareDupaID(Guid ID_Floare)
        {
            return _floareRepo.ReadFloareDupaID(ID_Floare);
        }

        public List<Floare> ReadFlori()
        {
            return _floareRepo.ReadFlori();
        }

        public void InsertFloare(Floare floare)
        {
            if (floare == null)
            {
                return;
            }
            _floareRepo.InsertFloare(floare);
        }

        public void UpdateFloare(Floare floare)
        {
            if (floare == null)
            {
                return;
            }
            _floareRepo.UpdateFloare(floare);
        }

        public void DeleteFloare(Guid idFloare)
        {
            _floareRepo.DeleteFloare(idFloare);
        }

        public Floare FloareCantitate()
        {
            return _floareRepo.FloareCantitate();
        }

        public void UpdateCantitateFloare(int cantitateFloare, Guid idFloare)
        {
             _floareRepo.UpdateCantitateFloare(cantitateFloare, idFloare);
        }

        public Floare ReadFloareDupaNume(string numeFloare)
        {
            return _floareRepo.ReadFloareDupaNume(numeFloare);
        }
    }
}
