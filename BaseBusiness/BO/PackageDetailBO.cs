using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class PackageDetailBO : BaseBO
    {
        private readonly PackageDetailFacade facade = PackageDetailFacade.Instance;
        private static readonly PackageDetailBO instance = new();
        private PackageDetailBO()
        {
            baseFacade = facade;
        }
        public static PackageDetailBO Instance { get { return instance; } }
    }
}
