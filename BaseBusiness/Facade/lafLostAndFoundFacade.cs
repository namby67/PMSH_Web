using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class lafLostAndFoundFacade : BaseFacadeDB
    {
        protected static lafLostAndFoundFacade instance = new lafLostAndFoundFacade(new lafLostAndFoundModel());
        protected lafLostAndFoundFacade(lafLostAndFoundModel model) : base(model)
        {
        }
        public static lafLostAndFoundFacade Instance
        {
            get { return instance; }
        }
        protected lafLostAndFoundFacade() : base()
        {
        }
    }
}
