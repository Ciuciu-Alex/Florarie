using ManagementFlorarie.Models;
using ManagementFlorarie.Repository;
using System;
using System.Collections.Generic;

namespace ManagementFlorarie.BusinessLogic
{
    public class AngajatBL
    {
        private AngajatRepo _angajatRepo;

        public AngajatBL()
        {
            _angajatRepo = new AngajatRepo();
        }

        public UserAngajat ReadAngajatDupaID(Guid idAngajat)
        {
            return _angajatRepo.ReadAnagajatDupaID(idAngajat);
        }

        public List<Angajat> ReadAngajati()
        {
            return _angajatRepo.ReadAngajati();           
        }

        public void Insert(Angajat angajat)
        {
            if (angajat == null)
            {
                return;
            }
            _angajatRepo.InsertAngajat(angajat);
        }

        public void Update(Angajat angajat)
        {
            if (angajat == null)
            {
                return;
            }
            _angajatRepo.UpdateAngajat(angajat);
        }

        public void Delete(Guid idAngajat)
        {
            _angajatRepo.DeleteAngajat(idAngajat);
        }
    }
}
