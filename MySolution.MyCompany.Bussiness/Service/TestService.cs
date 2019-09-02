using MySolution.MyCompany.Bussiness.Interface;
using MySolution.MyCompany.Bussiness.Util;
using MySolution.MyCompany.Repository.Base.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.MyCompany.Bussiness.Service
{
    public class TestService : ITestService
    {
        private IPersonRepository _personRepository;

        public TestService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public ServiceResponse<string> GetName()
        {
            var person = _personRepository.GetById(1);
            var test = new ServiceResponse<string>("my Name");

            test.ErrorCode = 123;
            test.ErrorMessage = "error message";
            return new ServiceResponse<string>(person.Name);
        }
    }
}
