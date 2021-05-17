using ManagementFlorarie.Models;
using ManagementFlorarie.Repository;
using System;
using System.Collections.Generic;

namespace ManagementFlorarie.BusinessLogic
{
    public class ComandaBL
    {
        private ComandaRepo _comandaRepo;

        public ComandaBL()
        {
            _comandaRepo = new ComandaRepo();
        }

        public ComandaAngajatFloare ReadComandaDupaID(Guid ID_Comanda)
        {
            return _comandaRepo.ReadComandaDupaID(ID_Comanda);
        }

        public List<ComandaAngajatFloare> ReadComenzi()
        {
            return _comandaRepo.ReadComenzi();
        }

        public List<ComandaAngajatFloare> ReadComenziIeftine()
        {
            return _comandaRepo.ReadComenziIeftine();
        }

        public List<ComandaAngajatFloare> ReadComenziScumpe()
        {
            return _comandaRepo.ReadComenziScumpe();
        }

        public List<ComandaAngajatFloare> DupaFloareScumpa()
        {
            return _comandaRepo.ReadComenziDupaFloareScumpa();
        }

        public List<ComandaAngajatFloare> ReadComenziDupaCeaMaiScumpaFloare()
        {
            return _comandaRepo.ReadComenziDupaCeaMaiScumpaFloare();
        }

        public List<ComandaAngajatFloare> ReadComenziDupaCeaMaiIeftinaFloare()
        {
            return _comandaRepo.ReadComenziDupaCeaMaiIeftinaFloare();
        }

        public void InsertComanda(ComandaAngajatFloare comanda)
        {
            _comandaRepo.InsertComanda(comanda);
        }

        public void UpdateComanda(ComandaAngajatFloare comanda)
        {
            _comandaRepo.UpdateComanda(comanda);
        }

        public void DeleteComanda(Guid ID_Comanda)
        {
            _comandaRepo.DeleteComanda(ID_Comanda);
        }

        public ComandaAngajatFloare ReadComandaDupaNume(string numeComanda)
        {
            return _comandaRepo.ReadComandaDupaNume(numeComanda);
        }
    }
}
