namespace COMP123_Week14
{
    partial class Namelab
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
            this.Lab08 = new System.Windows.Forms.Label();
            this.InfogroupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AGElabel2 = new System.Windows.Forms.Label();
            this.SUBmitButton = new System.Windows.Forms.Button();
            this.InfogroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab08
            // 
            this.Lab08.AutoSize = true;
            this.Lab08.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab08.Location = new System.Drawing.Point(13, 23);
            this.Lab08.Name = "Lab08";
            this.Lab08.Size = new System.Drawing.Size(99, 39);
            this.Lab08.TabIndex = 0;
            this.Lab08.Text = "Lab8";
            // 
            // InfogroupBox1
            // 
            this.InfogroupBox1.BackColor = System.Drawing.Color.Gray;
            this.InfogroupBox1.Controls.Add(this.AgeTextBox);
            this.InfogroupBox1.Controls.Add(this.AGElabel2);
            this.InfogroupBox1.Controls.Add(this.NametextBox1);
            this.InfogroupBox1.Controls.Add(this.label1);
            this.InfogroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfogroupBox1.Location = new System.Drawing.Point(20, 80);
            this.InfogroupBox1.Name = "InfogroupBox1";
            this.InfogroupBox1.Size = new System.Drawing.Size(593, 244);
            this.InfogroupBox1.TabIndex = 1;
            this.InfogroupBox1.TabStop = false;
            this.InfogroupBox1.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name:";
            // 
            // NametextBox1
            // 
            this.NametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox1.Location = new System.Drawing.Point(219, 27);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(353, 45);
            this.NametextBox1.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(219, 87);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(176, 45);
            this.AgeTextBox.TabIndex = 3;
            // 
            // AGElabel2
            // 
            this.AGElabel2.AutoSize = true;
            this.AGElabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGElabel2.Location = new System.Drawing.Point(7, 87);
            this.AGElabel2.Name = "AGElabel2";
            this.AGElabel2.Size = new System.Drawing.Size(208, 39);
            this.AGElabel2.TabIndex = 2;
            this.AGElabel2.Text = "Enter  AGE:";
            // 
            // SUBmitButton
            // 
            this.SUBmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SUBmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBmitButton.Location = new System.Drawing.Point(453, 375);
            this.SUBmitButton.Name = "SUBmitButton";
            this.SUBmitButton.Size = new System.Drawing.Size(157, 46);
            this.SUBmitButton.TabIndex = 2;
            this.SUBmitButton.Text = "Submit";
            this.SUBmitButton.UseVisualStyleBackColor = false;
            // 
            // Namelab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.SUBmitButton);
            this.Controls.Add(this.InfogroupBox1);
            this.Controls.Add(this.Lab08);
            this.Name = "Namelab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter name";
            this.InfogroupBox1.ResumeLayout(false);
            this.InfogroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab08;
        private System.Windows.Forms.GroupBox InfogroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AGElabel2;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.Button SUBmitButton;
    }
}

