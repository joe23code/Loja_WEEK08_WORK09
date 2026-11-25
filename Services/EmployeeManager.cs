using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WEEK08_WORK09.Services
{
    public  class EmployeeManager
    {
        private IEmployeeManager _repo;

        public EmployeeManager(IEmployeeManager repo)
        {
            _repo = repo;
        }
        public void AddEmployee(EmployeeManager e)
        {
            _repo.Save(e);
        }
        public Employee getEmployeeByID(int id)
        {
            return _repo.GetByID(id);
        }
        public List<Employee> GetAllEmployees()
        {
            return _repo.GetEmployeeList();
        }
        

    }
}
