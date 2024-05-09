using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace last_task
{
    public partial class Form1 : Form
    {
       static public event EventHandler<string> department_changed;
       static public event EventHandler<int> employee_changed;
        public Form1()
        {
            InitializeComponent();

            departmentsComboBox.ValueMember = "name";   // value member should be dep_num here
            departmentsComboBox.DisplayMember = "name";
            departmentsComboBox.DataSource = BusinessLogicLayer.get_departments();


            emp_list.ValueMember = "SSN";   // being here before data source solve that problem >> when give d.s compiler start filling the data >> index change >> fire event >> try to send selected value as int but u didnot tell him that the value member is ssn till now so it see it as obj and cannot cast  "this problem happen if this line is written after data source line" 
            emp_list.DisplayMember = "name";
            emp_list.DataSource = BusinessLogicLayer.get_employees(BusinessLogicLayer.get_departments().First().name);
          


            departments_combo2.DisplayMember = "name";      // display and value members always should be assigned before data source
            departments_combo2.ValueMember = "name";     // value member should be dep_num here
            departments_combo2.DataSource = BusinessLogicLayer.get_departments();
           

            name_txt_box.Text = BusinessLogicLayer.get_employees(BusinessLogicLayer.get_departments().First().name).First().name;
            address_txt_box.Text = BusinessLogicLayer.get_employees(BusinessLogicLayer.get_departments().First().name).First().address;
            birth_date_box.Value = BusinessLogicLayer.get_employees(BusinessLogicLayer.get_departments().First().name).First().birth_date;
            salary_box.Value = BusinessLogicLayer.get_employees(BusinessLogicLayer.get_departments().First().name).First().salary;   // right to make max prop of this btn huge num or we have a way to make it unlimited????? no problem
            ssn_box.Value = BusinessLogicLayer.get_employees(BusinessLogicLayer.get_departments().First().name).First().SSN;
            department_changed += update_emp_list_data_source;
            employee_changed += update_emp_data;

        }

        private void update_emp_list_data_source(object sender , string dept_name)
        {
            emp_list.DataSource = BusinessLogicLayer.get_employees(dept_name);
        }

        private void update_emp_data(object sender, int emp_ssn)
        {
            Employee emp = BusinessLogicLayer.get_emp_data(emp_ssn ,(string)departmentsComboBox.SelectedValue);
            name_txt_box.Text = emp.name;
            birth_date_box.Value = emp.birth_date;
            address_txt_box.Text = emp.address;
            salary_box.Value = emp.salary;
            ssn_box.Value = emp.SSN;
            departments_combo2.Text = DataAccessLayer.get_dept_name(emp.department_num);       // right to call data access layer here?????????
        }

        private void departmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(department_changed!=null)
            department_changed(this, departmentsComboBox.Text);
        }

        private void emp_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(employee_changed!=null)  // always check 
            employee_changed(this , (int)emp_list.SelectedValue);  
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee{ SSN = (int)emp_list.SelectedValue , name = name_txt_box.Text , birth_date = birth_date_box.Value , address = address_txt_box.Text , salary = salary_box.Value  , department_num = DataAccessLayer.get_dept_num(departments_combo2.Text) };
            DataAccessLayer.update_emp(emp);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee { SSN = (int)ssn_box.Value, name = name_txt_box.Text, birth_date = birth_date_box.Value, address = address_txt_box.Text, salary = salary_box.Value, department_num = DataAccessLayer.get_dept_num(departments_combo2.Text) };
            DataAccessLayer.add_emp(emp);
            add_btn.Enabled = false;
        }

        private void ssn_box_ValueChanged(object sender, EventArgs e)
        {
           List<int> SSNs = DataAccessLayer.get_SSNs();
            if(!SSNs.Contains((int)ssn_box.Value))
                add_btn.Enabled = true;
            else
                add_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer.delete_emp((int)emp_list.SelectedValue);
        }
    }
}
