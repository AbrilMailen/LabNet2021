using ExtensionMethods_Exceptions_UT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods_Exceptions_UT
{
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                Logic.Excepcion4();
                
            }
            catch (CustomExceptions ex){
                textBox1.Text = ex.Message;
            }
        }
    }
}
