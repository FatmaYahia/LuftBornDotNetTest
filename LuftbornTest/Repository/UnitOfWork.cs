using DAL;
using Repository.AppRepository;
using Repository.AuthRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork
    {
        private readonly DataContext DB;
        public UnitOfWork(DataContext DB)
        {
            this.DB = DB;
        }
        public SystemUserRepository systemUserRepository => new SystemUserRepository(DB);
        public DepartmentRepository DepartmentRepository => new DepartmentRepository(DB);
        public EmployeeRepository EmployeeRepository => new EmployeeRepository(DB);
        public GenderRepository GenderRepository => new GenderRepository(DB);

    }
}
