namespace Paint_calculator
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCoats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCoverage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaint = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudDblDoor = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudSinDoor = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudSmlWindow = new System.Windows.Forms.NumericUpDown();
            this.nudMedWindow = new System.Windows.Forms.NumericUpDown();
            this.nudLrgWindow = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDblDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmlWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLrgWindow)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCoats);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCoverage);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLength);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 214);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dimensions (Metres)";
            // 
            // txtCoats
            // 
            this.txtCoats.Location = new System.Drawing.Point(231, 175);
            this.txtCoats.Name = "txtCoats";
            this.txtCoats.Size = new System.Drawing.Size(100, 22);
            this.txtCoats.TabIndex = 10;
            this.txtCoats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoats_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Number of coats wanted:";
            // 
            // txtCoverage
            // 
            this.txtCoverage.Location = new System.Drawing.Point(231, 147);
            this.txtCoverage.Name = "txtCoverage";
            this.txtCoverage.Size = new System.Drawing.Size(100, 22);
            this.txtCoverage.TabIndex = 8;
            this.txtCoverage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoverage_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Paint coverage in metre squared:\r\n";            
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(118, 101);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 5;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(118, 68);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(119, 36);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length of room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width of room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height of room:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVolume);
            this.groupBox1.Location = new System.Drawing.Point(26, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume of room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Volume of room is:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(37, 47);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(100, 22);
            this.txtVolume.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFloor);
            this.groupBox3.Location = new System.Drawing.Point(259, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 98);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Floor area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Floor area is:";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(51, 47);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.ReadOnly = true;
            this.txtFloor.Size = new System.Drawing.Size(100, 22);
            this.txtFloor.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPaint);
            this.groupBox4.Location = new System.Drawing.Point(690, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 98);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount of paint needed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount of paint needed:";
            // 
            // txtPaint
            // 
            this.txtPaint.Location = new System.Drawing.Point(50, 47);
            this.txtPaint.Name = "txtPaint";
            this.txtPaint.ReadOnly = true;
            this.txtPaint.Size = new System.Drawing.Size(100, 22);
            this.txtPaint.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudDblDoor);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.nudSinDoor);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.nudSmlWindow);
            this.groupBox5.Controls.Add(this.nudMedWindow);
            this.groupBox5.Controls.Add(this.nudLrgWindow);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(413, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 214);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Number of doors/windows";
            // 
            // nudDblDoor
            // 
            this.nudDblDoor.Location = new System.Drawing.Point(270, 160);
            this.nudDblDoor.Name = "nudDblDoor";
            this.nudDblDoor.Size = new System.Drawing.Size(56, 22);
            this.nudDblDoor.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Double doors (Approx 2m Squared):";
            // 
            // nudSinDoor
            // 
            this.nudSinDoor.Location = new System.Drawing.Point(273, 127);
            this.nudSinDoor.Name = "nudSinDoor";
            this.nudSinDoor.Size = new System.Drawing.Size(57, 22);
            this.nudSinDoor.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Single doors (Approx 1m Squared):";
            // 
            // nudSmlWindow
            // 
            this.nudSmlWindow.Location = new System.Drawing.Point(273, 92);
            this.nudSmlWindow.Name = "nudSmlWindow";
            this.nudSmlWindow.Size = new System.Drawing.Size(53, 22);
            this.nudSmlWindow.TabIndex = 5;
            // 
            // nudMedWindow
            // 
            this.nudMedWindow.Location = new System.Drawing.Point(273, 54);
            this.nudMedWindow.Name = "nudMedWindow";
            this.nudMedWindow.Size = new System.Drawing.Size(53, 22);
            this.nudMedWindow.TabIndex = 4;
            // 
            // nudLrgWindow
            // 
            this.nudLrgWindow.Location = new System.Drawing.Point(270, 22);
            this.nudLrgWindow.Name = "nudLrgWindow";
            this.nudLrgWindow.Size = new System.Drawing.Size(56, 22);
            this.nudLrgWindow.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Small windows (Approx 1m squared):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Medium windows (Approx 2m squared):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Large windows (Approx 4m squared):";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtSurface);
            this.groupBox6.Location = new System.Drawing.Point(465, 321);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Surface Area";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Surface area is:";
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(50, 47);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.ReadOnly = true;
            this.txtSurface.Size = new System.Drawing.Size(100, 22);
            this.txtSurface.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 61);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 38);
            this.label9.TabIndex = 16;
            this.label9.Text = "Paint Calculator";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(794, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 64);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Calculate";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 471);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Paint Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDblDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSinDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmlWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLrgWindow)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCoverage;
        private System.Windows.Forms.TextBox txtCoats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudDblDoor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudSinDoor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudSmlWindow;
        private System.Windows.Forms.NumericUpDown nudMedWindow;
        private System.Windows.Forms.NumericUpDown nudLrgWindow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
    }
}

