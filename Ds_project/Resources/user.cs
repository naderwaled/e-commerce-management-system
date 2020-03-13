using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Ds_project;
using System.Windows.Forms;

namespace Ds_project
{
  public  class request
    {
      public  int id;
      public  int item_id;
      public int amount;
      public  int user_id;
      public  string status;
      public DateTime date ;
        public static void  done_request(ref LinkedList<request> arr,request req,string s)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i) == req)
                {
                    arr.ElementAt(i).status = s;
                }
            }
        }
     
      
      
    };
    public class feedback {
        public int id;
        public int user_id;
        public string status;
        public string feedbacktext;
    };
   public  class user
    {
        public int id;
        public string name;
        
        public string adress;
        
        public string password;
        public string gender;
        public string mail;
        public string phone;
        public bool status;

        // public List<request> requests=new List<request>();
        public bool login(string email,string password, LinkedList<user> arr,ref user usernow)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).mail == email && arr.ElementAt(i).password == password)
                {
                    usernow = arr.ElementAt(i);
                    return true;

                }
            }
            return false;

        }
        public bool register(LinkedList<user>arr,user usernow)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).mail == usernow.mail)
                {
                    MessageBox.Show("invalid Email, Enter antoher email.");
                    return false;
                }
                if (arr.ElementAt(i).phone == usernow.phone)
                {
                    MessageBox.Show("enter another phone.");
                    return false;
                }
            }
            usernow.id = arr.ElementAt(arr.Count-1).id + 1;
            arr.AddLast(usernow);
            return true;
        }
      
      public string requestfunction(ref LinkedList<request>requestarr,user usernow,Items item,ref LinkedList<Brand>itemarr,request req)
        {
            for(int i = 0; i < itemarr.Count; i++)
            {
                if (itemarr.ElementAt(i).id == item.brand_id)
                {
                    for(int j = 0; j < itemarr.ElementAt(i).itemlist.Count; j++)
                    {
                        if (itemarr.ElementAt(i).itemlist[j].id == item.id)
                        {
                            if(req.amount<= itemarr.ElementAt(i).itemlist[j].amount)
                            {
                                itemarr.ElementAt(i).itemlist[j].amount -= req.amount;
                                requestarr.AddLast(req);
                                return "Added";
                            }
                            else if(req.amount > itemarr.ElementAt(i).itemlist[j].amount)
                            {
                                return "Amount available "+ itemarr.ElementAt(i).itemlist[j].amount;
                            }
                        }
                    }
                }
            }
            return "NON";
        } 
        public LinkedList<request>retrnrequest(ref LinkedList<request>arr,user usernow)
        {
            LinkedList<request> returnlist = new LinkedList<request>();
            for(int i=0;i<arr.Count;i++)
            {
                if (arr.ElementAt(i).user_id == usernow.id)
                {
                    //here
              
                    returnlist.AddLast(arr.ElementAt(i));
                }
                if (arr.ElementAt(i).item_id == 0)
                {
                    arr.Remove(arr.ElementAt(i));
                }
                
            }
            return(returnlist);
                
        }
        public user getuserinfo (LinkedList<user>arr,int id)
        {
            user userid = new user();
            for(int i=0;i<arr.Count;i++)
            {
                if(arr.ElementAt(i).id==id)
                {
                    userid = arr.ElementAt(i);
                    break;
                }
            }
            return userid; 

        }
        public bool edituserdata(LinkedList<user>arr, user usernow)
        {
            int index=new int();
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).mail == usernow.mail&&usernow.id!=arr.ElementAt(i).id)
                {
                    return false;
                }
                else if (arr.ElementAt(i).phone == usernow.phone && usernow.id != arr.ElementAt(i).id)
                {
                    return false;
                }
                else if(usernow.id == arr.ElementAt(i).id)
                {
                    index = i;
                }
            }
            arr.ElementAt(index).name=usernow.name;
            arr.ElementAt(index).adress = usernow.adress;
            arr.ElementAt(index).gender = usernow.gender;
            arr.ElementAt(index).mail = usernow.mail;
            arr.ElementAt(index).password = usernow.password;
            arr.ElementAt(index).phone = usernow.phone;
            return true;
        }
       






    }
}
