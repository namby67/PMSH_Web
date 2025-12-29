using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class RateClassFacade : BaseFacadeDB
    {
        // Instance luôn có model → không null
        protected static RateClassFacade instance = new RateClassFacade(new RateClassModel());

        protected RateClassFacade(RateClassModel model) : base(model)
        {
        }

        public static RateClassFacade Instance
        {
            get { return instance; }
        }

        // ❌ XÓA constructor này! Nó gây lỗi model = null
        // protected RateClassFacade() : base() { }
    }
}
