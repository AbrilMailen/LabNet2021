using ExtensionMethods_Exceptions_UT;
using ExtensionMethods_Exceptions_UT.Extensions;
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
    public partial class Ejercicio_1 : Form
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool esInt;
         
                string linea = txtNumero.Text;
                esInt = int.TryParse(linea, out num);
            if (esInt)
            {
                try  
                {
                    num.DividirPorZero(); //extension method
                }
                catch (DivideByZeroException ex)  //exception
                {
                    MessageBox.Show($"Mensaje: {ex.Message}{Environment.NewLine}Error. No se puede dividir por cero.");
                
                }
                finally
                {
                    MessageBox.Show("Se finalizo el programa.");
                    this.Close();

                }
            }
            else {
                lblError.Text = "Ingrese un NUMERO.";
                txtNumero.Text = "";
                
            }


        }
    }
}
