using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.MyCompany.Bussiness.Util
{
    public class ServiceResponseList<T> : ServiceResponseBase 
    {
        private List<T> _entities = default(List<T>);

        public ServiceResponseList(List<T> entity)
        {
            _entities = entity;
        }

        public List<T> Entities
        {
            get
            {
                return _entities;
            }
            set
            {
                _entities = value;
            }
        }
    }
}
