using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class PackageForecastGroupFacade : BaseFacadeDB
    {
        private static readonly PackageForecastGroupFacade instance = new(new PackageForecastGroupModel());
        protected PackageForecastGroupFacade(PackageForecastGroupModel model) : base(model)
        {
        }
        public static PackageForecastGroupFacade Instance
        {
            get{return instance;}
        }
        protected PackageForecastGroupFacade() : base()
        {
        }
    }
}
