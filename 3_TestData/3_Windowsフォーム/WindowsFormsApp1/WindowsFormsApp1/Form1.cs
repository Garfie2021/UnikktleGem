using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1_1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SampleClass1_1.method3_1();

            if (false)
            {
                throw new Exception("Literal String 1-1");
            }


            try
            {
                MessageBox.Show(Properties.Resources11.String1_8);

                MessageBox.Show(Properties.Resources11.String1_9 + Properties.Resources11.String1_10);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources11.String1_7);

                MessageBox.Show(Properties.Resources11.String1_11 + Properties.Resources11.String1_12);

                MessageBox.Show(Properties.Resources11.String1_14 + Properties.Resources11.String1_15 + Properties.Resources11.String1_16);
            }
            finally
            {
                MessageBox.Show(Properties.Resources11.String1_6);

                MessageBox.Show(Properties.Resources11.String1_12 + Properties.Resources11.String1_13);
            }

            if (true)
            {
                MessageBox.Show(Properties.Resources11.String1_5);
            }

            switch (0)
            {
                case 0:
                    MessageBox.Show(Properties.Resources11.String1_4);
                    return;
            }

            try
            {
            }
            catch (Exception)
            {
                //ST_Exception.Exception_Common(ex, this.Text);
            }

            M1();


            MessageBox.Show(Properties.Resources11.String1_1);

            SampleClass1.method2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aaa = Properties.Resources11.String1_1;
        }

        public void M1()
        {
            MessageBox.Show(Properties.Resources11.String2_1);
        }
    }

    class SampleClass1
    {
        public static void method1()
        {
            MessageBox.Show(Properties.Resources11.String3_1);
        }

        public static void method2()
        {
            throw new Exception("Literal String 3-1");
        }
    }
}

namespace WindowsFormsApp1_1
{
    class SampleClass1_1
    {
        public static void method3_1()
        {
            MessageBox.Show("Literal String 4-1");
        }

        public static void method3_2()
        {
            throw new Exception("Literal String 5-1");
        }
    }
}
