using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class RateCodeDetailBO : BaseBO
    {
        private readonly RateCodeDetailFacade facade = RateCodeDetailFacade.Instance;
        private static readonly RateCodeDetailBO instance = new();
        public RateCodeDetailBO()
        {
            baseFacade = facade;
        }
        public static RateCodeDetailBO Instance
        {
            get { return instance; }
        }
    }
}
