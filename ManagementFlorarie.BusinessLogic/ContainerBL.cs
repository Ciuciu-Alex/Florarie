using ManagementFlorarie.Models;

namespace ManagementFlorarie.BusinessLogic
{
    public class ContainerBL
    {
        private UserBL _userBL;
        private AngajatBL _angajatBL;
        private FloareBL _floareBL;
        private ComandaBL _comandaBL;

        public Utilizator CurrentUser { get; set; }

        public UserBL UserBL
        {
            get
            {
                if (_userBL == null)
                {
                    _userBL = new UserBL();
                }
                return _userBL;
            }
        }

        public AngajatBL AngajatBL
        {
            get
            {
                if (_angajatBL == null)
                {
                    _angajatBL = new AngajatBL();
                }
                return _angajatBL;
            }
        }

        public FloareBL FloareBL
        {
            get
            {
                if (_floareBL == null)
                {
                    _floareBL = new FloareBL();
                }
                return _floareBL;
            }
        }

        public ComandaBL ComandaBL
        {
            get
            {
                if (_comandaBL == null)
                {
                    _comandaBL = new ComandaBL();
                }
                return _comandaBL;
            }
        }
    }
}
