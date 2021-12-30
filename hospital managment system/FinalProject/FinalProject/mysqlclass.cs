using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace FinalProject
{
    class mysqlclass
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;database=hospital_managment_system2;UID=root;password=;SslMode=none");
        MySqlCommand cmd;
        int i;
        //Acountants accountant;
        //Doctors doctor;
        //Nurses nurse;
        //Reception reception;
        //Manager manager;

        //connection
        public void openconnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void closeconnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //login
        
        public void delet_employee(string id, string s)
        {
            string slected = "";
            if (s == "National ID")
                slected = "national_id";
            else slected = "id";
            try
            {
                openconnection();
                cmd = new MySqlCommand("DELETE from employee  where " + slected + " = " + id, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("employee has deleted");

                }
                else
                {
                    MessageBox.Show("no employee with this " + slected);
                }

            }
            catch (Exception ex)
            {

            }

        }


        //employee
        public void add_emplyee(string name, string national_id, int age, string date_of_emplyee, double sallary, string gender, string address, string days_of_work, int num_of_days, string img, string departement, string phoone_number, int graduation_year)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into emplyee (name, national_id , age , date_of_emplyee , sallary , gender , address , days_of_work , num_of_days , img 	, departement , phoone_number , graduation_year) " +
                    "values (" + name + "," + national_id + "," + age + "," + date_of_emplyee + "," + sallary + "," + gender + "," + address + "," + days_of_work + "," + num_of_days + "," + img + "," + departement + "," + phoone_number + "," + graduation_year + ");", con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void search_employee_with_id(string id, DataGridView dgv, string s)
        {
            string slected = "";
            if (s == "National ID")
                slected = "national_id";
            else slected = "id";

            try
            {
                openconnection();
                cmd = new MySqlCommand("SELECT name,id,national_id,age,sallary,gender,specialize,address from employee where " + slected + " =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {

            }
        }
        public void loadimage(PictureBox pic)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dlg.Title = "Select Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picloc = dlg.FileName.ToString();
                pic.ImageLocation = picloc;
            }
        }


        //doctor
        public void serch_doc_dept(string s, DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,phone_number,national_id,specialize,sallary from employee where specialize =" + s, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {

            }
        }
        public void getcshields_of_doctors(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from schield_of_doctor", con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        
        //patient
        

        


        


        






        //new mysql commands
        public void addnewdoctor(string name, int age, string city, string country, string SSN, string gender, double sallary, int specialize_id, string days_of_work, int num_of_days_of_work, int Year_of_graduation, string date_of_employee, string img, string login_username,string mail,string phone)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into doctor (name, SSN , age , date_of_employee , sallary , gender , city ,country, days_of_work , num_of_days_of_work , img,email, specialize_id , phone_number , Year_of_graduation,login_username) " +
                    "values ('" + name + "','" + SSN+ "',"+ age + ",'" + date_of_employee + "'," + sallary + ",'" + gender + "','" + city + "','" + country + "','" + days_of_work + "'," + num_of_days_of_work + ",'" + img + "','" + mail + "'," + specialize_id + ",'" + phone +  "', " + Year_of_graduation +  ", '" + login_username + "');", con);
                cmd.ExecuteNonQuery();
                closeconnection();
               // addindoctormail(SSN, mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addnewnurse(string name, int age, string city, string country, string SSN, string gender, double sallary, int specialize_id, string days_of_work, int num_of_days_of_work, int Year_of_graduation, string date_of_employee, string img, string login_username, string mail, string phone)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into nurse (name, SSN , age , date_of_employee , sallary , gender , city ,country, days_of_work , num_of_days_of_work , img,email, specialize_id , phone_number , Year_of_graduation,login_username) " +
                    "values ('" + name + "','" + SSN + "'," + age + ",'" + date_of_employee + "'," + sallary + ",'" + gender + "','" + city + "','" + country + "','" + days_of_work + "'," + num_of_days_of_work + ",'" + img + "','" + mail + "'," + specialize_id + ",'" + phone + "', " + Year_of_graduation + ", '" + login_username + "');", con);
                cmd.ExecuteNonQuery();
                closeconnection();
                // addindoctormail(SSN, mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addnewemployee(string name, int age, string city, string country, string SSN, string gender, double sallary, int specialize_id, string days_of_work, int num_of_days_of_work, string date_of_employee, string img, string login_username,string mail,string phone_number, int employee_type_id)
        {
             

            try
            {
                
                openconnection();
                cmd = new MySqlCommand("insert into employee (name, SSN , age , date_of_employee , sallary , gender , country,city , days_of_work , num_of_days_of_work , img 	, employeetype_id , phone_number,login_username,email	 ) " +
                    "values ('" + name + "','" + SSN + "'," + age + ",'" + date_of_employee + "'," + sallary + ",'" + gender + "','" + country + "','" + city + "','" + days_of_work + "'," + num_of_days_of_work + ",'" +img + "',"+ employee_type_id+",'" + phone_number + "','"+ login_username + "','"+ mail + "');", con);
                cmd.ExecuteNonQuery();
                closeconnection();
                //addinemployeemail(SSN, mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string c="";
        public void getc(string c)
        {
            this.c = c;
        }

        public string returnc()
        {
            return c;
        }

        public void viewalldoctordata(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from doctor", con);
                MySqlCommand cmd1 = new MySqlCommand("select * from doctor", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void viewallnursesdata(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from Nurses", con);
                MySqlCommand cmd1 = new MySqlCommand("select * from nurse", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void viewallemployeedata(DataGridView dgv,int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from employee where employeetype_id= "+id, con);
                MySqlCommand cmd1 = new MySqlCommand("select * from employee where employeetype_id= " + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        //pharmacy
        public void allproducts_of_pharmacy(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from pharmacy", con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();

            }
            catch (Exception ex)
            {

            }
        }

        public void add_new_pharmacy_product(string name, int mount,DataGridView dgv)
        {
            try
            {
                openconnection();
                MySqlCommand cmd1 = new MySqlCommand("select * from pharmacy where name ='"+ name+"';", con);
                if (cmd1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("the product is exists");
                }
                else
                {
                    cmd = new MySqlCommand("insert into pharmacy(name , mount) values ('" + name + "'," + mount + ");", con);
                    cmd.ExecuteNonQuery();
                }
                
                closeconnection();
                allproducts_of_pharmacy(dgv);
            }
            catch (Exception ex)
            {

            }
        }

        public void add_an_exists_product(string name, int mount, DataGridView dgv)
        {
            try
            {
                openconnection();

                //cmd = new MySqlCommand("", con);
                MySqlCommand cmd1 = new MySqlCommand("select mount from pharmacy where name='" + name+"';", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable tabel1 = new DataTable();
                da.Fill(tabel1);
                int oldmount = Convert.ToInt32(tabel1.Rows[0][0].ToString());
                int newmount = oldmount + mount;
                cmd = new MySqlCommand("update pharmacy set mount=" + newmount + " where name='" + name+"';", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("mount is added");
                }
                else MessageBox.Show("something is wrong");
                da.Dispose();
                closeconnection();
                allproducts_of_pharmacy(dgv);
            }
            catch (Exception ex)
            {

            }
        }

        public void get_an_product(string name, int mount, DataGridView dgv)
        {
            try
            {
                openconnection();
                MySqlCommand cmd1 = new MySqlCommand("select mount from pharmacy where name='" + name + "';", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable tabel1 = new DataTable();
                da.Fill(tabel1);
                int oldmount = Convert.ToInt32(tabel1.Rows[0][0].ToString());
                int newmount = oldmount - mount;
                cmd = new MySqlCommand("update pharmacy set mount=" + newmount + " where name='" + name + "';", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("mount is removed");
                }
                else MessageBox.Show("something is wrong");
                da.Dispose();
                closeconnection();
                allproducts_of_pharmacy(dgv);
            }
            catch (Exception ex)
            {

            }
        }

        public void get_productsnames(ComboBox combo)
        {
            try
            {
                openconnection();
                combo.Items.Clear();
                cmd = new MySqlCommand("select name from pharmacy", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int count = table.Rows.Count;
                for(int i=0;i<count;i++)
                {
                    combo.Items.Add(table.Rows[i][0].ToString());
                }
                da.Dispose();
                closeconnection();

            }
            catch (Exception ex)
            {

            }
        }
        //end

        public void addinemployeemail(string national_id, string email)
        {
            int id = getemployeeid(national_id);
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into employee_mail values (" + id + "," + email + ");", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public int getemployeeid(string nationalid)
        {
            int id = 0;
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id from employee where SSN=" + nationalid, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                id = Convert.ToInt16(table.Rows[0][0].ToString());
                da.Dispose();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
            return id;
        }

        public void addindoctormail(string national_id, string email)
        {
            int id = getdoctorid(national_id);
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into doctor_mail values (" + id + "," + email + ");", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public int getdoctorid(string nationalid)
        {
            int id = 0;
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id from doctor where SSN=" + nationalid, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                id = Convert.ToInt16(table.Rows[0][0].ToString());
                da.Dispose();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
            return id;
        }
        public void addinnursemail(string national_id, string email)
        {
            int id = getnurseid(national_id);
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into nurse_mail values (" + id + "," + email + ");", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public int getnurseid(string nationalid)
        {
            int id = 0;
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id from nurse where SSN=" + nationalid, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                id = Convert.ToInt16(table.Rows[0][0].ToString());
                da.Dispose();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
            return id;
        }

        string update_or_add = "Add";
        public void set_update_or_add(string s)
        {
            this.update_or_add = s;
        }

        public string get_update_or_add()
        {
            return update_or_add;
        }

        public void updateemployee(string name, int age, string city, string country, string SSN, string gender, double sallary, string days_of_work, int num_of_days_of_work, string date_of_employee, string img, string login_username, string mail, int employee_type_id)
        {
            try
            {
                int id=getemployeeid(SSN);
                openconnection();
                cmd=new MySqlCommand("update employee set name=" + name + ", national_id=" + SSN + " , age=" + age + " , date_of_emplyee=" + date_of_employee + ", sallary=" + sallary + " , gender="+ gender + " , city="+ city + " , days_of_work="+ days_of_work + " , num_of_days="+ num_of_days_of_work + " , img="+ img + " , country="+ country + ",login_username="+ login_username + ",employee_type_id"+ employee_type_id +  " where empid=" +id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
                update_employee_email(mail, SSN);
            }
            catch(Exception ex)
            {

            }
        }

        public void update_doctor(string name, int age, string city, string country, string SSN, string gender, double sallary, int specialize_id, string days_of_work, int num_of_days_of_work, int Year_of_graduation, string date_of_employee, string img, string login_username, string mail)
        {
            try
            {
                int id = getdoctorid(SSN);
                openconnection();
                cmd = new MySqlCommand("update doctor set name=" + name + ", national_id=" + SSN + " , age=" + age + " , date_of_emplyee=" + date_of_employee + ", sallary=" + sallary + " , gender=" + gender + " , city=" + city + " , days_of_work=" + days_of_work + " , num_of_days=" + num_of_days_of_work + " , img=" + img + " , country=" + country + ",login_username=" + login_username + ",Year_of_graduation" + Year_of_graduation + ",specialize_id" + specialize_id + " where empid=" + id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
                update_doctor_email(mail, SSN);
            }
            catch (Exception ex)
            {

            }
        }

        public void update_nurse(string name, int age, string city, string country, string SSN, string gender, double sallary, int specialize_id, string days_of_work, int num_of_days_of_work, int Year_of_graduation, string date_of_employee, string img, string login_username, string mail)
        {
            try
            {
                int id = getnurseid(SSN);
                openconnection();
                cmd = new MySqlCommand("update nurse set name=" + name + ", national_id=" + SSN + " , age=" + age + " , date_of_emplyee=" + date_of_employee + ", sallary=" + sallary + " , gender=" + gender + " , city=" + city + " , days_of_work=" + days_of_work + " , num_of_days=" + num_of_days_of_work + " , img=" + img + " , country=" + country + ",login_username=" + login_username + ",Year_of_graduation" + Year_of_graduation + ",specialize_id" + specialize_id + " where empid=" + id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
                update_nurse_email(mail, SSN);
            }
            catch (Exception ex)
            {

            }
        }

        public void update_nurse_email(string mail, string SSN)
        {
            try
            {
                int nurse_id = getnurseid(SSN);
                openconnection();
                cmd = new MySqlCommand("update nurse_mail set email=" + mail + "where empid=" + nurse_id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void update_doctor_email(string mail, string SSN)
        {
            try
            {
                int doctor_id = getdoctorid(SSN);
                openconnection();
                cmd = new MySqlCommand("update doctor_mail set email=" + mail + "where empid=" + doctor_id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void update_employee_email(string mail, string SSN)
        {
            try
            {
                int employee_id = getemployeeid(SSN);
                openconnection();
                cmd = new MySqlCommand("update employee_mail set email=" + mail + "where emp_id=" + employee_id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void addnewlogin(string username,string password,string dept)
        {
            try
            {
                
                int employee_type_id = 0;
                if (dept == "Manager")
                    employee_type_id = 6;
                else if (dept == "Reception")
                    employee_type_id = 5;
                else if (dept == "Doctor")
                    employee_type_id = 2;
                else if (dept == "Nurses")
                    employee_type_id = 3;
                else if (dept == "Acountants")
                    employee_type_id = 1;
                else if (dept == "Pharmacy")
                    employee_type_id = 4;
                else
                {
                    MessageBox.Show("something is wrong" + dept);
                    employee_type_id = 0;
                    return;
                }
                openconnection();
                cmd = new MySqlCommand("insert into login (username,password,employee_type_id) values ('" + username + "','" + password + "'," + employee_type_id+");", con);
                cmd.ExecuteNonQuery();
                closeconnection();

            }
            catch(Exception ex)
            {

            }
        }

        private void login1(string username, string password, int dept_id, Form name_of_this_form)
        {
            i = 0;
            try
            {
                openconnection();
                cmd = new MySqlCommand("SELECT * from login where username='" + username + "' and password='" + password + "' and employee_type_id=" + dept_id, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                closeconnection();
                if (i == 0)
                {
                    MessageBox.Show("please enter an invalid user name or password ");
                }
                else
                {
                    Form from = null;
                    //name_of_this_form.Hide();
                    if (dept_id == 1)
                        from = new Acountants();
                    else if (dept_id == 2)
                        from = new Doctor();
                    else if (dept_id == 3)
                        from = new Doctor();
                    else if (dept_id == 4)
                        from = new Pharmacy();
                    else if (dept_id == 5)
                        from = new Receptions ();
                    else if (dept_id == 6)
                        from = new Manager();

                    else MessageBox.Show("something is wrong");
                    name_of_this_form.Hide();
                    from.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int dept_id = 0;
        public void login(string username, string password, string login, Form name_of_this_form)
        {

            
            if (login == "Reception")
                dept_id = 5;
            else if (login == "pharmacy")
                dept_id = 4;
            else if (login == "Doctor")
                dept_id = 2;
            else if (login == "Nurses")
                dept_id = 3;
            else if (login == "Acountants")
                dept_id = 1;
            else if (login == "Manager")
                dept_id = 6;
            else MessageBox.Show("something is wrong");
            login1(username, password, dept_id, name_of_this_form);


            
        }

        public void addnewpatient(string name,int  age,string  address,string SSN,string gender,string doc_name_of_elka4f,string phone_number,string state,string blood_type)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("INSERT INTO patient (name, age, address, SSN, gender, doc_name_of_elka4f, phone_number, state, blood_type) " +
                    "values ('" + name + "'," + age + ",'" + address + "','" + SSN + "','" + gender + "','" + doc_name_of_elka4f + "','" + phone_number + "','" + state + "','" + blood_type + "');", con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete_patient(string id, string s)
        {
            string slected = "";
            if (s == "National ID")
                slected = "SSN";
            else slected = "id";
            try
            {
                openconnection();
                cmd = new MySqlCommand("delete from patient where " + slected + " =" + id, con);
                if(cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Accept Operation", "Succsessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("error");
                closeconnection();

            }
            catch (Exception ex)
            {

            }
        }

        public void serch_patient(string id, string s)
        {
            string slected = "";
            if (s == "National ID")
                slected = "SSN";
            else slected = "id";

            try
            {
                openconnection();
                cmd = new MySqlCommand("SELECT id,name,age,address,SSN,gender,doc_name_of_elka4f,phone_number,state,blood_type from patient where " + slected + " =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();

                datagrid form = new datagrid();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        public void all_patients(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,address,SSN,gender,doc_name_of_elka4f,phone_number,state,blood_type from patient", con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {

            }
        }

        public void get_all_patient_details(string id, string s, DataGridView dgv)
        {
            string slected = "";
            if (s == "National ID")
                slected = "SSN";
            else slected = "id";
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from patient where "+ slected + "=" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                dgv.DataSource = table;

            }
            catch (Exception ex)
            {

            }
        }

        public void update_patient(string id, string s, string name, int age, string address, string SSN, string gender, string doc_name_of_elka4f, string phone_number, string state, string blood_type)
        {
            int o = 0;
            string slected = "";
            if (s == "National ID")
                slected = "SSN";
            else slected = "id";
            try
            {
                o = Convert.ToInt32(id);
                openconnection();
                //if (s == "National ID")
                    cmd = new MySqlCommand("update patient set name='" + name + "', age=" + age + ", address='" + address + "', SSN='" + SSN + "', gender='" + gender + "', doc_name_of_elka4f='" + doc_name_of_elka4f + "', phone_number='" + phone_number + "', state='" + state + "', blood_type='" + blood_type + "' where '" + slected + "'=" + o + ";", con);
                //else cmd = new MySqlCommand("update patient set name='" + name + "', age=" + age + ", address='" + address + "', SSN='" + SSN + "', gender='" + gender + "', doc_name_of_elka4f='" + doc_name_of_elka4f + "', phone_number='" + phone_number + "', state='" + state + "', blood_type='" + blood_type + "' where '" + slected + "'=" + Convert.ToInt32( id) + ";", con);

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("successful");
                else MessageBox.Show("noooooooooooooooooo");
                closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete_employee(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("DELETE FROM employee WHERE id=" + id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch(Exception ex)
            {

            }
        }

        public void delete_doctor(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("DELETE FROM doctor WHERE id=" + id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void delete_nurse(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("DELETE FROM nurse WHERE id=" + id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void editschield(DataGridView dgv,int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from doctor_schield where doctor_id="+id, con);
                MySqlCommand cmd1 = new MySqlCommand("select * from doctor_schield where doctor_id=" + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                DateTime Schield_date = DateTime.Parse(table1.Rows[0][7].ToString());
                DateTime date = DateTime.Now;
                date.ToString("YYYY-MM-dd");

                if(date>Schield_date)
                {
                    MySqlCommand cmd2 = new MySqlCommand("update doctor_schield set from9to10=0,from10to11=0,from11to12=0,from12to1=0,from1to2=0,from2to3=0,day_date='"+ date + "' where doctor_id=" + id, con);
                    cmd2.ExecuteNonQuery();
                    closeconnection();
                }





            }
            catch (Exception ex)
            {

            }
        }

        public void viewallemployee_withsection(string section,Form f)
        {
            int sectionid = 0;
            if (section == "الباطنة")
                sectionid = 1;
            else if (section == "النسا والتوليد")
                sectionid = 2;
            else if (section == "العظام")
                sectionid = 3;
            else if (section == "انف واذن وحنجره")
                sectionid = 4;
            else if (section == "عيون")
                sectionid = 5;
            else if (section == "الجراحه")
                sectionid = 6;
            else if (section == "الجلديه")
                sectionid = 7;
            else if (section == "مخ واعصاب")
                sectionid = 8;
            else sectionid = 0;
                try
            {
                openconnection();
                cmd = new MySqlCommand("select * from doctor where specialize_id=" + sectionid, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
               // f.Hide();
                datagrid d = new datagrid();
                d.dataGridView1.DataSource = table;
                d.ShowDialog();
               
                closeconnection();

            }
            catch(Exception ex)
            {

            }
        }

        public void docor_in_reception(int specialize_id,DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select name,id from doctor where specialize_id="+ specialize_id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();

            }
            catch(Exception ex)
            {

            }
        }
        public void docor_in_reception1(int specialize_id, ComboBox combo, DataGridView dgv)
        {
            try
            {
                openconnection();
                MySqlCommand cmd1 = new MySqlCommand("select name from doctor where specialize_id=" + specialize_id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable table1 = new DataTable();
                int i = table1.Rows.Count;
                for (int o = 0; o < i; o++)
                {
                    combo.Items.Add(table1.Rows[i++][0].ToString());
                }
                da.Dispose();
                closeconnection();

            }
            catch (Exception ex)
            {

            }
        }

        public void get_doctor_schield_with_name(int id,DataGridView dgv)
        {
            try
            {
                openconnection();
                MySqlCommand cmd1=new MySqlCommand("select * from doctor_schield where doctor_id=" + id, con);
                DataTable table1=new DataTable();
                table1.Load(cmd1.ExecuteReader());
                dgv.DataSource = table1;
                
                closeconnection();

            }
            catch(Exception ex)
            {

            }
        }

        public void set_an_appointment(string appointment,string doc_name,DataGridView dgv)
        {
            try
            {
                int doctor = Convert.ToInt32(doc_name);
                openconnection();
                
                MySqlCommand cmd1 = new MySqlCommand("update doctor_schield set " + appointment+"=1 where doctor_id="+doctor, con);
                cmd1.ExecuteNonQuery();
                
                MySqlCommand cmd2 = new MySqlCommand("select * from doctor_schield where doctor_id=" + doctor, con);
                DataTable table1 = new DataTable();
                table1.Load(cmd2.ExecuteReader());
                dgv.DataSource = table1;
                closeconnection();

            }
            catch(Exception ex)
            {

            }
        }

        public void get_patient_few_details(string id,string s,TextBox txtname, TextBox txtage, TextBox txtaddress, TextBox txtSSN,RadioButton radmale,TextBox doc_of, TextBox txtphonenumber, TextBox txtstate,ComboBox combo_blood_type)
        {
            string slected = "";
            if (s == "National ID")
                slected = "SSN";
            else slected = "id";
            try
            {
                openconnection();
                cmd = new MySqlCommand("select name, age,address,SSN,gender,doc_name_of_elka4f,phone_number,state,blood_type from patient where " + slected + "=" + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                string name = table.Rows[0][0].ToString();
                string age  = table.Rows[0][1].ToString();
                string address = table.Rows[0][2].ToString();
                string SSN = table.Rows[0][3].ToString();
                string gender = table.Rows[0][4].ToString();
                string doc_name_of_elka4f = table.Rows[0][5].ToString();
                string phone_number = table.Rows[0][6].ToString();
                string state = table.Rows[0][7].ToString();
                string blood_type = table.Rows[0][8].ToString();
                txtname.Text = name;
                txtage.Text = age;
                txtaddress.Text = address;
                txtSSN.Text = SSN;
                txtphonenumber.Text = phone_number;
                txtstate.Text = state;
                if(gender=="male")
                {
                    radmale.Checked = true;
                }
                doc_of.Text = doc_name_of_elka4f;
                combo_blood_type.Text = blood_type;
                da.Dispose();
                closeconnection();
                

            }
            catch (Exception ex)
            {

            }
        }

        //rooms
        public void reserve_room(int patient_id, int room_id, string date_of_reserve)
        {
            try
            {
                
                openconnection();
                cmd = new MySqlCommand("update patient set room_id=" + room_id + ",date_of_reserve='" + date_of_reserve+"', reserved =1 where id="+patient_id, con);
                cmd.ExecuteNonQuery();
                closeconnection();
                reserve_room1(room_id);
            }
            catch (Exception ex)
            {

            }
        }
        public void reserve_room1(int room_id)
        {
            try
            {
                openconnection();
                MySqlCommand cmd1 = new MySqlCommand("select available_beds from room where id = " + room_id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                DataTable table = new DataTable();
                da.Fill(table);
                int av = Convert.ToInt32(table.Rows[0][0].ToString());
                av--;
                da.Dispose();
                closeconnection();
                reserve_room2(av, room_id);

            }
            catch(Exception ex)
            {

            }
        }
        public void reserve_room2(int av,int room_id)
        {
            try
            {
                openconnection();
                MySqlCommand cmd2 = new MySqlCommand("update room set available_rooms = " + av + " where id = " + room_id, con);
                cmd2.ExecuteNonQuery();
                closeconnection();
            }
            
            catch(Exception ex)
            {

            }
}

        public void addroom(int num_of_beds, int availables_beds, int dept_id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("insert into rooms (num_of_beds,availables_beds,dept_id) values (" + num_of_beds + "," + availables_beds + "," + dept_id + ");", con);
                cmd.ExecuteNonQuery();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void updateroom(int id, int num_of_beds, int available_beds, int dept_id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("update rooms set num_of_beds=" + num_of_beds + ", available_beds=" + available_beds + ", dept_id = " + dept_id + "where room_id=" + id, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("updated");
                }
                else MessageBox.Show("something is wrong");
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void delete_room(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("delete from rooms where id=" + id, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("deleted");
                }
                else MessageBox.Show("something is wrong");
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void all_rooms(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select * from room", con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }


        public void insert_rooms_ids(ComboBox combo)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("SELECT id from room where available_beds>0", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                int count = table.Rows.Count;
                for(int i=0;i<count;i++)
                {
                    combo.Items.Add(table.Rows[i][0]);
                }
                da.Dispose();
                closeconnection();
            }
            catch(Exception ex)
            {

            }
        }

        public void get_patient_few_details_for_reserve(string id, string s, Label lblname, Label lblphone, Label lblblood_type, Label lbltxtSSN, Label lbldoc_name_of_elka4f)
        {
            string slected = "";
            if (s == "National ID")
                slected = "SSN";
            else slected = "id";
            try
            {
                openconnection();
                cmd = new MySqlCommand("select name, SSN,phone_number,blood_type,doc_name_of_elka4f from patient where " + slected + "=" + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                string name = table.Rows[0][0].ToString();
                string SSN = table.Rows[0][1].ToString();
                string phone_number = table.Rows[0][2].ToString();
                string blood_type = table.Rows[0][3].ToString();
                string doc_name_of_elka4f = table.Rows[0][4].ToString();

                lblname.Text = name;
                lblphone.Text = phone_number;
                lbltxtSSN.Text = SSN;
                lblblood_type.Text = blood_type;
                lbldoc_name_of_elka4f.Text = doc_name_of_elka4f;

                da.Dispose();
                closeconnection();


            }
            catch (Exception ex)
            {

            }
        }

        public void get_employee_few_data(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,country,city,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username,employeetype_id from employee where id =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                datagrid form = new datagrid();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                //dgv.DataSource = table;
                closeconnection();
            }
            catch(Exception ex)
            {

            }
        }
        public void get_doc_few_data(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from doctor where id=" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                //dgv.DataSource = table;
                //dgv.DataSource = table;
                datagrid form = new datagrid();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void get_nurse_few_data(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from nurse where id =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                datagrid form = new datagrid();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        //public void viewdoctordata(int id)
        //{
        //    try
        //    {
        //        openconnection();
        //        cmd = new MySqlCommand("select * from doctor where id= "+id, con);
        //        MySqlCommand cmd1 = new MySqlCommand("select * from doctor", con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
        //        DataTable table = new DataTable();
        //        DataTable table1 = new DataTable();
        //        da.Fill(table1);
        //        table.Load(cmd.ExecuteReader());
                
        //        closeconnection();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void viewnursedata(int id)
        //{
        //    try
        //    {
        //        openconnection();
        //        cmd = new MySqlCommand("select * from Nurses where id= "+id, con);
        //        MySqlCommand cmd1 = new MySqlCommand("select * from nurse", con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
        //        DataTable table = new DataTable();
        //        DataTable table1 = new DataTable();
        //        da.Fill(table1);
        //        table.Load(cmd.ExecuteReader());
                
        //        closeconnection();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void viewemployeedata(int id,int empid)
        //{
        //    try
        //    {
        //        openconnection();
                
        //        MySqlCommand cmd1 = new MySqlCommand("select * from employee where employeetype_id= " + id, con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                
        //        DataTable table1 = new DataTable();
        //        da.Fill(table1);
                
        //        employee_details em = new employee_details();

                
        //        closeconnection();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        public void viewdoctordata(int id)
        {
            try
            {
                openconnection();

                MySqlCommand cmd1 = new MySqlCommand("select * from doctor where id= " + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                employee_details ll = new employee_details();
                ll.Show();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                int idd = Convert.ToInt32(table1.Rows[0][0].ToString());
                string name = table1.Rows[0][1].ToString();
                int age = Convert.ToInt32(table1.Rows[0][2].ToString());
                string ssn = table1.Rows[0][5].ToString();
                string country = table1.Rows[0][4].ToString();
                string city = table1.Rows[0][3].ToString();
                string phone = table1.Rows[0][6].ToString();
                string email = table1.Rows[0][7].ToString();
                string gender = table1.Rows[0][8].ToString();
                string sallary = table1.Rows[0][9].ToString();
                int specialize_id = Convert.ToInt32(table1.Rows[0][10].ToString());
                string days_of_work = table1.Rows[0][11].ToString();
                string year_of_graduation = table1.Rows[0][13].ToString();
                string date_of_employee = table1.Rows[0][14].ToString();
                //string img = table1.Rows[0][12].ToString();
                byte[] iimg = (byte[])table1.Rows[0][15];
                MemoryStream ms = new MemoryStream(iimg);
                int employeetype_id = Convert.ToInt32(table1.Rows[0][16].ToString());
                employee_details em = new employee_details();
                string address = country + " , " + city;
                em.lblname.Text = name;
                em.lblphone.Text = phone;
                em.lblage.Text = age + "";
                em.lblemail.Text = email;
                em.lblid.Text = idd + "";
                em.lblssn.Text = ssn;
                em.lbladdress.Text = address;
                em.lblgender.Text = gender;
                em.lblsallary.Text = sallary;
                em.lblworkdays.Text = days_of_work;
                em.lblemployeedate.Text = date_of_employee;
                em.lblspecialize.Text = specialize_id + "";
                em.lblgraduationyear.Text = year_of_graduation;
                em.lblemployeetype.Text = employeetype_id + "";
                em.img.Image = Image.FromStream(ms);
                da.Dispose();





                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }


        public void viewnursedata(int id)
        {
            try
            {
                openconnection();

                MySqlCommand cmd1 = new MySqlCommand("select * from nurse where id= " + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                employee_details em = new employee_details();
                em.Show();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                int idd = Convert.ToInt32(table1.Rows[0][0].ToString());
                string name = table1.Rows[0][1].ToString();
                int age = Convert.ToInt32(table1.Rows[0][2].ToString());
                string ssn = table1.Rows[0][5].ToString();
                string country = table1.Rows[0][4].ToString();
                string city = table1.Rows[0][3].ToString();
                string phone = table1.Rows[0][6].ToString();
                string email = table1.Rows[0][7].ToString();
                string gender = table1.Rows[0][8].ToString();
                string sallary = table1.Rows[0][9].ToString();
                int specialize_id = Convert.ToInt32(table1.Rows[0][10].ToString());
                string days_of_work = table1.Rows[0][11].ToString();
                string year_of_graduation = table1.Rows[0][13].ToString();
                string date_of_employee = table1.Rows[0][14].ToString();
                //string img = table1.Rows[0][12].ToString();
                byte[] iimg = (byte[])table1.Rows[0][15];
                MemoryStream ms = new MemoryStream(iimg);
                int employeetype_id = Convert.ToInt32(table1.Rows[0][16].ToString());
                //employee_details em = new employee_details();
                string address = country + " , " + city;
                em.lblname.Text = name;
                em.lblphone.Text = phone;
                em.lblage.Text = age + "";
                em.lblemail.Text = email;
                em.lblid.Text = idd + "";
                em.lblssn.Text = ssn;
                em.lbladdress.Text = address;
                em.lblgender.Text = gender;
                em.lblsallary.Text = sallary;
                em.lblworkdays.Text = days_of_work;
                em.lblemployeedate.Text = date_of_employee;
                em.lblspecialize.Text = specialize_id + "";
                em.lblgraduationyear.Text = year_of_graduation;
                em.lblemployeetype.Text = employeetype_id + "";
                em.img.Image = Image.FromStream(ms);
                da.Dispose();





                closeconnection();
            }
            catch (Exception ex)
            {

            }

        }


        public void viewemployeedata(int id, int empid)
        {
            try
            {
                openconnection();

                MySqlCommand cmd1 = new MySqlCommand("select * from employee where id= " + id + "and employeetype_id=" + empid, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                employee_details ll = new employee_details();
                ll.Show();
                DataTable table1 = new DataTable();
                da.Fill(table1);
                int idd = Convert.ToInt32(table1.Rows[0][0].ToString());
                string name = table1.Rows[0][1].ToString();
                int age = Convert.ToInt32(table1.Rows[0][2].ToString());
                string ssn = table1.Rows[0][3].ToString();
                string country = table1.Rows[0][4].ToString();
                string city = table1.Rows[0][5].ToString();
                string phone = table1.Rows[0][5].ToString();
                string email = table1.Rows[0][6].ToString();
                string gender = table1.Rows[0][7].ToString();
                string sallary = table1.Rows[0][8].ToString();
                string days_of_work = table1.Rows[0][9].ToString();
                string date_of_employee = table1.Rows[0][11].ToString();
                //string img = table1.Rows[0][12].ToString();
                byte[] iimg = (byte[])table1.Rows[0][12];
                MemoryStream ms = new MemoryStream(iimg);
                int employeetype_id = Convert.ToInt32(table1.Rows[0][15].ToString());
                employee_details em = new employee_details();
                string address = country + " , " + city;
                em.lblname.Text = name;
                em.lblphone.Text = phone;
                em.lblage.Text = age + "";
                em.lblemail.Text = email;
                em.lblid.Text = idd + "";
                em.lblssn.Text = ssn;
                em.lbladdress.Text = address;
                em.lblgender.Text = gender;
                em.lblsallary.Text = sallary;
                em.lblworkdays.Text = days_of_work;
                em.lblemployeedate.Text = date_of_employee;

                em.lblemployeetype.Text = employeetype_id + "";
                em.img.Image = Image.FromStream(ms);
                da.Dispose();





                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void viewemployee(int id, DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name, SSN , age , date_of_employee , sallary , gender , country,city , num_of_days_of_work, employeetype_id , phone_number,login_username,email from employee where employeetype_id =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void viewdoctor( DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from doctor; ", con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void viewnurse(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from nurse;", con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }


        public void get_employee_few_datafordelete(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,country,city,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username,employeetype_id from employee where id =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                DeleteMember form = new DeleteMember();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                //dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void get_doc_few_datafordelete(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from doctor where id=" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                //dgv.DataSource = table;
                //dgv.DataSource = table;
                DeleteMember form = new DeleteMember();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void get_nurse_few_datafordelete(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from nurse where id =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                DeleteMember form = new DeleteMember();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void get_employee_few_dataforupdate(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select name, SSN , age , date_of_employee , sallary , gender , country,city , days_of_work , num_of_days_of_work , img 	, employeetype_id , phone_number,email from employee where id =" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                datagrid form = new datagrid();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                //dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void get_doc_few_dataforupdate(int id)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select name, SSN , age , date_of_employee , sallary , gender , city ,country, days_of_work , num_of_days_of_work , img,email, specialize_id , phone_number , Year_of_graduation from doctor where id=" + id, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                closeconnection();
                //dgv.DataSource = table;
                //dgv.DataSource = table;
                datagrid form = new datagrid();
                form.dataGridView1.DataSource = table;
                form.ShowDialog();
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void get_nurse_few_dataforupdate(int id,TextBox txtname, TextBox txtSSN , TextBox txtage , TextBox txtsallary ,RadioButton male, TextBox txtcity , TextBox txtcountry, PictureBox  iimg, TextBox txtemail, ComboBox combospecialize_id , TextBox txtphone_number , ComboBox comboYear_of_graduation) 
        {
            try
            {
                //AddMember add = new AddMember();
                //add.ShowDialog();
                openconnection();
                cmd = new MySqlCommand("select name, SSN , age , date_of_employee , sallary , gender , city ,country , img,email, specialize_id , phone_number , Year_of_graduation from nurse where id =" + id, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                string name = table.Rows[0][0].ToString();
                string SSN = table.Rows[0][1].ToString();
                string age = table.Rows[0][2].ToString();
                string date_of_employee = table.Rows[0][3].ToString();
                string sallary = table.Rows[0][4].ToString();
                string gender = table.Rows[0][5].ToString();
                string city = table.Rows[0][6].ToString();
                string country = table.Rows[0][7].ToString();
                
                byte[] img =(byte[]) table.Rows[0][8];
                MemoryStream ms = new MemoryStream(img);
                iimg.Image = Image.FromStream(ms);
                string email = table.Rows[0][10].ToString();
                string specialize_id = table.Rows[0][11].ToString();
                string phone_number = table.Rows[0][12].ToString();
                string Year_of_graduation = table.Rows[0][13].ToString();

                MessageBox.Show("anme " + name);
                txtname.Text = name;
                txtSSN.Text = SSN;
                txtage.Text = age;


                txtsallary.Text = sallary;
                if (gender == "Male")
                    male.Checked = true;
                else male.Checked = false;

               txtcity.Text = city;
                txtcountry.Text = country;
                
               txtemail.Text = email;

                combospecialize_id.Text = specialize_id;
                txtphone_number.Text = phone_number;
                comboYear_of_graduation.Text = Year_of_graduation;

                
                da.Dispose();
                
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void viewemployeeforaccount(int id, DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name, SSN , age , date_of_employee , sallary , gender , country,city , num_of_days_of_work, employeetype_id , phone_number,login_username,email from employee where employeetype_id =" + id+" and takedsallary="+0, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void viewdoctorforaccount(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from doctor where takedsallary=" + 0, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
        public void viewnurseforaccount(DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id,name,age,SSN,city,country,phone_number,email,gender,sallary,days_of_work,date_of_employee,login_username from nurse where takedsallary=" + 0, con);
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgv.DataSource = table;
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }

        public void updatesallary(int employeetype,int id)
        {
            try
            {
                openconnection();
                if (employeetype == 1 || employeetype == 4 || employeetype == 5 || employeetype == 6)
                    cmd = new MySqlCommand("update employee set takedsallary=1 where id=" + id, con);
                else if (employeetype == 2)
                {
                    cmd = new MySqlCommand("update doctor set takedsallary=1 where id=" + id, con);
                    MessageBox.Show("Successful operation", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else if (employeetype == 3)
                {
                    MessageBox.Show("Successful operation", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    cmd = new MySqlCommand("update nurse set takedsallary=1 where id=" + id, con);
                }
                   
                else MessageBox.Show("someyhing is wrong while updating");
                cmd.ExecuteNonQuery();
                closeconnection();

            }
            catch(Exception ex)
            {

            }
        }

        public void getsallary(int employeetype, int id,Label lb)
        {
            try
            {
                openconnection();
                if (employeetype == 1 || employeetype == 4 || employeetype == 5 || employeetype == 6)
                    cmd = new MySqlCommand("select sallary from employee where id=" + id, con);
                else if (employeetype == 2)
                    cmd = new MySqlCommand("select sallary from doctor where id=" + id, con);
                else if (employeetype == 3)
                    cmd = new MySqlCommand("select sallary from nurse where id=" + id, con);
                else MessageBox.Show("someyhing is wrong while getting sallary");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                string sallary = table.Rows[0][0].ToString();
                lb.Text = sallary;
                da.Dispose();
                closeconnection();

            }
            catch (Exception ex)
            {

            }
        }

        public void get_doc_Schield(string user,DataGridView dgv)
        {
            try
            {
                openconnection();
                cmd = new MySqlCommand("select id from doctor where login_username = '" + user+"';", con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable table = new DataTable();
                da.Fill(table);
                int id = Convert.ToInt32(table.Rows[0][0].ToString());
                da.Dispose();
                closeconnection();
                get_doc_Schield1(id, dgv);
            }
            catch(Exception ex)
            {

            }
        }

        public void get_doc_Schield1(int id, DataGridView dgv)
        {
            try
            {
                openconnection();
                MySqlCommand cmd2 = new MySqlCommand("select * from patient where doc_name_of_elka4f ='" + id + "';", con);
                DataTable table1 = new DataTable();
                table1.Load(cmd2.ExecuteReader());
                dgv.DataSource = table1;
                
                closeconnection();
            }
            catch (Exception ex)
            {

            }
        }
    }
}


