
namespace School
{
    partial class Form4
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
            this.dbSchoolDataSet3 = new School.dbSchoolDataSet3();
            this.elevenClasseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevenClasseTableAdapter = new School.dbSchoolDataSet3TableAdapters.ElevenClasseTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemistryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informatiksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevenClasseBindingSource)).BeginInit();
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
            this.literatureDataGridViewTextBoxColumn,
            this.chemistryDataGridViewTextBoxColumn,
            this.physicsDataGridViewTextBoxColumn,
            this.informatiksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.elevenClasseBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.PaleGreen;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbSchoolDataSet3
            // 
            this.dbSchoolDataSet3.DataSetName = "dbSchoolDataSet3";
            this.dbSchoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elevenClasseBindingSource
            // 
            this.elevenClasseBindingSource.DataMember = "ElevenClasse";
            this.elevenClasseBindingSource.DataSource = this.dbSchoolDataSet3;
            // 
            // elevenClasseTableAdapter
            // 
            this.elevenClasseTableAdapter.ClearBeforeFill = true;
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
            // literatureDataGridViewTextBoxColumn
            // 
            this.literatureDataGridViewTextBoxColumn.DataPropertyName = "literature";
            this.literatureDataGridViewTextBoxColumn.HeaderText = "literature";
            this.literatureDataGridViewTextBoxColumn.Name = "literatureDataGridViewTextBoxColumn";
            // 
            // chemistryDataGridViewTextBoxColumn
            // 
            this.chemistryDataGridViewTextBoxColumn.DataPropertyName = "chemistry";
            this.chemistryDataGridViewTextBoxColumn.HeaderText = "chemistry";
            this.chemistryDataGridViewTextBoxColumn.Name = "chemistryDataGridViewTextBoxColumn";
            // 
            // physicsDataGridViewTextBoxColumn
            // 
            this.physicsDataGridViewTextBoxColumn.DataPropertyName = "physics";
            this.physicsDataGridViewTextBoxColumn.HeaderText = "physics";
            this.physicsDataGridViewTextBoxColumn.Name = "physicsDataGridViewTextBoxColumn";
            // 
            // informatiksDataGridViewTextBoxColumn
            // 
            this.informatiksDataGridViewTextBoxColumn.DataPropertyName = "informatiks";
            this.informatiksDataGridViewTextBoxColumn.HeaderText = "informatiks";
            this.informatiksDataGridViewTextBoxColumn.Name = "informatiksDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(761, 474);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11 класс ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevenClasseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbSchoolDataSet3 dbSchoolDataSet3;
        private System.Windows.Forms.BindingSource elevenClasseBindingSource;
        private dbSchoolDataSet3TableAdapters.ElevenClasseTableAdapter elevenClasseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn literatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemistryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informatiksDataGridViewTextBoxColumn;
    }
}