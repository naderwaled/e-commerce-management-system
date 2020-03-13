using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ds_project;
using System.Windows.Forms;
namespace Ds_project
{

    public class Items
    {
        public int id;
        public string name;
        public byte[] image = null;
        public string color;
        public int section_id;
        public int brand_id;
        
        public string brand_name;
        
        public double price;
        public string description;
        public int amount;
        public string status;
        /********/
        /* This function takes last element as pivot, 
   places the pivot element at its correct 
   position in sorted array, and places all 
   smaller (smaller than pivot) to left of 
   pivot and all greater elements to right 
   of pivot */
        int partitionname(List<Items> arr, int low, int high)
        {
            Items pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                string s = arr[j].name.ToUpper();
                string n = pivot.name.ToUpper();
                if (s[0] <=n[0])
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Items temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Items temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        void quickSortname(List<Items> arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionname(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSortname(arr, low, pi - 1);
                quickSortname(arr, pi + 1, high);
            }
        }
        int partitionprice(List<Items> arr, int low, int high)
        {
            Items pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j].price <= pivot.price)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Items temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Items temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        void quickSortprice(List<Items> arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partitionprice(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSortprice(arr, low, pi - 1);
                quickSortprice(arr, pi + 1, high);
            }
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */


        public void additem(LinkedList<Brand> arr,LinkedList<section> secarr,List<Items> itarr, Items it)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).id == it.brand_id)
                {
                    it.id = Variables.maxitem_id+ 1;
                    Variables.maxitem_id += 1;
                    arr.ElementAt(i).itemlist.Add(it);
                    itarr.Add(it);

                    MessageBox.Show("Added");
                    break;
                }
            }
            for(int i=0; i<secarr.Count;i++)
            { 
                if(secarr.ElementAt(i).id==it.section_id)
                {
                    secarr.ElementAt(i).itemlist.Add(it);
                }
            }
        }

        public void edititem(LinkedList<Brand> arr,string oldname, Items it)
        {
            bool end = false;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).id == it.brand_id)
                {
                    for (int j = 0; j < arr.ElementAt(i).itemlist.Count; j++)
                    {
                        if (arr.ElementAt(i).itemlist[j].name == oldname)
                        {
                            arr.ElementAt(i).itemlist[j] = it;
                            end = true;
                            MessageBox.Show("Edited");
                            break;

                        }
                    }
                }
                if (end == true)
                    break;


            }

        }
        public void deleteitem(LinkedList<Brand> arr, string oldname,Items it)
        {

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.ElementAt(i).itemlist.Count; j++)
                {
                    if (arr.ElementAt(i).itemlist[j].name == oldname)
                    {

                        arr.ElementAt(i).itemlist.Remove(it);

                        MessageBox.Show("Deleted");
                        break;


                    }
                }
            }


        }
        public void sortbyprice( List<Items> arr)
        {
            quickSortprice(arr, 0, arr.Count - 1);
        }
        public  void sortbyname(List<Items> arr)
        {
            quickSortname(arr, 0, arr.Count - 1);
        }
        public static LinkedList<Items> itemsearch(LinkedList<Brand> arr, string text)
        {
            LinkedList<Items> returnarr = new LinkedList<Items>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.ElementAt(i).itemlist.Count; j++)
                {
                    if (arr.ElementAt(i).itemlist[j].name.Contains(text))
                        returnarr.AddLast(arr.ElementAt(i).itemlist[j]);
                }
            }
            return returnarr;
        }

        public static LinkedList<Items> filtercolor(LinkedList<Items> arr, string text)
        {
            LinkedList<Items> returnsbcolor = new LinkedList<Items>();
            for (int i = 0; i < arr.Count; i++)
            {

                if (arr.ElementAt(i).color.Contains(text))
                    returnsbcolor.AddLast(arr.ElementAt(i));

            }
            return returnsbcolor;


        }
        public static LinkedList<Items> filterprice(LinkedList<Items> arr, int min, int max)
        {
            LinkedList<Items> returnprice = new LinkedList<Items>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.ElementAt(i).price >= min && arr.ElementAt(i).price <= max)
                    returnprice.AddLast(arr.ElementAt(i));
            }
            return returnprice;
        }
        //edit
    public static LinkedList<Items> filterbrand(LinkedList<Items> itemlist,string brandname)
    {
            LinkedList<Items> returnsection = new LinkedList<Items>();
            for (int i = 0; i < itemlist.Count; i++)
            {
                Brand brand = new Brand();
                brand = Brand.getbrandbyname(Variables.brandlist, brandname);
                if (brand.id == itemlist.ElementAt(i).brand_id)
                {
                    returnsection.AddLast(itemlist.ElementAt(i));
                }

            }
            return returnsection;
        }//edit
    public static LinkedList<Items> filtersection(LinkedList<Items> itemlist,string sectionname)
        {
            LinkedList<Items> returnsection = new LinkedList<Items>();
            for(int i = 0; i < itemlist.Count; i++)
            {
                section sec = new section();
                sec = section.getsectionbyname(Variables.sectionlist,sectionname);
                if (sec.id == itemlist.ElementAt(i).section_id)
                {
                    returnsection.AddLast(itemlist.ElementAt(i));
                }
                
            }
            return returnsection;
        }
        public static Items getiteminfo(LinkedList<Brand> arr, int id)
        {
            Items Itemid = new Items();
            Itemid.id = -1;

            for (int i = 0; i < arr.Count; i++)
                for (int j = 0; j < arr.ElementAt(i).itemlist.Count; j++)
                {
                    if (arr.ElementAt(i).itemlist[j].id == id)
                    {
                        Itemid = arr.ElementAt(i).itemlist[j];
                        break;
                    }

                }
            return Itemid;
        }



    }
    }



    


    
