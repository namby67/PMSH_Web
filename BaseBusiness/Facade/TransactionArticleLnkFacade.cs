using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class TransactionArticleLnkFacade : BaseFacadeDB
    {
        protected private static TransactionArticleLnkFacade instance = new(new TransactionArticleLnkModel());
        protected TransactionArticleLnkFacade(TransactionArticleLnkModel model) : base(model)
        {
        }
        public static TransactionArticleLnkFacade Instance
        {
            get { return instance; }
        }
        protected TransactionArticleLnkFacade() : base()
        {
        }
    }
}
