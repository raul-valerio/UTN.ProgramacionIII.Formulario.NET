namespace Actividad_2
{
    partial class FormEditarCategoria
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
            this.textBoxEditarCategoria = new System.Windows.Forms.TextBox();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.dgvEditarCategoria = new System.Windows.Forms.DataGridView();
            this.btnVolverEditarCategoria = new System.Windows.Forms.Button();
            this.lblEditCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEditarCategoria
            // 
            this.textBoxEditarCategoria.Location = new System.Drawing.Point(14, 56);
            this.textBoxEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditarCategoria.Name = "textBoxEditarCategoria";
            this.textBoxEditarCategoria.Size = new System.Drawing.Size(182, 20);
            this.textBoxEditarCategoria.TabIndex = 0;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.Location = new System.Drawing.Point(14, 112);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(182, 42);
            this.btnEditarCategoria.TabIndex = 1;
            this.btnEditarCategoria.Text = "Confirmar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // dgvEditarCategoria
            // 
            this.dgvEditarCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditarCategoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEditarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEditarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEditarCategoria.Location = new System.Drawing.Point(214, 11);
            this.dgvEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEditarCategoria.MultiSelect = false;
            this.dgvEditarCategoria.Name = "dgvEditarCategoria";
            this.dgvEditarCategoria.RowTemplate.Height = 24;
            this.dgvEditarCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditarCategoria.Size = new System.Drawing.Size(234, 230);
            this.dgvEditarCategoria.TabIndex = 2;
            this.dgvEditarCategoria.SelectionChanged += new System.EventHandler(this.dgvEditarCategoria_SelectionChanged);
            // 
            // btnVolverEditarCategoria
            // 
            this.btnVolverEditarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEditarCategoria.Location = new System.Drawing.Point(14, 158);
            this.btnVolverEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverEditarCategoria.Name = "btnVolverEditarCategoria";
            this.btnVolverEditarCategoria.Size = new System.Drawing.Size(182, 42);
            this.btnVolverEditarCategoria.TabIndex = 3;
            this.btnVolverEditarCategoria.Text = "Volver";
            this.btnVolverEditarCategoria.UseVisualStyleBackColor = true;
            this.btnVolverEditarCategoria.Click += new System.EventHandler(this.btnVolverEditarCategoria_Click);
            // 
            // lblEditCat
            // 
            this.lblEditCat.AutoSize = true;
            this.lblEditCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCat.Location = new System.Drawing.Point(65, 38);
            this.lblEditCat.Name = "lblEditCat";
            this.lblEditCat.Size = new System.Drawing.Size(79, 16);
            this.lblEditCat.TabIndex = 4;
            this.lblEditCat.Text = "Descripción";
            // 
            // FormEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 258);
            this.Controls.Add(this.lblEditCat);
            this.Controls.Add(this.btnVolverEditarCategoria);
            this.Controls.Add(this.dgvEditarCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.textBoxEditarCategoria);
            this.Location = new System.Drawing.Point(251, 126);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(478, 297);
            this.MinimumSize = new System.Drawing.Size(478, 297);
            this.Name = "FormEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar categoría";
            this.Load += new System.EventHandler(this.FormEditarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.DataGridView dgvEditarCategoria;
        private System.Windows.Forms.Button btnVolverEditarCategoria;
        private System.Windows.Forms.Label lblEditCat;
    }
}