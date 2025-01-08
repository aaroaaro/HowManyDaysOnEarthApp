namespace HowManyDaysOnEarth
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalculate = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(413, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 44);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(413, 233);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 44);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(822, 257);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(144, 74);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "EXIT";
            this.lblExit.UseVisualStyleBackColor = false;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(136, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "I\'VE BEEN ON EARTH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "DATE OF BIRTH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATE TODAY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCalculate
            // 
            this.lblCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCalculate.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculate.Location = new System.Drawing.Point(647, 168);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(169, 164);
            this.lblCalculate.TabIndex = 6;
            this.lblCalculate.Text = "DAYS ON EARTH";
            this.lblCalculate.UseVisualStyleBackColor = false;
            this.lblCalculate.Click += new System.EventHandler(this.lblCalculate_Click);
            // 
            // lblReset
            // 
            this.lblReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(822, 168);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(144, 83);
            this.lblReset.TabIndex = 7;
            this.lblReset.Text = "RESET";
            this.lblReset.UseVisualStyleBackColor = false;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "DAYS ON EARTH";
            // 
            // lblLived
            // 
            this.lblLived.BackColor = System.Drawing.SystemColors.Window;
            this.lblLived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLived.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLived.Location = new System.Drawing.Point(413, 286);
            this.lblLived.Name = "lblLived";
            this.lblLived.Size = new System.Drawing.Size(207, 46);
            this.lblLived.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.lblLived);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lblCalculate;
        private System.Windows.Forms.Button lblReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLived;
    }
}

