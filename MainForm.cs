﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMember add = new AddMember();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDelete updel = new();
            updel.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment pay = new();
            pay.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewMember vi = new();
            vi.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
