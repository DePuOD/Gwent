using UnderneathLayer = Data.DataAbstract;
using GameEntities;

namespace BusinessLogic
{
    internal class BusinessLogicImplementation : BusinessLogicAbstract
    {
        #region ctor

        public BusinessLogicImplementation() : this(null) { }

        internal BusinessLogicImplementation(UnderneathLayer dataLayer)
        {
            DataLayer = dataLayer == null ? UnderneathLayer.CreateModel() : dataLayer;
        }

        #endregion ctor

        #region public

        public override Player StartGame()
        {
            Player player = new Player();
            return player;
        }

        #endregion public

        #region private

        private UnderneathLayer DataLayer;

        #endregion private
    }
}
