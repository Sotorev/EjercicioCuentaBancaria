using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentaBancaria
{
    internal class Person
    {
        public String name;
        public String lastName;
        public String DPI { get; set; }
        public String Name {
            get
            {
                return name;
            }
            set
            {
                name = Text_normalize(value);
            } 
        }
        public String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = Text_normalize(value);
            }
        }
        public DateTime BirthDate { get; set; }
        public int Age()
        {
            TimeSpan ts = DateTime.Now - BirthDate;
            return Convert.ToInt32(Math.Floor(ts.TotalDays / 365));
        }
        private String Text_normalize(String s1)
        {
            String s2 = ""; // Cadena editada
            //Eliminar simbolos
            for (int i = 33; i < 255; i++)
            {

                if (i >= 65 && i <= 90 || i >= 97 && i <= 122)
                    continue;
                else
                    s1 = s1.Replace((Convert.ToChar(i)).ToString(), String.Empty);
            }
            //Eliminar Espacios extras
            Boolean hasStarted = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ' ')
                {
                    continue;
                }
                if (s1[i] != ' ')
                {
                    String tmpstr = "";
                    while (i < s1.Length && s1[i] != ' ')
                    {

                        tmpstr += s1[i];
                        i++;
                    }
                    if (hasStarted) s2 += " " + tmpstr;
                    else s2 += tmpstr;
                    hasStarted = true;
                }
            }

            s2 = s2.Replace(s2[0], s2[0].ToString().ToUpper().ToCharArray()[0]);
            for (int i = 0; i < s2.Length; i++)
            {
                String aux = s2;
                if (s2[i] == ' ')
                {
                    aux = s2.Substring(i + 1, 1).Replace(s2[i + 1], s2[i + 1].ToString().ToUpper().ToCharArray()[0]);
                    s2 = s2.Substring(0, i + 1) + aux + s2.Substring(i + 2);
                }
            }
            return s2;

        }
    }
}
