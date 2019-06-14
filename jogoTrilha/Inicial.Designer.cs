namespace jogoTrilha
{
    partial class Inicial
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
            this.labelNome = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnI1 = new System.Windows.Forms.Button();
            this.btnI2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNome.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(359, 29);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(530, 103);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Trilha";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnI1
            // 
            this.btnI1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnI1.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI1.Location = new System.Drawing.Point(484, 267);
            this.btnI1.Name = "btnI1";
            this.btnI1.Size = new System.Drawing.Size(246, 54);
            this.btnI1.TabIndex = 1;
            this.btnI1.Text = "Jogar";
            this.btnI1.UseVisualStyleBackColor = true;
            this.btnI1.Click += new System.EventHandler(this.btnI1_Click);
            // 
            // btnI2
            // 
            this.btnI2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnI2.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI2.Location = new System.Drawing.Point(484, 361);
            this.btnI2.Name = "btnI2";
            this.btnI2.Size = new System.Drawing.Size(246, 54);
            this.btnI2.TabIndex = 2;
            this.btnI2.Text = "Regras";
            this.btnI2.UseVisualStyleBackColor = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1278, 714);
            this.Controls.Add(this.btnI2);
            this.Controls.Add(this.btnI1);
            this.Controls.Add(this.labelNome);
            this.Name = "Inicial";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnI2;
        private System.Windows.Forms.Button btnI1;
    }
}

