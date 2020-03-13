using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ds_project;
using System.Windows.Forms;
namespace Ds_project
{
   public class section
    {
        public int id;
        public string name;
        public string description;
        public byte[] image=null;
        public List<Items> itemlist = new List<Items>();

        public bool addsection(LinkedList<section>arr,section newsection)
        {
            for (int i= 0; i < arr.Count; i++){
                if (arr.ElementAt(i).name == newsection.name)
                {
                    MessageBox.Show("enter another name.");
                    return false;
                }


            }
            newsection.id = arr.ElementAt(arr.Count - 1).id + 1;
            arr.AddLast(newsection);
            
            return true;
         
        }
        public bool editsection(LinkedList<section>arr,string oldname,section editsection)
        {
            int index = new int();//??
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name == oldname)//&& arr.ElementAt(i).id != editbrand.id)
                {
                    index = i;
                    break;
                }
            }
            

            arr.ElementAt(index).image = editsection.image;
            arr.ElementAt(index).name = editsection.name;
            arr.ElementAt(index).description = editsection.description;
            MessageBox.Show("Edited");
            return true;
        }
        public void deletesection(LinkedList<section>arr,string deletesection)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name == deletesection)
                {
                    arr.Remove(arr.ElementAt(i));
                    break;
                }
            }
        }
        public static LinkedList<section>searchsection(LinkedList<section>arr,string text)
        {
            LinkedList<section> returnsection = new LinkedList<section>();
                  for(int i=0;i<arr.Count();i++)
            {
             
                if(arr.ElementAt(i).name.Contains(text))
                {
                    returnsection.AddLast(arr.ElementAt(i));
                }
                
            }
                  return returnsection;
        }
        public static section getsectionbyname(LinkedList<section> arr, string text)
        {
            section sec = new section();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).name == text)
                {
                    sec = arr.ElementAt(i);
                    break;
                }
            }
            return sec;
        }
        public static section getsectionbyid(LinkedList<section> arr, int id)
        {
            section sec = new section();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).id == id)
                {
                    sec = arr.ElementAt(i);
                    break;
                }
            }
            return sec;
        }


    }
}
