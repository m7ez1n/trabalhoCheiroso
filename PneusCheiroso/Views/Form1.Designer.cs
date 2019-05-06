namespace PneusCheiroso.Views
{
    partial class Form1
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.GridCarro = new System.Windows.Forms.DataGridView();
            this.Envia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(12, 12);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 0;
            // 
            // GridCarro
            // 
            this.GridCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCarro.Location = new System.Drawing.Point(12, 163);
            this.GridCarro.Name = "GridCarro";
            this.GridCarro.Size = new System.Drawing.Size(776, 275);
            this.GridCarro.TabIndex = 1;
            // 
            // Envia
            // 
            this.Envia.Location = new System.Drawing.Point(12, 49);
            this.Envia.Name = "Envia";
            this.Envia.Size = new System.Drawing.Size(75, 23);
            this.Envia.TabIndex = 2;
            this.Envia.Text = "Envia";
            this.Envia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Envia);
            this.Controls.Add(this.GridCarro);
            this.Controls.Add(this.textNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DataGridView GridCarro;
        private System.Windows.Forms.Button Envia;
    }
}