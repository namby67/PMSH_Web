using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public  class ARAccountReceivableOldBalancesFacade : BaseFacadeDB
    {
        protected static ARAccountReceivableOldBalancesFacade instance = new ARAccountReceivableOldBalancesFacade(new ARAccountReceivableOldBalancesModel());
        protected ARAccountReceivableOldBalancesFacade(ARAccountReceivableOldBalancesModel model) : base(model)
        {
        }
        public static ARAccountReceivableOldBalancesFacade Instance
        {
            get { return instance; }
        }
        protected ARAccountReceivableOldBalancesFacade() : base()
        {
        }
    }
}
