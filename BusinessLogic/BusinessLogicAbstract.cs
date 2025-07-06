using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEntities;

namespace BusinessLogic
{
    public abstract class BusinessLogicAbstract
    {
        #region public
        public static BusinessLogicAbstract CreateModel()
        {
            return _businessInstance.Value;
        }

        public abstract Player StartGame();

        #endregion public

        #region private
        private static Lazy<BusinessLogicAbstract> _businessInstance = new Lazy<BusinessLogicAbstract>(() => new BusinessLogicImplementation());
        #endregion private

    }
}
