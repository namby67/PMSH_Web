using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class RhythmPostingBO : BaseBO
    {
        private readonly RhythmPostingFacade facade = RhythmPostingFacade.Instance;
        private static readonly RhythmPostingBO instance = new();
        public RhythmPostingBO()
        {
            baseFacade = facade;
        }
        public static RhythmPostingBO Instance
        {
            get { return instance; }
        }
    }
}
