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
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
           int  num1 = Convert.ToInt32(txtDividendo.Text);
            int num2 = Convert.ToInt32(txtDivisor.Text);
                txtResult.Text = num1.Dividir(num2).ToString(); //extension method
                }
                catch (DivideByZeroException ex) //exception
                {
                    MessageBox.Show($"{ex.Message}{Environment.NewLine}Error. Solo Chuck Norris puede dividir por cero!");

                }
                catch (FormatException ex)
                {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}Error. Seguro ingreso una letra o no ingreso nada! {Environment.NewLine}Debe ingresar numeros enteros para poder realizar la division.");
                }
                finally
                {
                    MessageBox.Show("Finalizó.");
                }
            

        }
    }
}
