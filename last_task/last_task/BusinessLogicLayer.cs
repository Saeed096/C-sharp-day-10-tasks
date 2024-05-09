using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last_task
{
    internal class BusinessLogicLayer
    { 
        static public List<Department> get_departments()
        {
            List<Department> dep_list = new List<Department>();
           DataTable dt = DataAccessLayer.GetDepartments();
            foreach(DataRow dr in dt.Rows) 
            {
              Department department = new Department();
                department.name = dr["Dname"].ToString();
                department.Dnum = (int)dr["Dnum"];
                department.MGRSSN = (int)dr["MGRSSN"];
                department.MGRStartDate = (dr["MGRStart Date"] as DateTime?)?? DateTime.Now; 
                dep_list.Add(department);
            }
            return dep_list;
        }


        static public List<Employee> get_employees(string dept_name)
        {
            List<Employee> emp_list = new List<Employee>();
            DataTable dt = DataAccessLayer.GetEmployees(dept_name);

            foreach(DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.name = dr["Fname"].ToString() + " " + dr["Lname"].ToString();
                employee.birth_date = (dr["Bdate"]as DateTime?)?? DateTime.Now;   // right logic?????
                employee.address = (dr["Address"]as string)?? "cairo";   // must as >> when to string doesnot work??????
                employee.salary = (int)dr["salary"];            
                employee.SSN = (int)dr["SSN"];
                employee.department_num = (int)dr["Dno"];
                emp_list.Add(employee);
            }
            return emp_list;
        }

        static public Employee get_emp_data(int emp_ssn , string dept_name)
        {
           List<Employee> emp_list = get_employees(dept_name);
            foreach(Employee employee in emp_list) 
            {
             if(employee.SSN == emp_ssn)
                    return employee;
            }
            return null;            // right to fill all paths return emp??????
        }
        

    }
}
