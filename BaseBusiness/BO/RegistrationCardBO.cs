using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class RegistrationCardBO : BaseBO
    {
        private RegistrationCardFacade facade = RegistrationCardFacade.Instance;
        protected static RegistrationCardBO instance = new RegistrationCardBO();

        protected RegistrationCardBO()
        {
            this.baseFacade = facade;
        }

        public static RegistrationCardBO Instance
        {
            get { return instance; }
        }
        public static List<RegistrationCardModel> GetRegistrationCard()
        {
            string query = $"select a.* from RegistrationCard a\r\nleft join Brand b\r\non a.BrandID = b.ID\r\nwhere b.IsActive = 1 ";
            return instance.GetList<RegistrationCardModel>(query);
        }
    }
}
