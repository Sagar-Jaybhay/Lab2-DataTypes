using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab22_Struct_class_differnce
{
    struct Abc
    {
        string Name;
        double amount;

    }

    class Def
    {
        string name;
        double amount;

    }
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 1000000; i++)
            {
                Def a = new Def();
            }
               
        }

        

    }
}
