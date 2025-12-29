using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class PackageForecastGroupBO : BaseBO
    {
        private readonly PackageForecastGroupFacade facade = PackageForecastGroupFacade.Instance;
        protected static readonly PackageForecastGroupBO instance = new();
        protected PackageForecastGroupBO()
        {
            baseFacade = facade;
        }
        public static PackageForecastGroupBO Instance { get { return instance; } }
    }
}
