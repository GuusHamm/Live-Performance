namespace GuusHamm__S22
{
    partial class MissionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHope = new System.Windows.Forms.RadioButton();
            this.rbSin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPoliceNeeded = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gbSIN = new System.Windows.Forms.GroupBox();
            this.gbHope = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbShip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudReadingY = new System.Windows.Forms.NumericUpDown();
            this.nudReadingX = new System.Windows.Forms.NumericUpDown();
            this.gbReading = new System.Windows.Forms.GroupBox();
            this.nudReadingReading = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpReading = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoliceNeeded)).BeginInit();
            this.gbSIN.SuspendLayout();
            this.gbHope.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadingX)).BeginInit();
            this.gbReading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadingReading)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSin);
            this.groupBox1.Controls.Add(this.rbHope);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbHope
            // 
            this.rbHope.AutoSize = true;
            this.rbHope.Checked = true;
            this.rbHope.Location = new System.Drawing.Point(7, 20);
            this.rbHope.Name = "rbHope";
            this.rbHope.Size = new System.Drawing.Size(88, 17);
            this.rbHope.TabIndex = 0;
            this.rbHope.TabStop = true;
            this.rbHope.Text = "Hope mission";
            this.rbHope.UseVisualStyleBackColor = true;
            this.rbHope.CheckedChanged += new System.EventHandler(this.rbHope_CheckedChanged);
            // 
            // rbSin
            // 
            this.rbSin.AutoSize = true;
            this.rbSin.Location = new System.Drawing.Point(7, 44);
            this.rbSin.Name = "rbSin";
            this.rbSin.Size = new System.Drawing.Size(77, 17);
            this.rbSin.TabIndex = 1;
            this.rbSin.Text = "Sin mission";
            this.rbSin.UseVisualStyleBackColor = true;
            this.rbSin.CheckedChanged += new System.EventHandler(this.rbSin_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.gbSIN);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.nudX);
            this.groupBox2.Controls.Add(this.nudY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 495);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(6, 134);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(187, 20);
            this.tbDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(6, 179);
            this.nudX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(54, 20);
            this.nudX.TabIndex = 6;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(75, 179);
            this.nudY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(52, 20);
            this.nudY.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // nudPoliceNeeded
            // 
            this.nudPoliceNeeded.Location = new System.Drawing.Point(6, 42);
            this.nudPoliceNeeded.Name = "nudPoliceNeeded";
            this.nudPoliceNeeded.Size = new System.Drawing.Size(120, 20);
            this.nudPoliceNeeded.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PoliceNeeded";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "CreateMission";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbSIN
            // 
            this.gbSIN.Controls.Add(this.label4);
            this.gbSIN.Controls.Add(this.nudPoliceNeeded);
            this.gbSIN.Enabled = false;
            this.gbSIN.Location = new System.Drawing.Point(7, 408);
            this.gbSIN.Name = "gbSIN";
            this.gbSIN.Size = new System.Drawing.Size(187, 77);
            this.gbSIN.TabIndex = 2;
            this.gbSIN.TabStop = false;
            this.gbSIN.Text = "groupBox4";
            // 
            // gbHope
            // 
            this.gbHope.Controls.Add(this.label8);
            this.gbHope.Controls.Add(this.cbShip);
            this.gbHope.Controls.Add(this.label6);
            this.gbHope.Controls.Add(this.dtpEnd);
            this.gbHope.Controls.Add(this.label5);
            this.gbHope.Controls.Add(this.dtpStart);
            this.gbHope.Location = new System.Drawing.Point(12, 244);
            this.gbHope.Name = "gbHope";
            this.gbHope.Size = new System.Drawing.Size(200, 149);
            this.gbHope.TabIndex = 9;
            this.gbHope.TabStop = false;
            this.gbHope.Text = "groupBox4";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(0, 31);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "StartDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "EndDate";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(0, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(655, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mission Presets";
            // 
            // cbShip
            // 
            this.cbShip.FormattingEnabled = true;
            this.cbShip.Location = new System.Drawing.Point(0, 122);
            this.cbShip.Name = "cbShip";
            this.cbShip.Size = new System.Drawing.Size(193, 21);
            this.cbShip.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Schip";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbReading);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(219, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 374);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Reading";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Y";
            // 
            // nudReadingY
            // 
            this.nudReadingY.Location = new System.Drawing.Point(78, 38);
            this.nudReadingY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudReadingY.Name = "nudReadingY";
            this.nudReadingY.Size = new System.Drawing.Size(52, 20);
            this.nudReadingY.TabIndex = 8;
            // 
            // nudReadingX
            // 
            this.nudReadingX.Location = new System.Drawing.Point(9, 38);
            this.nudReadingX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudReadingX.Name = "nudReadingX";
            this.nudReadingX.Size = new System.Drawing.Size(54, 20);
            this.nudReadingX.TabIndex = 6;
            // 
            // gbReading
            // 
            this.gbReading.Controls.Add(this.button2);
            this.gbReading.Controls.Add(this.label12);
            this.gbReading.Controls.Add(this.label11);
            this.gbReading.Controls.Add(this.dtpReading);
            this.gbReading.Controls.Add(this.nudReadingReading);
            this.gbReading.Controls.Add(this.label9);
            this.gbReading.Controls.Add(this.button1);
            this.gbReading.Controls.Add(this.nudReadingY);
            this.gbReading.Controls.Add(this.nudReadingX);
            this.gbReading.Controls.Add(this.label10);
            this.gbReading.Enabled = false;
            this.gbReading.Location = new System.Drawing.Point(224, 24);
            this.gbReading.Name = "gbReading";
            this.gbReading.Size = new System.Drawing.Size(200, 229);
            this.gbReading.TabIndex = 9;
            this.gbReading.TabStop = false;
            this.gbReading.Text = "groupBox4";
            // 
            // nudReadingReading
            // 
            this.nudReadingReading.Location = new System.Drawing.Point(9, 80);
            this.nudReadingReading.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudReadingReading.Name = "nudReadingReading";
            this.nudReadingReading.Size = new System.Drawing.Size(54, 20);
            this.nudReadingReading.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Reading";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "CaptureDate";
            // 
            // dtpReading
            // 
            this.dtpReading.Location = new System.Drawing.Point(0, 124);
            this.dtpReading.Name = "dtpReading";
            this.dtpReading.Size = new System.Drawing.Size(200, 20);
            this.dtpReading.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete Reading";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbHope);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MissionForm";
            this.Text = "MissionForm";
            this.Load += new System.EventHandler(this.MissionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoliceNeeded)).EndInit();
            this.gbSIN.ResumeLayout(false);
            this.gbSIN.PerformLayout();
            this.gbHope.ResumeLayout(false);
            this.gbHope.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudReadingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadingX)).EndInit();
            this.gbReading.ResumeLayout(false);
            this.gbReading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReadingReading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSin;
        private System.Windows.Forms.RadioButton rbHope;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPoliceNeeded;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbHope;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.GroupBox gbSIN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbShip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbReading;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpReading;
        private System.Windows.Forms.NumericUpDown nudReadingReading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudReadingY;
        private System.Windows.Forms.NumericUpDown nudReadingX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}