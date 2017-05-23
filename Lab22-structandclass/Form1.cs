using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab22_structandclass
{
    struct xyz
    {

       

    }

    class Abc
    {

      

    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10000; i++)
            {
                Abc a = new Abc();             
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                xyz x = new xyz();

                // Abc x = new Abc();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                Abc x = new Abc();
            }
        }
    }
}
