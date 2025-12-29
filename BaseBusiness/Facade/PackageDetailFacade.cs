using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class PackageDetailFacade : BaseFacadeDB
    {
        private static readonly PackageDetailFacade instance = new(new PackageDetailModel());
        protected PackageDetailFacade(PackageDetailModel model) : base(model)
        {
        }
        public static PackageDetailFacade Instance
        {
            get { return instance; }
        }
    }
}
