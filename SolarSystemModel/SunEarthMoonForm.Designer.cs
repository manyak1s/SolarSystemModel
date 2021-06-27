namespace SolarSystemModel
{
    partial class SunEarthMoonForm
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
            this.checkBoxNamesVisible = new System.Windows.Forms.CheckBox();
            this.trackBarEarthMass = new System.Windows.Forms.TrackBar();
            this.trackBarSunMass = new System.Windows.Forms.TrackBar();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.trackBarTimerInterval = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkBoxOrbitVisible = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMoonMass = new System.Windows.Forms.Label();
            this.labelEarthMass = new System.Windows.Forms.Label();
            this.labelSunMass = new System.Windows.Forms.Label();
            this.trackBarMoonMass = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelTimerInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEarthMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSunMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoonMass)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxNamesVisible
            // 
            this.checkBoxNamesVisible.AutoSize = true;
            this.checkBoxNamesVisible.Checked = true;
            this.checkBoxNamesVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNamesVisible.Location = new System.Drawing.Point(191, 18);
            this.checkBoxNamesVisible.Name = "checkBoxNamesVisible";
            this.checkBoxNamesVisible.Size = new System.Drawing.Size(126, 17);
            this.checkBoxNamesVisible.TabIndex = 6;
            this.checkBoxNamesVisible.Text = "Показать названия";
            this.checkBoxNamesVisible.UseVisualStyleBackColor = true;
            this.checkBoxNamesVisible.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // trackBarEarthMass
            // 
            this.trackBarEarthMass.Location = new System.Drawing.Point(12, 126);
            this.trackBarEarthMass.Maximum = 1000;
            this.trackBarEarthMass.Minimum = 1;
            this.trackBarEarthMass.Name = "trackBarEarthMass";
            this.trackBarEarthMass.Size = new System.Drawing.Size(324, 45);
            this.trackBarEarthMass.TabIndex = 12;
            this.trackBarEarthMass.Tag = "Earth";
            this.trackBarEarthMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarEarthMass.Value = 500;
            this.trackBarEarthMass.Scroll += new System.EventHandler(this.trackBarEarthMass_Scroll);
            // 
            // trackBarSunMass
            // 
            this.trackBarSunMass.Location = new System.Drawing.Point(6, 44);
            this.trackBarSunMass.Maximum = 1000;
            this.trackBarSunMass.Minimum = 1;
            this.trackBarSunMass.Name = "trackBarSunMass";
            this.trackBarSunMass.Size = new System.Drawing.Size(324, 45);
            this.trackBarSunMass.TabIndex = 11;
            this.trackBarSunMass.Tag = "";
            this.trackBarSunMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSunMass.Value = 500;
            this.trackBarSunMass.Scroll += new System.EventHandler(this.trackBarSunMass_Scroll);
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(12, 44);
            this.trackBarZoom.Maximum = 100;
            this.trackBarZoom.Minimum = 10;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(324, 45);
            this.trackBarZoom.TabIndex = 5;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZoom.Value = 100;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            this.trackBarZoom.ValueChanged += new System.EventHandler(this.trackBarZoom_ValueChanged);
            // 
            // trackBarTimerInterval
            // 
            this.trackBarTimerInterval.Location = new System.Drawing.Point(5, 45);
            this.trackBarTimerInterval.Maximum = 100;
            this.trackBarTimerInterval.Minimum = 1;
            this.trackBarTimerInterval.Name = "trackBarTimerInterval";
            this.trackBarTimerInterval.Size = new System.Drawing.Size(324, 45);
            this.trackBarTimerInterval.TabIndex = 4;
            this.trackBarTimerInterval.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTimerInterval.Value = 1;
            this.trackBarTimerInterval.Scroll += new System.EventHandler(this.trackBarTimerInterval_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelZoom);
            this.groupBox2.Controls.Add(this.trackBarZoom);
            this.groupBox2.Location = new System.Drawing.Point(853, 509);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoom";
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoom.Location = new System.Drawing.Point(94, 26);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(2, 15);
            this.labelZoom.TabIndex = 17;
            this.labelZoom.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(239, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(131, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 31);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkBoxOrbitVisible
            // 
            this.checkBoxOrbitVisible.AutoSize = true;
            this.checkBoxOrbitVisible.Checked = true;
            this.checkBoxOrbitVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOrbitVisible.Location = new System.Drawing.Point(24, 18);
            this.checkBoxOrbitVisible.Name = "checkBoxOrbitVisible";
            this.checkBoxOrbitVisible.Size = new System.Drawing.Size(115, 17);
            this.checkBoxOrbitVisible.TabIndex = 0;
            this.checkBoxOrbitVisible.Text = "Показать орбиты";
            this.checkBoxOrbitVisible.UseVisualStyleBackColor = true;
            this.checkBoxOrbitVisible.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMoonMass);
            this.groupBox1.Controls.Add(this.labelEarthMass);
            this.groupBox1.Controls.Add(this.labelSunMass);
            this.groupBox1.Controls.Add(this.trackBarMoonMass);
            this.groupBox1.Controls.Add(this.trackBarEarthMass);
            this.groupBox1.Controls.Add(this.trackBarSunMass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(853, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Масса, кг";
            // 
            // labelMoonMass
            // 
            this.labelMoonMass.AutoSize = true;
            this.labelMoonMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMoonMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoonMass.Location = new System.Drawing.Point(94, 187);
            this.labelMoonMass.Name = "labelMoonMass";
            this.labelMoonMass.Size = new System.Drawing.Size(2, 15);
            this.labelMoonMass.TabIndex = 16;
            // 
            // labelEarthMass
            // 
            this.labelEarthMass.AutoSize = true;
            this.labelEarthMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEarthMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarthMass.Location = new System.Drawing.Point(94, 108);
            this.labelEarthMass.Name = "labelEarthMass";
            this.labelEarthMass.Size = new System.Drawing.Size(2, 15);
            this.labelEarthMass.TabIndex = 15;
            // 
            // labelSunMass
            // 
            this.labelSunMass.AutoSize = true;
            this.labelSunMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSunMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunMass.Location = new System.Drawing.Point(94, 26);
            this.labelSunMass.Name = "labelSunMass";
            this.labelSunMass.Size = new System.Drawing.Size(2, 15);
            this.labelSunMass.TabIndex = 14;
            // 
            // trackBarMoonMass
            // 
            this.trackBarMoonMass.Location = new System.Drawing.Point(12, 205);
            this.trackBarMoonMass.Maximum = 1000;
            this.trackBarMoonMass.Minimum = 1;
            this.trackBarMoonMass.Name = "trackBarMoonMass";
            this.trackBarMoonMass.Size = new System.Drawing.Size(324, 45);
            this.trackBarMoonMass.TabIndex = 13;
            this.trackBarMoonMass.Tag = "Moon";
            this.trackBarMoonMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMoonMass.Value = 500;
            this.trackBarMoonMass.Scroll += new System.EventHandler(this.trackBarMoonMass_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Луна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Земля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Солнце";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canvas.Location = new System.Drawing.Point(8, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(828, 632);
            this.canvas.TabIndex = 4;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(2, 577);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 273);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Скорости планет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-41, -102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Земных лет";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Location = new System.Drawing.Point(853, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 66);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxNamesVisible);
            this.groupBox5.Controls.Add(this.checkBoxOrbitVisible);
            this.groupBox5.Location = new System.Drawing.Point(853, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 49);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelTimerInterval);
            this.groupBox6.Controls.Add(this.trackBarTimerInterval);
            this.groupBox6.Location = new System.Drawing.Point(853, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 96);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Интервал таймера, миллисекунд";
            // 
            // labelTimerInterval
            // 
            this.labelTimerInterval.AutoSize = true;
            this.labelTimerInterval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimerInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerInterval.Location = new System.Drawing.Point(94, 27);
            this.labelTimerInterval.Name = "labelTimerInterval";
            this.labelTimerInterval.Size = new System.Drawing.Size(2, 15);
            this.labelTimerInterval.TabIndex = 18;
            // 
            // SunEarthMoonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 669);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "SunEarthMoonForm";
            this.Text = "Модель Солнце-Земля-Луна";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TriBodyForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEarthMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSunMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoonMass)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNamesVisible;
        private System.Windows.Forms.TrackBar trackBarEarthMass;
        private System.Windows.Forms.TrackBar trackBarSunMass;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.TrackBar trackBarTimerInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox checkBoxOrbitVisible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarMoonMass;
        private System.Windows.Forms.Label labelSunMass;
        private System.Windows.Forms.Label labelEarthMass;
        private System.Windows.Forms.Label labelMoonMass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelTimerInterval;
    }
}