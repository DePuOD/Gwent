using Data.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class DataAbstract
    {

        #region public
        public static DataAbstract CreateModel()
        {
            return _dataInstance.Value;
        }

        #endregion public

        #region private
        private static Lazy<DataAbstract> _dataInstance = new Lazy<DataAbstract>(() => new DataImplementation());
        #endregion private
    }

}
