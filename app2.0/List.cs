using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace app2._0
{
    internal class List
    {
        private List<Travel> mylist;
        public List<Travel> Mylist
        {
            get { return mylist; }
            set { mylist = value; }
        }  
        public List()
        {
            mylist = new List<Travel>();
        }
        public void Add(Travel t)
        {
            mylist.Add(t);
        }
        public string print () 
        {
            string s = "";
            foreach (Travel t in mylist) 
            {
                s += t.print() + "\n--------------\n";
            }
            return s;

        }
        public int Size()
        {
            return mylist.Count;
        }
        public int PC()
        {
            var set = new HashSet<string>();
            foreach (Travel t in mylist)
                set.Add(t.Country);
            return set.Count;
        }
        public int PCity()
        {
            var set = new HashSet<string>();
            foreach (Travel t in mylist)
                set.Add(t.City);
            return set.Count;
        }
        public int PObject()
        {
            var set = new HashSet<string>();
            foreach (Travel t in mylist)
                set.Add(t.Object_t);
            return set.Count;
        }
        public double MO()
        {
            double s = 0.0;
            int k = 0;
            foreach (Travel t in mylist)
            {
                if (t.Country == "Россия")
                {
                    k++;
                    s += t.Mark;
                }
            }
            return ((double)s / k);
        }
        public double MR()
        {
            double s = 0.0;
            int k = 0;
            foreach (Travel t in mylist)
            {
                if (t.Country != "Россия")
                {
                    k++;
                    s += t.Mark;
                }
            }
            return ((double)s / k);
        }
       public int KPS()
        {
            int k = 0;
            foreach (Travel t in mylist)
            {
                DateTime Date = t.D;
                if (Date != null) 
                {
                    if (Date.Month >= 6 && Date.Month <= 8) k++;
                }
            }
            return k;
        }
        public int KPF()
        {
            int k = 0;
            foreach (Travel t in mylist)
            {
                DateTime Date = t.D;
                if (Date != null)
                {
                    if (Date.Month == 12 || Date.Month == 2 || Date.Month == 1) k++;
                }
            }
            return k;
        }
        public int KA()
        {
            int k = 0;
            foreach (Travel t in mylist)
            {
                if (t.Active == true)

                {
                    k++;
                }
            }
            return k;
        }
        public int KP()
        {
            int k = 0;
            foreach (Travel t in mylist)
            {
                if (t.Active != true)

                {
                    k++;
                }
            }
            return k;
        }
    }

}
