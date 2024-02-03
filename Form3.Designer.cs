
namespace School
{
    partial class Form3
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
            this.dbSchoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSchoolDataSet1 = new School.dbSchoolDataSet1();
            this.twoClasseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twoClasseTableAdapter = new School.dbSchoolDataSet1TableAdapters.twoClasseTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okrmirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClasseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.mathDataGridViewTextBoxColumn,
            this.rusDataGridViewTextBoxColumn,
            this.okrmirDataGridViewTextBoxColumn,
            this.musicDataGridViewTextBoxColumn,
            this.technologyDataGridViewTextBoxColumn,
            this.literatureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.twoClasseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbSchoolDataSet
            // 
            this.dbSchoolDataSet.DataSetName = "dbSchoolDataSet";
            this.dbSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSchoolDataSetBindingSource
            // 
            this.dbSchoolDataSetBindingSource.DataSource = this.dbSchoolDataSet;
            this.dbSchoolDataSetBindingSource.Position = 0;
            // 
            // dbSchoolDataSet1
            // 
            this.dbSchoolDataSet1.DataSetName = "dbSchoolDataSet1";
            this.dbSchoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // twoClasseBindingSource
            // 
            this.twoClasseBindingSource.DataMember = "twoClasse";
            this.twoClasseBindingSource.DataSource = this.dbSchoolDataSet1;
            // 
            // twoClasseTableAdapter
            // 
            this.twoClasseTableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // mathDataGridViewTextBoxColumn
            // 
            this.mathDataGridViewTextBoxColumn.DataPropertyName = "math";
            this.mathDataGridViewTextBoxColumn.HeaderText = "math";
            this.mathDataGridViewTextBoxColumn.Name = "mathDataGridViewTextBoxColumn";
            // 
            // rusDataGridViewTextBoxColumn
            // 
            this.rusDataGridViewTextBoxColumn.DataPropertyName = "rus";
            this.rusDataGridViewTextBoxColumn.HeaderText = "rus";
            this.rusDataGridViewTextBoxColumn.Name = "rusDataGridViewTextBoxColumn";
            // 
            // okrmirDataGridViewTextBoxColumn
            // 
            this.okrmirDataGridViewTextBoxColumn.DataPropertyName = "okrmir";
            this.okrmirDataGridViewTextBoxColumn.HeaderText = "okrmir";
            this.okrmirDataGridViewTextBoxColumn.Name = "okrmirDataGridViewTextBoxColumn";
            // 
            // musicDataGridViewTextBoxColumn
            // 
            this.musicDataGridViewTextBoxColumn.DataPropertyName = "music";
            this.musicDataGridViewTextBoxColumn.HeaderText = "music";
            this.musicDataGridViewTextBoxColumn.Name = "musicDataGridViewTextBoxColumn";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2 класс";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClasseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbSchoolDataSetBindingSource;
        private dbSchoolDataSet dbSchoolDataSet;
        private dbSchoolDataSet1 dbSchoolDataSet1;
        private System.Windows.Forms.BindingSource twoClasseBindingSource;
        private dbSchoolDataSet1TableAdapters.twoClasseTableAdapter twoClasseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okrmirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literatureDataGridViewTextBoxColumn;
    }
}