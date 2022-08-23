using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject_CrudBlazor.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get All Employee

        public List<Employeeinfo> GetEmployee()
        {
            System.Threading.Thread.Sleep(5000);
            var data = _db.Employees.ToList();

            return data;
        }

        public string Create(Employeeinfo emp)
        {
            _db.Employees.Add(emp);
            _db.SaveChanges();
            return "Save Successfully";
        }

        //Get Employee By Id

        public Employeeinfo GetEmployeeById(int id)
        {
            Employeeinfo emp = _db.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();

            return emp;
        }

        //Update Employee Info

        public string UpdateEmployee(Employeeinfo emp)
        {
            _db.Employees.Update(emp);
            _db.SaveChanges();

            return "Update Successfully";
        }

        //Delete EMployee

        public string DeleteEmployee(Employeeinfo emp)
        {
            _db.Remove(emp);
            _db.SaveChanges();
            return "Data Deleted Sucessfully";
        }
    }
}
