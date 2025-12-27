using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO    
{
    public class CashierBO : BaseBO
    {
    private CashierFacade facade = CashierFacade.Instance;
    protected static CashierBO instance = new CashierBO();

    protected CashierBO()
    {
        this.baseFacade = facade;
    }

    public static CashierBO Instance
    {
        get { return instance; }
    }
}
}
