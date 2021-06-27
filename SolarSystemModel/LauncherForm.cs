using System;
using System.Windows.Forms;

namespace SolarSystemModel
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        MainForm mainForm = new MainForm();
        SunEarthMoonForm triBodyForm = new SunEarthMoonForm();


        // показать форму с солнцем и восемью планетами
        private void buttonSolarSystem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
        }

        // показать форму с тремя телами 
        private void buttonSunEarthMoonSystem_Click(object sender, EventArgs e)
        {
            triBodyForm.Show();
        }
    }
}
