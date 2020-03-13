using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ds_project;
namespace Ds_project
{
    public class Load_Data
    {
        string sconnect = "Data Source=DESKTOP-T7ORQ8E\\SQLEXPRESS;Initial Catalog=eCommerce;Integrated Security=True";
        public void Loaduserdata(ref LinkedList<user> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd = new SqlCommand("select * from [user]", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user tmp = new user();
                    tmp.id = (int)reader["user_id"];
                    tmp.name = (string)reader["name"];
                    
                    tmp.password = (string)reader["password"];
                    tmp.phone = (string)reader["phone"];

                    tmp.gender = (string)reader["gender"];
                    tmp.mail = (string)reader["email"];
                    tmp.adress = (string)reader["address"];
                    tmp.status = (bool)reader["status"];
                    arr.AddLast(tmp);


                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadsectiondata(ref LinkedList<section> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd = new SqlCommand("select * from [section]", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    section tmp = new section();
                    tmp.id = (int)reader["section_id"];
                    tmp.name = (string)reader["section_name"];
                    tmp.description = (string)reader["section_category"];
                    try
                    {
                        tmp.image =(byte[]) reader["section_image"];
                    }
                    catch
                    {
                        tmp.image = null;
                        
                    }
                    arr.AddLast(tmp);

                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loaditems(ref LinkedList<Brand> arr, ref int  max_id)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            for (int i = 0; i < arr.Count; i++)
            {
               
                SqlCommand cmd = new SqlCommand("select * from item where brand_id= " + arr.ElementAt(i).id, connect);
                try
                {
                    connect.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Items tmp = new Items();
                        tmp.id = (int)reader["item_id"];
                        if (tmp.id > max_id)
                            max_id = tmp.id;
                        tmp.name = (string)reader["name"];
                        tmp.section_id = (int)reader["section_id"];
                       
                        tmp.amount = (int)reader["amount"];
                        tmp.brand_id = arr.ElementAt(i).id;
                        tmp.description = (string)reader["description"];
                        tmp.color = (string)reader["color"];
                        tmp.price = (int)reader["price"];
                        try
                        {
                            tmp.image = (byte[])reader["picture"];
                        }
                        catch
                        {
                            tmp.image = null;
                        }
                       arr.ElementAt(i).itemlist.Add(tmp);


                    }
                    reader.Close();
                    connect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 
        public void loadbranddata(ref LinkedList<Brand> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd = new SqlCommand("select * from brand", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Brand tmp = new Brand();
                    tmp.id = (int)reader["id"];
                    tmp.name = (string)reader["brand_name"];
                    tmp.country = (string)reader["country"];
                    tmp.category = (string)reader["category"];
                    tmp.phone = (string)reader["phone"];
                    tmp.mail = (string)reader["mail"];
                    try
                    {
                        tmp.image = (byte[])reader["picture"];
                    }
                    catch
                    {
                        tmp.image = null;
                    }
                    arr.AddLast(tmp);
                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void loadrequestdata(ref LinkedList<request> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd = new SqlCommand("select * from request",connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    request req = new request();
                    req.id = (int)reader["id"];
                    req.user_id = (int)reader["user_id"];
                    req.item_id = (int)reader["item_id"];
                    req.amount = (int)reader["amount"];
                    req.status = (string)reader["status"];
                    arr.AddLast(req);
                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        public void loadfeedbackdata(ref LinkedList<feedback> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd = new SqlCommand("select * from feedback", connect);
                try
                {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    feedback fback = new feedback();
                    fback.id = (int)reader["id"];
                    fback.user_id = (int)reader["user_id"];
                    fback.status = (string)reader["status"];
                    fback.feedbacktext = (string)reader["feedback"];
                    arr.AddLast(fback);
                }
                reader.Close();
                connect.Close();
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }
        public void returnuserdata(ref LinkedList<user> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd1 = new SqlCommand("delete from [user]",connect);
            try
            {
                connect.Open();
                cmd1.ExecuteNonQuery();
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for(int i = 0; i < arr.Count; i++)
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("insert into [user](user_id,[name],[password],gender,phone,email,address,status)  values ('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).name + "','" + arr.ElementAt(i).password + "','" + arr.ElementAt(i).gender + "','" + arr.ElementAt(i).phone + "','" + arr.ElementAt(i).mail + "','" + arr.ElementAt(i).adress + "','"+arr.ElementAt(i).status+"')", connect);
                    connect.Open();
                    cmd2.ExecuteNonQuery();
                    connect.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        public void returnitemdata(ref LinkedList<Brand> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd1 = new SqlCommand("delete from item where 1=1", connect);
            try
            {
                connect.Open();
                cmd1.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < arr.Count; i++)
            {
                SqlCommand cmd2;
                for(int j = 0; j < arr.ElementAt(i).itemlist.Count; j++)
                {
                    if (arr.ElementAt(i).itemlist[j].image != null)
                    {
                        cmd2 = new SqlCommand("insert into item (item_id,name,picture,section_id,color,amount,description,brand_id,price) values ('"+ arr.ElementAt(i).itemlist[j].id+ "','"+ arr.ElementAt(i).itemlist[j].name+ "',@IMG,'"+ arr.ElementAt(i).itemlist[j].section_id+ "','"+ arr.ElementAt(i).itemlist[j].color+ "','"+ arr.ElementAt(i).itemlist[j].amount+ "','"+ arr.ElementAt(i).itemlist[j].description+ "','"+  arr.ElementAt(i).itemlist[j].brand_id+ "','"+ arr.ElementAt(i).itemlist[j].price +"')", connect);
                        try
                        {
                            connect.Open();
                            cmd2.Parameters.AddWithValue("@IMG", arr.ElementAt(i).itemlist[j].image);
                            cmd2.ExecuteNonQuery();
                            connect.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        if (arr.ElementAt(i).itemlist[j].image == null)
                        {
                            cmd2 = new SqlCommand("insert into item (item_id,name,section_id,color,amount,description,brand_id,price) values ('" + arr.ElementAt(i).itemlist[j].id + "','" + arr.ElementAt(i).itemlist[j].name +"','"+ arr.ElementAt(i).itemlist[j].section_id + "','" + arr.ElementAt(i).itemlist[j].color + "','" + arr.ElementAt(i).itemlist[j].amount + "','" + arr.ElementAt(i).itemlist[j].description + "','" + arr.ElementAt(i).itemlist[j].brand_id + "','" + arr.ElementAt(i).itemlist[j].price + "')", connect);
                            try
                            {
                                connect.Open();
                               
                                cmd2.ExecuteNonQuery();
                                connect.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }

                }
            }
            
        }
        public void returnbrand(ref LinkedList<Brand> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd1 = new SqlCommand("delete from [brand]", connect);
            try
            {
                connect.Open();
                cmd1.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).image != null)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into brand (id,brand_name,picture,country,phone,mail,category) values ('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).name + "',@IMG,'" + arr.ElementAt(i).country + "','" + arr.ElementAt(i).phone + "','" + arr.ElementAt(i).mail + "','" + arr.ElementAt(i).category + "')", connect);
                    try
                    {
                        connect.Open();
                        cmd2.Parameters.AddWithValue("@IMG", arr.ElementAt(i).image);
                        cmd2.ExecuteNonQuery();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                    SqlCommand cmd2 = new SqlCommand("insert into brand (id,brand_name,country,phone,mail,category) values ('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).name + "','" + arr.ElementAt(i).country + "','" + arr.ElementAt(i).phone + "','" + arr.ElementAt(i).mail + "','" + arr.ElementAt(i).category + "')", connect);
                    try
                    {
                        connect.Open();
                      
                        cmd2.ExecuteNonQuery();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
        public void returnsectiondata(ref LinkedList<section> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd1 = new SqlCommand("delete from [section]", connect);
            try
            {
                connect.Open();
                cmd1.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).image != null)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into section (section_id,section_name,section_category,section_image) values('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).name + "','" + arr.ElementAt(i).description + "',@IMG)", connect);

                    try
                    {
                        connect.Open();
                        cmd2.Parameters.AddWithValue("@IMG", arr.ElementAt(i).image);
                        cmd2.ExecuteNonQuery();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (arr.ElementAt(i).image == null)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into section (section_id,section_name,section_category) values('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).name + "','" + arr.ElementAt(i).description + "')", connect);

                    try
                    {
                        connect.Open();
                       
                        cmd2.ExecuteNonQuery();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void returnrequstdata(ref LinkedList<request> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            SqlCommand cmd1 = new SqlCommand("delete from [request]", connect);
            try
            {
                connect.Open();
                cmd1.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into request (id,user_id,item_id,amount,status) values('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).user_id + "','" + arr.ElementAt(i).item_id + "','" + arr.ElementAt(i).amount + "','" + arr.ElementAt(i).status + "') ", connect);

                try
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void returnfeedbackdata(LinkedList<feedback> arr)
        {
            SqlConnection connect = new SqlConnection(sconnect);
            for (int i = 0; i < arr.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into feedback (id,user_id,status,feedback) values('" + arr.ElementAt(i).id + "','" + arr.ElementAt(i).user_id + "','" + arr.ElementAt(i).status + "','" + arr.ElementAt(i).feedbacktext + "') ", connect);

                try
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
