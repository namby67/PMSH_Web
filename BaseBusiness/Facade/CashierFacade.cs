using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade 
{
    public class CashierFacade : BaseFacadeDB
    {
    protected static CashierFacade instance = new CashierFacade(new CashierModel());
    protected CashierFacade(CashierModel model) : base(model)
    {
    }
    public static CashierFacade Instance
    {
        get { return instance; }
    }
    protected CashierFacade() : base()
    {
    }
}
}
