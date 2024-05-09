using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last_task
{
    internal class DataAccessLayer
    {
       static SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True;");
       static SqlCommand cmd = new SqlCommand();



      static public DataTable GetDepartments()
        {
            cmd.Connection = connection;
            cmd.CommandText = "select * from Departments";
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable; 
        }

        static public DataTable GetEmployees(string dept_name)
        {
            cmd.Connection = connection;
            cmd.CommandText = $"select Fname , Lname , Bdate , Address , salary , SSN , Dno from Employee e inner join Departments d on e.Dno = d.Dnum and Dname = '{dept_name}'";
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        static public void update_emp(Employee emp)
        {
            string[] name = emp.name.Split(' ');
            cmd.Connection = connection;
            cmd.CommandText = $"update Employee set Fname = '{name[0]}' , Lname = '{name[1]}' , Bdate = '{emp.birth_date}' " +
                $", Address = '{emp.address}' , Salary = {emp.salary} , Dno = {emp.department_num} where SSN = {emp.SSN}";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        static public string get_dept_name(int dept_num)
        {
            cmd.Connection = connection;
            cmd.CommandText = $"select dname from Departments where dnum ={dept_num}";
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string dept_name = "";
            if (reader.Read())
            {
               dept_name  = (string)reader["dname"];
            }
            connection.Close();
            return dept_name;
        }


        static public int get_dept_num(string dept_name)
        {
            cmd.Connection = connection;
            cmd.CommandText = $"select dnum from Departments where dname ='{dept_name}'";
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int dept_num = 0;
            if (reader.Read())
            {
                dept_num = (int)reader["dnum"];
            }
            connection.Close();
            return dept_num;
        }


        static public List<int> get_SSNs()
        {
            List<int> SSNs = new List<int>();
            cmd.Connection = connection;
            cmd.CommandText ="select SSN from employee";
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SSNs.Add((int)reader["SSN"]);
            }
            connection.Close();
            return SSNs;
        }


        static public void add_emp(Employee emp)
        {
            cmd.Connection = connection;

            if (emp.name.Contains(' '))
            {
                string[] name = emp.name.Split(' ');
                cmd.CommandText = $" insert into Employee  (Fname , Lname , SSN , Bdate , Address , Salary , Dno ) values ( '{name[0]}' , '{name[1]}' , {emp.SSN} , '{emp.birth_date}' , '{emp.address}' , {emp.salary} , {emp.department_num})";
            }
            else
                cmd.CommandText = $" insert into Employee  (Fname , SSN , Bdate , Address , Salary , Dno ) values ( '{emp.name}' , {emp.SSN} , '{emp.birth_date}' , '{emp.address}' , {emp.salary} , {emp.department_num})";

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        static public void delete_emp(int emp_ssn)
        {
            cmd.Connection = connection;
            cmd.CommandText = $"delete from Employee where ssn = {emp_ssn}";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
