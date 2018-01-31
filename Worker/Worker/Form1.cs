using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar Collector", "Honey Manufacturing" });
            workers[1] = new Worker(new string[] { "Egg Care", "Haby Bee Tutoring" });
            workers[2] = new Worker(new string[] { "Hive Maintenance", "Sting Patrol" });
            workers[3] = new Worker(new string[] { "Egg Care", "Haby Bee Tutoring", "Hive Maintenance",
                "Nectar Collector", "Honey Manufacturing","Sting Patrol" });
        }
    }
}
