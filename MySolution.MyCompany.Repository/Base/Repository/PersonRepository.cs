using MySolution.MyCompany.Repository.Base.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.MyCompany.Repository.Base.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public int CalculateAdults()
        {
            throw new NotImplementedException();
        }
    }
}
