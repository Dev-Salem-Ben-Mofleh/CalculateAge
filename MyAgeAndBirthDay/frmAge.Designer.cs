namespace MyAgeAndBirthDay
{
    partial class frmAge
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
            this.btnCalu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalu
            // 
            this.btnCalu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalu.Location = new System.Drawing.Point(88, 208);
            this.btnCalu.Name = "btnCalu";
            this.btnCalu.Size = new System.Drawing.Size(116, 49);
            this.btnCalu.TabIndex = 3;
            this.btnCalu.Text = "أحسب عمرك";
            this.btnCalu.UseVisualStyleBackColor = false;
            this.btnCalu.Click += new System.EventHandler(this.btnCalu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(57, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "HappyBirthDay";
            // 
            // frmAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.btnCalu);
            this.Controls.Add(this.label1);
            this.Name = "frmAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalu;
        private System.Windows.Forms.Label label1;
    }
}