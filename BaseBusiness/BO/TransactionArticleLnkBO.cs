using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class TransactionArticleLnkBO : BaseBO
    {
        private readonly TransactionArticleLnkFacade facade = TransactionArticleLnkFacade.Instance;
        protected readonly static TransactionArticleLnkBO instance = new();

        protected TransactionArticleLnkBO()
        {
            baseFacade = facade;
        }

        public static TransactionArticleLnkBO Instance
        {
            get { return instance; }
        }
    }
}
