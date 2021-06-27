namespace SolarSystemModel
{
    partial class MainForm
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
            this.canvas = new System.Windows.Forms.Panel();
            this.groupBoxAllMasses = new System.Windows.Forms.GroupBox();
            this.groupBoxNeptunMass = new System.Windows.Forms.GroupBox();
            this.labelNeptuneMass = new System.Windows.Forms.Label();
            this.trackBarNeptuneMass = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelUranusMass = new System.Windows.Forms.Label();
            this.trackBarUranusMass = new System.Windows.Forms.TrackBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.labelSaturnMass = new System.Windows.Forms.Label();
            this.trackBarSaturnMass = new System.Windows.Forms.TrackBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelJupiterMass = new System.Windows.Forms.Label();
            this.trackBarJupiterMass = new System.Windows.Forms.TrackBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labelMarsMass = new System.Windows.Forms.Label();
            this.trackBarMarsMass = new System.Windows.Forms.TrackBar();
            this.groupBoxEarthMass = new System.Windows.Forms.GroupBox();
            this.labelEarthMass = new System.Windows.Forms.Label();
            this.trackBarEarthMass = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelVenusMass = new System.Windows.Forms.Label();
            this.trackBarVenusMass = new System.Windows.Forms.TrackBar();
            this.groupBoxMercuryMass = new System.Windows.Forms.GroupBox();
            this.labelMercuryMass = new System.Windows.Forms.Label();
            this.trackBarMercuryMass = new System.Windows.Forms.TrackBar();
            this.groupBoxSunMass = new System.Windows.Forms.GroupBox();
            this.labelSunMass = new System.Windows.Forms.Label();
            this.trackBarSunMass = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelTimerInterval = new System.Windows.Forms.Label();
            this.trackBarTimerInterval = new System.Windows.Forms.TrackBar();
            this.checkBoxNamesVisible = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkBoxOrbitVisible = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAllMasses.SuspendLayout();
            this.groupBoxNeptunMass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNeptuneMass)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUranusMass)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturnMass)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJupiterMass)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMarsMass)).BeginInit();
            this.groupBoxEarthMass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEarthMass)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVenusMass)).BeginInit();
            this.groupBoxMercuryMass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMercuryMass)).BeginInit();
            this.groupBoxSunMass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSunMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(944, 611);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // groupBoxAllMasses
            // 
            this.groupBoxAllMasses.Controls.Add(this.groupBoxNeptunMass);
            this.groupBoxAllMasses.Controls.Add(this.groupBox7);
            this.groupBoxAllMasses.Controls.Add(this.groupBox8);
            this.groupBoxAllMasses.Controls.Add(this.groupBox9);
            this.groupBoxAllMasses.Controls.Add(this.groupBox10);
            this.groupBoxAllMasses.Controls.Add(this.groupBoxEarthMass);
            this.groupBoxAllMasses.Controls.Add(this.groupBox5);
            this.groupBoxAllMasses.Controls.Add(this.groupBoxMercuryMass);
            this.groupBoxAllMasses.Controls.Add(this.groupBoxSunMass);
            this.groupBoxAllMasses.Location = new System.Drawing.Point(962, 12);
            this.groupBoxAllMasses.Name = "groupBoxAllMasses";
            this.groupBoxAllMasses.Size = new System.Drawing.Size(317, 774);
            this.groupBoxAllMasses.TabIndex = 1;
            this.groupBoxAllMasses.TabStop = false;
            this.groupBoxAllMasses.Text = "Массы планет, кг";
            // 
            // groupBoxNeptunMass
            // 
            this.groupBoxNeptunMass.Controls.Add(this.labelNeptuneMass);
            this.groupBoxNeptunMass.Controls.Add(this.trackBarNeptuneMass);
            this.groupBoxNeptunMass.Location = new System.Drawing.Point(12, 675);
            this.groupBoxNeptunMass.Name = "groupBoxNeptunMass";
            this.groupBoxNeptunMass.Size = new System.Drawing.Size(289, 76);
            this.groupBoxNeptunMass.TabIndex = 26;
            this.groupBoxNeptunMass.TabStop = false;
            this.groupBoxNeptunMass.Text = "Нептун";
            // 
            // labelNeptuneMass
            // 
            this.labelNeptuneMass.AutoSize = true;
            this.labelNeptuneMass.Location = new System.Drawing.Point(17, 27);
            this.labelNeptuneMass.Name = "labelNeptuneMass";
            this.labelNeptuneMass.Size = new System.Drawing.Size(35, 13);
            this.labelNeptuneMass.TabIndex = 16;
            this.labelNeptuneMass.Text = "label2";
            // 
            // trackBarNeptuneMass
            // 
            this.trackBarNeptuneMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarNeptuneMass.Maximum = 1000;
            this.trackBarNeptuneMass.Minimum = 1;
            this.trackBarNeptuneMass.Name = "trackBarNeptuneMass";
            this.trackBarNeptuneMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarNeptuneMass.TabIndex = 15;
            this.trackBarNeptuneMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarNeptuneMass.Value = 500;
            this.trackBarNeptuneMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelUranusMass);
            this.groupBox7.Controls.Add(this.trackBarUranusMass);
            this.groupBox7.Location = new System.Drawing.Point(12, 593);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(289, 76);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Уран";
            // 
            // labelUranusMass
            // 
            this.labelUranusMass.AutoSize = true;
            this.labelUranusMass.Location = new System.Drawing.Point(17, 27);
            this.labelUranusMass.Name = "labelUranusMass";
            this.labelUranusMass.Size = new System.Drawing.Size(35, 13);
            this.labelUranusMass.TabIndex = 16;
            this.labelUranusMass.Text = "label3";
            // 
            // trackBarUranusMass
            // 
            this.trackBarUranusMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarUranusMass.Maximum = 1000;
            this.trackBarUranusMass.Minimum = 1;
            this.trackBarUranusMass.Name = "trackBarUranusMass";
            this.trackBarUranusMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarUranusMass.TabIndex = 15;
            this.trackBarUranusMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarUranusMass.Value = 500;
            this.trackBarUranusMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.labelSaturnMass);
            this.groupBox8.Controls.Add(this.trackBarSaturnMass);
            this.groupBox8.Location = new System.Drawing.Point(12, 511);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(289, 76);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Сатурн";
            // 
            // labelSaturnMass
            // 
            this.labelSaturnMass.AutoSize = true;
            this.labelSaturnMass.Location = new System.Drawing.Point(17, 27);
            this.labelSaturnMass.Name = "labelSaturnMass";
            this.labelSaturnMass.Size = new System.Drawing.Size(35, 13);
            this.labelSaturnMass.TabIndex = 16;
            this.labelSaturnMass.Text = "label2";
            // 
            // trackBarSaturnMass
            // 
            this.trackBarSaturnMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarSaturnMass.Maximum = 1000;
            this.trackBarSaturnMass.Minimum = 1;
            this.trackBarSaturnMass.Name = "trackBarSaturnMass";
            this.trackBarSaturnMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarSaturnMass.TabIndex = 15;
            this.trackBarSaturnMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSaturnMass.Value = 500;
            this.trackBarSaturnMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelJupiterMass);
            this.groupBox9.Controls.Add(this.trackBarJupiterMass);
            this.groupBox9.Location = new System.Drawing.Point(12, 429);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(289, 76);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Юпитер";
            // 
            // labelJupiterMass
            // 
            this.labelJupiterMass.AutoSize = true;
            this.labelJupiterMass.Location = new System.Drawing.Point(17, 27);
            this.labelJupiterMass.Name = "labelJupiterMass";
            this.labelJupiterMass.Size = new System.Drawing.Size(35, 13);
            this.labelJupiterMass.TabIndex = 16;
            this.labelJupiterMass.Text = "label2";
            // 
            // trackBarJupiterMass
            // 
            this.trackBarJupiterMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarJupiterMass.Maximum = 1000;
            this.trackBarJupiterMass.Minimum = 1;
            this.trackBarJupiterMass.Name = "trackBarJupiterMass";
            this.trackBarJupiterMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarJupiterMass.TabIndex = 15;
            this.trackBarJupiterMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarJupiterMass.Value = 500;
            this.trackBarJupiterMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.labelMarsMass);
            this.groupBox10.Controls.Add(this.trackBarMarsMass);
            this.groupBox10.Location = new System.Drawing.Point(12, 347);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(289, 76);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Марс";
            // 
            // labelMarsMass
            // 
            this.labelMarsMass.AutoSize = true;
            this.labelMarsMass.Location = new System.Drawing.Point(17, 27);
            this.labelMarsMass.Name = "labelMarsMass";
            this.labelMarsMass.Size = new System.Drawing.Size(35, 13);
            this.labelMarsMass.TabIndex = 16;
            this.labelMarsMass.Text = "label2";
            // 
            // trackBarMarsMass
            // 
            this.trackBarMarsMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarMarsMass.Maximum = 1000;
            this.trackBarMarsMass.Minimum = 1;
            this.trackBarMarsMass.Name = "trackBarMarsMass";
            this.trackBarMarsMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarMarsMass.TabIndex = 15;
            this.trackBarMarsMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMarsMass.Value = 500;
            this.trackBarMarsMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBoxEarthMass
            // 
            this.groupBoxEarthMass.Controls.Add(this.labelEarthMass);
            this.groupBoxEarthMass.Controls.Add(this.trackBarEarthMass);
            this.groupBoxEarthMass.Location = new System.Drawing.Point(12, 265);
            this.groupBoxEarthMass.Name = "groupBoxEarthMass";
            this.groupBoxEarthMass.Size = new System.Drawing.Size(289, 76);
            this.groupBoxEarthMass.TabIndex = 21;
            this.groupBoxEarthMass.TabStop = false;
            this.groupBoxEarthMass.Text = "Земля";
            // 
            // labelEarthMass
            // 
            this.labelEarthMass.AutoSize = true;
            this.labelEarthMass.Location = new System.Drawing.Point(17, 27);
            this.labelEarthMass.Name = "labelEarthMass";
            this.labelEarthMass.Size = new System.Drawing.Size(35, 13);
            this.labelEarthMass.TabIndex = 16;
            this.labelEarthMass.Text = "label2";
            // 
            // trackBarEarthMass
            // 
            this.trackBarEarthMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarEarthMass.Maximum = 1000;
            this.trackBarEarthMass.Minimum = 1;
            this.trackBarEarthMass.Name = "trackBarEarthMass";
            this.trackBarEarthMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarEarthMass.TabIndex = 15;
            this.trackBarEarthMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarEarthMass.Value = 500;
            this.trackBarEarthMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelVenusMass);
            this.groupBox5.Controls.Add(this.trackBarVenusMass);
            this.groupBox5.Location = new System.Drawing.Point(12, 183);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 76);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Венера";
            // 
            // labelVenusMass
            // 
            this.labelVenusMass.AutoSize = true;
            this.labelVenusMass.Location = new System.Drawing.Point(17, 27);
            this.labelVenusMass.Name = "labelVenusMass";
            this.labelVenusMass.Size = new System.Drawing.Size(35, 13);
            this.labelVenusMass.TabIndex = 16;
            this.labelVenusMass.Text = "label2";
            // 
            // trackBarVenusMass
            // 
            this.trackBarVenusMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarVenusMass.Maximum = 1000;
            this.trackBarVenusMass.Minimum = 1;
            this.trackBarVenusMass.Name = "trackBarVenusMass";
            this.trackBarVenusMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarVenusMass.TabIndex = 15;
            this.trackBarVenusMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVenusMass.Value = 500;
            this.trackBarVenusMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBoxMercuryMass
            // 
            this.groupBoxMercuryMass.Controls.Add(this.labelMercuryMass);
            this.groupBoxMercuryMass.Controls.Add(this.trackBarMercuryMass);
            this.groupBoxMercuryMass.Location = new System.Drawing.Point(12, 101);
            this.groupBoxMercuryMass.Name = "groupBoxMercuryMass";
            this.groupBoxMercuryMass.Size = new System.Drawing.Size(289, 76);
            this.groupBoxMercuryMass.TabIndex = 19;
            this.groupBoxMercuryMass.TabStop = false;
            this.groupBoxMercuryMass.Text = "Меркурий";
            // 
            // labelMercuryMass
            // 
            this.labelMercuryMass.AutoSize = true;
            this.labelMercuryMass.Location = new System.Drawing.Point(17, 27);
            this.labelMercuryMass.Name = "labelMercuryMass";
            this.labelMercuryMass.Size = new System.Drawing.Size(35, 13);
            this.labelMercuryMass.TabIndex = 16;
            this.labelMercuryMass.Text = "label2";
            // 
            // trackBarMercuryMass
            // 
            this.trackBarMercuryMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarMercuryMass.Maximum = 1000;
            this.trackBarMercuryMass.Minimum = 1;
            this.trackBarMercuryMass.Name = "trackBarMercuryMass";
            this.trackBarMercuryMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarMercuryMass.TabIndex = 15;
            this.trackBarMercuryMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMercuryMass.Value = 500;
            this.trackBarMercuryMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBoxSunMass
            // 
            this.groupBoxSunMass.Controls.Add(this.labelSunMass);
            this.groupBoxSunMass.Controls.Add(this.trackBarSunMass);
            this.groupBoxSunMass.Location = new System.Drawing.Point(12, 19);
            this.groupBoxSunMass.Name = "groupBoxSunMass";
            this.groupBoxSunMass.Size = new System.Drawing.Size(289, 76);
            this.groupBoxSunMass.TabIndex = 18;
            this.groupBoxSunMass.TabStop = false;
            this.groupBoxSunMass.Text = "Солнце";
            // 
            // labelSunMass
            // 
            this.labelSunMass.AutoSize = true;
            this.labelSunMass.Location = new System.Drawing.Point(17, 27);
            this.labelSunMass.Name = "labelSunMass";
            this.labelSunMass.Size = new System.Drawing.Size(35, 13);
            this.labelSunMass.TabIndex = 16;
            this.labelSunMass.Text = "label2";
            // 
            // trackBarSunMass
            // 
            this.trackBarSunMass.Location = new System.Drawing.Point(7, 53);
            this.trackBarSunMass.Maximum = 1000;
            this.trackBarSunMass.Minimum = 1;
            this.trackBarSunMass.Name = "trackBarSunMass";
            this.trackBarSunMass.Size = new System.Drawing.Size(279, 45);
            this.trackBarSunMass.TabIndex = 15;
            this.trackBarSunMass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSunMass.Value = 500;
            this.trackBarSunMass.Scroll += new System.EventHandler(this.trackBarMass_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.checkBoxNamesVisible);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.checkBoxOrbitVisible);
            this.groupBox2.Location = new System.Drawing.Point(206, 632);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 157);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelZoom);
            this.groupBox1.Controls.Add(this.trackBarZoom);
            this.groupBox1.Location = new System.Drawing.Point(9, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Масштаб,  AU (149.6 million km) в одном пикселе";
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
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.AutoSize = false;
            this.trackBarZoom.Location = new System.Drawing.Point(19, 44);
            this.trackBarZoom.Maximum = 1000;
            this.trackBarZoom.Minimum = 10;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(264, 35);
            this.trackBarZoom.TabIndex = 5;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZoom.Value = 1000;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            this.trackBarZoom.ValueChanged += new System.EventHandler(this.trackBarZoom_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelTimerInterval);
            this.groupBox6.Controls.Add(this.trackBarTimerInterval);
            this.groupBox6.Location = new System.Drawing.Point(304, 74);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(289, 76);
            this.groupBox6.TabIndex = 7;
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
            // trackBarTimerInterval
            // 
            this.trackBarTimerInterval.AutoSize = false;
            this.trackBarTimerInterval.Location = new System.Drawing.Point(18, 44);
            this.trackBarTimerInterval.Maximum = 100;
            this.trackBarTimerInterval.Minimum = 1;
            this.trackBarTimerInterval.Name = "trackBarTimerInterval";
            this.trackBarTimerInterval.Size = new System.Drawing.Size(265, 35);
            this.trackBarTimerInterval.TabIndex = 4;
            this.trackBarTimerInterval.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTimerInterval.Value = 1;
            this.trackBarTimerInterval.Scroll += new System.EventHandler(this.trackBarTimerInterval_Scroll);
            // 
            // checkBoxNamesVisible
            // 
            this.checkBoxNamesVisible.AutoSize = true;
            this.checkBoxNamesVisible.Checked = true;
            this.checkBoxNamesVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNamesVisible.Location = new System.Drawing.Point(28, 19);
            this.checkBoxNamesVisible.Name = "checkBoxNamesVisible";
            this.checkBoxNamesVisible.Size = new System.Drawing.Size(126, 17);
            this.checkBoxNamesVisible.TabIndex = 6;
            this.checkBoxNamesVisible.Text = "Показать названия";
            this.checkBoxNamesVisible.UseVisualStyleBackColor = true;
            this.checkBoxNamesVisible.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Location = new System.Drawing.Point(175, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 58);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(287, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(152, 14);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 31);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 31);
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
            this.checkBoxOrbitVisible.Location = new System.Drawing.Point(28, 42);
            this.checkBoxOrbitVisible.Name = "checkBoxOrbitVisible";
            this.checkBoxOrbitVisible.Size = new System.Drawing.Size(115, 17);
            this.checkBoxOrbitVisible.TabIndex = 0;
            this.checkBoxOrbitVisible.Text = "Показать орбиты";
            this.checkBoxOrbitVisible.UseVisualStyleBackColor = true;
            this.checkBoxOrbitVisible.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 793);
            this.Controls.Add(this.groupBoxAllMasses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.canvas);
            this.Name = "MainForm";
            this.Text = "Солнце и восемь планет Солнечной системы ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBoxAllMasses.ResumeLayout(false);
            this.groupBoxNeptunMass.ResumeLayout(false);
            this.groupBoxNeptunMass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNeptuneMass)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUranusMass)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturnMass)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJupiterMass)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMarsMass)).EndInit();
            this.groupBoxEarthMass.ResumeLayout(false);
            this.groupBoxEarthMass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEarthMass)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVenusMass)).EndInit();
            this.groupBoxMercuryMass.ResumeLayout(false);
            this.groupBoxMercuryMass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMercuryMass)).EndInit();
            this.groupBoxSunMass.ResumeLayout(false);
            this.groupBoxSunMass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSunMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimerInterval)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.GroupBox groupBoxAllMasses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox checkBoxOrbitVisible;
        private System.Windows.Forms.TrackBar trackBarSunMass;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.TrackBar trackBarTimerInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxNamesVisible;
        private System.Windows.Forms.GroupBox groupBoxSunMass;
        private System.Windows.Forms.Label labelSunMass;
        private System.Windows.Forms.GroupBox groupBoxEarthMass;
        private System.Windows.Forms.Label labelEarthMass;
        private System.Windows.Forms.TrackBar trackBarEarthMass;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelVenusMass;
        private System.Windows.Forms.TrackBar trackBarVenusMass;
        private System.Windows.Forms.GroupBox groupBoxMercuryMass;
        private System.Windows.Forms.Label labelMercuryMass;
        private System.Windows.Forms.TrackBar trackBarMercuryMass;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelUranusMass;
        private System.Windows.Forms.TrackBar trackBarUranusMass;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label labelSaturnMass;
        private System.Windows.Forms.TrackBar trackBarSaturnMass;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label labelJupiterMass;
        private System.Windows.Forms.TrackBar trackBarJupiterMass;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label labelMarsMass;
        private System.Windows.Forms.TrackBar trackBarMarsMass;
        private System.Windows.Forms.GroupBox groupBoxNeptunMass;
        private System.Windows.Forms.Label labelNeptuneMass;
        private System.Windows.Forms.TrackBar trackBarNeptuneMass;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelTimerInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelZoom;
    }
}