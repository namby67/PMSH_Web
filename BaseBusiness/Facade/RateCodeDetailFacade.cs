using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class RateCodeDetailFacade : BaseFacadeDB
    {
        private static readonly RateCodeDetailFacade instance = new(new RateCodeDetailModel());
        protected RateCodeDetailFacade(RateCodeDetailModel model) : base(model) { }
        public static RateCodeDetailFacade Instance
        {
            get { return instance; }
        }
    }
}
