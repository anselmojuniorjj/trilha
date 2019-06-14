namespace jogoTrilha
{
    partial class Jogo
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
            this.lblG1 = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblG2 = new System.Windows.Forms.Label();
            this.btnRegras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblG1
            // 
            this.lblG1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblG1.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG1.Location = new System.Drawing.Point(90, 42);
            this.lblG1.Name = "lblG1";
            this.lblG1.Size = new System.Drawing.Size(168, 49);
            this.lblG1.TabIndex = 0;
            this.lblG1.Text = "Jogador 1";
            this.lblG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVS
            // 
            this.lblVS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblVS.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(508, 42);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(168, 49);
            this.lblVS.TabIndex = 1;
            this.lblVS.Text = "VS";
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblG2
            // 
            this.lblG2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblG2.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG2.Location = new System.Drawing.Point(1019, 42);
            this.lblG2.Name = "lblG2";
            this.lblG2.Size = new System.Drawing.Size(168, 49);
            this.lblG2.TabIndex = 2;
            this.lblG2.Text = "Jogador 2";
            this.lblG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegras
            // 
            this.btnRegras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegras.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegras.Location = new System.Drawing.Point(22, 613);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(188, 51);
            this.btnRegras.TabIndex = 3;
            this.btnRegras.Text = "Regras";
            this.btnRegras.UseVisualStyleBackColor = true;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1278, 714);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.lblG2);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblG1);
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblG1;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblG2;
        private System.Windows.Forms.Button btnRegras;
    }
}