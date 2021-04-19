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
    public partial class Ejercicio_3 : Form
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { Logic.Excepcion3(); }
            catch (IndexOutOfRangeException error)
            {
                MessageBox.Show(
                    $"EXCEPCION:{error.GetType()}{Environment.NewLine}MENSAJE DE LA EXCEPCION: {error.Message}{Environment.NewLine}STACK TRACE: {error.StackTrace}") ;
            }
        }
    }
}
