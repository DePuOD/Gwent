using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEntities;

namespace PresentationModel
{
    public abstract class ModelAbstract
    {


        #region public
        public static ModelAbstract CreateModel() 
        {
            return _modelInstance.Value;
        }

        public abstract Player StartGame();

        #endregion public

        #region private

        private static Lazy<ModelAbstract> _modelInstance = new Lazy<ModelAbstract>(() => new ModelImplementation());

        #endregion private

    }
}
