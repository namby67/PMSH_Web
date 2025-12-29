using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ARTraceBO: BaseBO
    {
        private ARTraceFacade facade = ARTraceFacade.Instance;
        protected static ARTraceBO instance = new ARTraceBO();

        protected ARTraceBO()
        {
            this.baseFacade = facade;
        }

        public static ARTraceBO Instance
        {
            get { return instance; }
        }
    }
}
