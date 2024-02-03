
namespace School
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbSchoolDataSet = new School.dbSchoolDataSet();
            this.nineClasseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nineClasseTableAdapter = new School.dbSchoolDataSetTableAdapters.nineClasseTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.russkiyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physhicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geometryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbSchoolDataSet2 = new School.dbSchoolDataSet2();
            this.nineClasseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nineClasseTableAdapter1 = new School.dbSchoolDataSet2TableAdapters.nineClasseTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineClasseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineClasseBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.russkiyDataGridViewTextBoxColumn,
            this.mathDataGridViewTextBoxColumn,
            this.physhicsDataGridViewTextBoxColumn,
            this.technologyDataGridViewTextBoxColumn,
            this.literatureDataGridViewTextBoxColumn,
            this.geometryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nineClasseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbSchoolDataSet
            // 
            this.dbSchoolDataSet.DataSetName = "dbSchoolDataSet";
            this.dbSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nineClasseBindingSource
            // 
            this.nineClasseBindingSource.DataMember = "nineClasse";
            this.nineClasseBindingSource.DataSource = this.dbSchoolDataSet;
            // 
            // nineClasseTableAdapter
            // 
            this.nineClasseTableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // russkiyDataGridViewTextBoxColumn
            // 
            this.russkiyDataGridViewTextBoxColumn.DataPropertyName = "russkiy";
            this.russkiyDataGridViewTextBoxColumn.HeaderText = "russkiy";
            this.russkiyDataGridViewTextBoxColumn.Name = "russkiyDataGridViewTextBoxColumn";
            // 
            // mathDataGridViewTextBoxColumn
            // 
            this.mathDataGridViewTextBoxColumn.DataPropertyName = "math";
            this.mathDataGridViewTextBoxColumn.HeaderText = "math";
            this.mathDataGridViewTextBoxColumn.Name = "mathDataGridViewTextBoxColumn";
            // 
            // physhicsDataGridViewTextBoxColumn
            // 
            this.physhicsDataGridViewTextBoxColumn.DataPropertyName = "physhics";
            this.physhicsDataGridViewTextBoxColumn.HeaderText = "physhics";
            this.physhicsDataGridViewTextBoxColumn.Name = "physhicsDataGridViewTextBoxColumn";
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "technology";
            this.technologyDataGridViewTextBoxColumn.HeaderText = "technology";
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            // 
            // literatureDataGridViewTextBoxColumn
            // 
            this.literatureDataGridViewTextBoxColumn.DataPropertyName = "literature";
            this.literatureDataGridViewTextBoxColumn.HeaderText = "literature";
            this.literatureDataGridViewTextBoxColumn.Name = "literatureDataGridViewTextBoxColumn";
            // 
            // geometryDataGridViewTextBoxColumn
            // 
            this.geometryDataGridViewTextBoxColumn.DataPropertyName = "geometry";
            this.geometryDataGridViewTextBoxColumn.HeaderText = "geometry";
            this.geometryDataGridViewTextBoxColumn.Name = "geometryDataGridViewTextBoxColumn";
            // 
            // dbSchoolDataSet2
            // 
            this.dbSchoolDataSet2.DataSetName = "dbSchoolDataSet2";
            this.dbSchoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nineClasseBindingSource1
            // 
            this.nineClasseBindingSource1.DataMember = "nineClasse";
            this.nineClasseBindingSource1.DataSource = this.dbSchoolDataSet2;
            // 
            // nineClasseTableAdapter1
            // 
            this.nineClasseTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "9 класс";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineClasseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineClasseBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbSchoolDataSet dbSchoolDataSet;
        private System.Windows.Forms.BindingSource nineClasseBindingSource;
        private dbSchoolDataSetTableAdapters.nineClasseTableAdapter nineClasseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn russkiyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physhicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geometryDataGridViewTextBoxColumn;
        private dbSchoolDataSet2 dbSchoolDataSet2;
        private System.Windows.Forms.BindingSource nineClasseBindingSource1;
        private dbSchoolDataSet2TableAdapters.nineClasseTableAdapter nineClasseTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
    }
}