using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ds_project;
using System.Windows.Forms;
namespace Ds_project
{
   public class Brand
    {
        public int id;
        public string name;
        public string category;
        public byte[] image=null;
        public string phone;
        public string mail;
        public string country;
        public List<Items>itemlist= new List<Items>();
        public bool addbrand(LinkedList<Brand>arr,Brand newbrand)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name == newbrand.name)
                {
                    MessageBox.Show("Enter antoher name.");
                    return false;
                    
                }
                
            }
          
            newbrand.id=arr.ElementAt(arr.Count - 1).id+1;
            arr.AddLast(newbrand);
            MessageBox.Show("Saved");
            return true;
                
        }

        public bool editbrand(LinkedList<Brand>arr,string oldname,Brand editbrand) 
        {
            bool found = false;
            int index = new int();//??
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name == oldname)//&& arr.ElementAt(i).id != editbrand.id)
                {
                    index = i;
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                MessageBox.Show("enter another name.");
                return false;
            }

            arr.ElementAt(index).image = editbrand.image;
            arr.ElementAt(index).name = editbrand.name;
            arr.ElementAt(index).phone = editbrand.phone;
            arr.ElementAt(index).mail = editbrand.mail;
            arr.ElementAt(index).category = editbrand.category;
            arr.ElementAt(index).country = editbrand.country;

            MessageBox.Show("Edited");
            return true;                
            
        }
        public void deletebrand(LinkedList<Brand>arr,string deletebrand)
        {
            
            for (int i=0; i<arr.Count;i++)
            {
                if(arr.ElementAt(i).name== deletebrand)
                {
                    arr.Remove(arr.ElementAt(i));
                    break;
                }
            }
        }
        public static LinkedList<Brand>brandsearch(LinkedList<Brand>arr,string text)
        {
            LinkedList<Brand> returnbrand = new LinkedList<Brand>();
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name.Contains(text))
                    returnbrand.AddLast(arr.ElementAt(i));
            }
            return returnbrand;
        }
        public static Brand getbrandbyname(LinkedList<Brand>arr,string text)
        {
            Brand bran = new Brand();
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name == text)
                {
                    bran = arr.ElementAt(i);
                    break;
                }

            }
            return bran;
        }
        public static Brand getbrandbyid(LinkedList<Brand> arr, int id)
        {
            Brand bran = new Brand();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).id == id)
                {
                    bran = arr.ElementAt(i);
                    break;
                }

            }
            return bran;
        }




    }
}
