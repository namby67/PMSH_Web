using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ARTraceFacade : BaseFacadeDB
    {
        protected static ARTraceFacade instance = new ARTraceFacade(new ARTraceModel());
        protected ARTraceFacade(ARTraceModel model) : base(model)
        {
        }
        public static ARTraceFacade Instance
        {
            get { return instance; }
        }
        protected ARTraceFacade() : base()
        {
        }
    }
}
