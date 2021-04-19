using ExtensionMethods_Exceptions_UT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods_Exceptions_UT
{
    public class Logic
    {
        public static void Excepcion3() { //genera excepcion index out of range
                string[] vector = new string[9]; //array de 9 elementos string

                for (int i = 0; i < 12; i++) //intento cargar + de 9 elementos
                {
                    vector[i] = i.ToString(); 
                }
           
        }
        public static void Excepcion4() {
            using (var sw = new StreamWriter("./archivo_que_no_existe.txt"))
            {
                sw.WriteLine("Linea de texto.");
            }
            throw new CustomExceptions("¡¡¡Directory Not Found Exception!!!");
        }

    }
}
