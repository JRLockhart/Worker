﻿using System;
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
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar Collector", "Honey Manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg Care", "Haby Bee Tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive Maintenance", "Sting Patrol" }, 149);
            workers[3] = new Worker(new string[] { "Egg Care", "Haby Bee Tutoring", "Hive Maintenance",
                "Nectar Collector", "Honey Manufacturing","Sting Patrol" }, 155);
            queen = new Queen(workers, 275);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value)== false)
            {
                MessageBox.Show("No workers are available to do this job '" + workerBeeJob.Text +
                    "'" + "The queen bee says...");
            }
            else
            {
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " +
                    shifts.Value + " shifts", "The queen bee says...");
            }
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
