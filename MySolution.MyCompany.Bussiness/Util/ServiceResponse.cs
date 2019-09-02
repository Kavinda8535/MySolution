using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.MyCompany.Bussiness.Util
{
    public class ServiceResponse<T> : ServiceResponseBase
    {
        private T _entity;

        public ServiceResponse(T entity)
        {
            _entity = entity;
        }

        public T Entity
        {
            get
            {
                return _entity;
            }
            set
            {
                _entity = value;
            }
        }
    }
}
