﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSchoolDataSet1.twoClasse". При необходимости она может быть перемещена или удалена.
            this.twoClasseTableAdapter.Fill(this.dbSchoolDataSet1.twoClasse);

        }
    }
}
