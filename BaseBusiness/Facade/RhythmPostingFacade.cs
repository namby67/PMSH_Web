using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class RhythmPostingFacade : BaseFacadeDB
    {
        private static readonly RhythmPostingFacade instance = new(new RhythmPostingModel ());
        protected RhythmPostingFacade(RhythmPostingModel model) : base(model) { }
        public static RhythmPostingFacade Instance
        {
            get { return instance; }
        }
    }
}
