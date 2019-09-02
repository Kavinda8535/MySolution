using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.MyCompany.Repository.Base.IRepository
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        int CalculateAdults();
    }
}
