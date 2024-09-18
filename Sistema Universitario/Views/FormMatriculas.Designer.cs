namespace Sistema_Universitario.Views
{
    partial class FormMatriculas
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
            this.dataGridViewMatriculas = new System.Windows.Forms.DataGridView();
            this.comboBoxEstudiantes = new System.Windows.Forms.ComboBox();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatriculas
            // 
            this.dataGridViewMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatriculas.Location = new System.Drawing.Point(12, 192);
            this.dataGridViewMatriculas.Name = "dataGridViewMatriculas";
            this.dataGridViewMatriculas.Size = new System.Drawing.Size(412, 215);
            this.dataGridViewMatriculas.TabIndex = 0;
            // 
            // comboBoxEstudiantes
            // 
            this.comboBoxEstudiantes.FormattingEnabled = true;
            this.comboBoxEstudiantes.Location = new System.Drawing.Point(12, 127);
            this.comboBoxEstudiantes.Name = "comboBoxEstudiantes";
            this.comboBoxEstudiantes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstudiantes.TabIndex = 1;
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(303, 127);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCursos.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(159, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "MATRICULAS";
            // 
            // FormMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.comboBoxEstudiantes);
            this.Controls.Add(this.dataGridViewMatriculas);
            this.Name = "FormMatriculas";
            this.Text = "FormMatriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatriculas;
        private System.Windows.Forms.ComboBox comboBoxEstudiantes;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}