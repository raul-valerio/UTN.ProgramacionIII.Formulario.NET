namespace Actividad_2
{
    partial class FormAltaCategoria
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
            this.labelDescpCategoria = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescpCategoria
            // 
            this.labelDescpCategoria.AutoSize = true;
            this.labelDescpCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescpCategoria.Location = new System.Drawing.Point(36, 44);
            this.labelDescpCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescpCategoria.Name = "labelDescpCategoria";
            this.labelDescpCategoria.Size = new System.Drawing.Size(109, 16);
            this.labelDescpCategoria.TabIndex = 0;
            this.labelDescpCategoria.Text = "Nueva Categoría";
     
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(149, 43);
            this.textBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(258, 20);
            this.textBoxCategoria.TabIndex = 1;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(39, 80);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(182, 42);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCategoria.Location = new System.Drawing.Point(225, 80);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(182, 42);
            this.btnCancelarCategoria.TabIndex = 3;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // FormAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 164);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.labelDescpCategoria);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(472, 203);
            this.MinimumSize = new System.Drawing.Size(472, 203);
            this.Name = "FormAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescpCategoria;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
    }
}