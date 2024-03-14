using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2._0
{
    internal class Travel
    {
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string object_t;
        public string Object_t
        {
            get { return object_t; }
            set { object_t = value; }
        }
        private DateTime d;
        public DateTime D
        {
            get { return d; }
            set { d = value; }
        }
        private bool active;
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        private string otziv;
        public string Otziv
        {
            get { return otziv; }
            set { otziv = value; }
        }
        private int mark;
        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public Travel(string country, string city, string object_t, DateTime d, bool active, string otziv, int mark)
        {
            this.country = country;
            this.city = city;
            this.object_t = object_t;
            this.d = d;
            this.active = active;
            this.otziv = otziv;
            this.mark = mark;
        }
        public string print()
        {
            return "Страна " + country + "\n Город " + city + "\n Тур.Объект " + object_t + "\n Дата" + d + "\n Активный" + active + "\n Отзыв " + otziv + "\n Оценка " + mark;
        }
    }
}
