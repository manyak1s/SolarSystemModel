namespace SolarSystemModel
{
    partial class LauncherForm
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
            this.buttonSolarSystem = new System.Windows.Forms.Button();
            this.buttonSunEarthMoonSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSolarSystem
            // 
            this.buttonSolarSystem.Location = new System.Drawing.Point(437, 126);
            this.buttonSolarSystem.Name = "buttonSolarSystem";
            this.buttonSolarSystem.Size = new System.Drawing.Size(260, 23);
            this.buttonSolarSystem.TabIndex = 0;
            this.buttonSolarSystem.Text = "Модель Солнечной системы";
            this.buttonSolarSystem.UseVisualStyleBackColor = true;
            this.buttonSolarSystem.Click += new System.EventHandler(this.buttonSolarSystem_Click);
            // 
            // buttonSunEarthMoonSystem
            // 
            this.buttonSunEarthMoonSystem.Location = new System.Drawing.Point(437, 249);
            this.buttonSunEarthMoonSystem.Name = "buttonSunEarthMoonSystem";
            this.buttonSunEarthMoonSystem.Size = new System.Drawing.Size(260, 23);
            this.buttonSunEarthMoonSystem.TabIndex = 1;
            this.buttonSunEarthMoonSystem.Text = "Модель  системы Солнце-Земля-Луна";
            this.buttonSunEarthMoonSystem.UseVisualStyleBackColor = true;
            this.buttonSunEarthMoonSystem.Click += new System.EventHandler(this.buttonSunEarthMoonSystem_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSunEarthMoonSystem);
            this.Controls.Add(this.buttonSolarSystem);
            this.Name = "LauncherForm";
            this.Text = "Модель Солнечной системы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSolarSystem;
        private System.Windows.Forms.Button buttonSunEarthMoonSystem;
    }
}