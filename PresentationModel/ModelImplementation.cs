using GameEntities;
using UnderneathLayer = BusinessLogic.BusinessLogicAbstract;

namespace PresentationModel
{
    internal class ModelImplementation : ModelAbstract
    {
        #region ctor

        public ModelImplementation() : this(null) { }

        internal ModelImplementation(UnderneathLayer businessLayer)
        {
            BusinessLayer = businessLayer == null ? UnderneathLayer.CreateModel() : businessLayer;
        }

        #endregion ctor
        public override Player StartGame()
        {
            Player player = BusinessLayer.StartGame();
            return player;
        }

        #region private

        private UnderneathLayer BusinessLayer;

        #endregion private
    }
}
