using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSchoolDataSet2.nineClasse". При необходимости она может быть перемещена или удалена.
            this.nineClasseTableAdapter1.Fill(this.dbSchoolDataSet2.nineClasse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSchoolDataSet.nineClasse". При необходимости она может быть перемещена или удалена.
            this.nineClasseTableAdapter.Fill(this.dbSchoolDataSet.nineClasse);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
