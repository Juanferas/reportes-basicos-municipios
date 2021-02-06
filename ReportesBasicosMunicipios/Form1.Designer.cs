
namespace ReportesBasicosMunicipios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.municipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(684, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeptDataGridViewTextBoxColumn,
            this.codigoMunDataGridViewTextBoxColumn,
            this.nombreDeptDataGridViewTextBoxColumn,
            this.nombreMunDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.municipioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(702, 11);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // municipioBindingSource
            // 
            this.municipioBindingSource.DataSource = typeof(ReportesBasicosMunicipios.Municipio);
            // 
            // codigoDeptDataGridViewTextBoxColumn
            // 
            this.codigoDeptDataGridViewTextBoxColumn.DataPropertyName = "CodigoDept";
            this.codigoDeptDataGridViewTextBoxColumn.HeaderText = "Codigo Departamento";
            this.codigoDeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDeptDataGridViewTextBoxColumn.Name = "codigoDeptDataGridViewTextBoxColumn";
            this.codigoDeptDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoMunDataGridViewTextBoxColumn
            // 
            this.codigoMunDataGridViewTextBoxColumn.DataPropertyName = "CodigoMun";
            this.codigoMunDataGridViewTextBoxColumn.HeaderText = "Código Municipio";
            this.codigoMunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoMunDataGridViewTextBoxColumn.Name = "codigoMunDataGridViewTextBoxColumn";
            this.codigoMunDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDeptDataGridViewTextBoxColumn
            // 
            this.nombreDeptDataGridViewTextBoxColumn.DataPropertyName = "NombreDept";
            this.nombreDeptDataGridViewTextBoxColumn.HeaderText = "Nombre Departamento";
            this.nombreDeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDeptDataGridViewTextBoxColumn.Name = "nombreDeptDataGridViewTextBoxColumn";
            this.nombreDeptDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreMunDataGridViewTextBoxColumn
            // 
            this.nombreMunDataGridViewTextBoxColumn.DataPropertyName = "NombreMun";
            this.nombreMunDataGridViewTextBoxColumn.HeaderText = "Nombre Municipio";
            this.nombreMunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMunDataGridViewTextBoxColumn.Name = "nombreMunDataGridViewTextBoxColumn";
            this.nombreMunDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource municipioBindingSource;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}

