using System;
using System.Collections.Generic;

using System.Drawing;
using System.Drawing.Drawing2D;

using System.Reflection;

using System.Windows.Forms;
using GravitationalSystemModel;
namespace SolarSystemModel
{
    public partial class SunEarthMoonForm : Form
    {
        public SunEarthMoonForm()
        {

            InitializeComponent();

            // включить двойную буферизацию для панели 
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           canvas, new object[] { true });

            // установить кисть для фона панели 
            linGrBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, -canvas.ClientRectangle.Height),
                       Color.FromArgb(255, 30, 45, 80),Color.FromArgb(255, 10, 10, 35));

            // подписать панель для рисования на событие вращения колёсика мыши
            canvas.MouseWheel += canvas_MouseWheel;

            Reset();


        }

        // сброс всех настроек к первоначальным 
        void Reset()
        {
            sunEarthMoonSystem = new SunEarthMoonSystem();
     

            // центр координатной системы будет ровно посередине панели 
            sunEarthMoonSystem.CoordCenterX = canvas.ClientSize.Width / 2;
            sunEarthMoonSystem.CoordCenterY = canvas.ClientSize.Height / 2;

            //установить для системы один шаг за который выполнятся все операции
            sunEarthMoonSystem.Timestep = Constants.TIME_STEP;


            // установить для системы коэффициент масштабирования          
            sunEarthMoonSystem.ScaleCoef = Constants.SCALE;

            timerInterval = trackBarTimerInterval.Maximum;
            trackBarTimerInterval.Value = trackBarTimerInterval.Minimum;
            trackBarZoom.Value = trackBarZoom.Maximum;
            trackBarSunMass.Value = 500;
            trackBarEarthMass.Value = 500;
            trackBarMoonMass.Value = 500;
            checkBoxNamesVisible.Checked = checkBoxOrbitVisible.Checked = true;
            labelTimerInterval.Text = timerInterval.ToString();
            labelSunMass.Text = sunEarthMoonSystem.Bodies["Sun"].Mass.ToString();
            labelEarthMass.Text = sunEarthMoonSystem.Bodies["Earth"].Mass.ToString();
            labelMoonMass.Text = sunEarthMoonSystem.Bodies["Moon"].Mass.ToString();
            labelZoom.Text = trackBarZoom.Value.ToString();
        }

        SunEarthMoonSystem sunEarthMoonSystem = new SunEarthMoonSystem();
        int timerInterval = 0;
        // кисть для фона панели 
        LinearGradientBrush linGrBrush;


       


        // обработчик события тика таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = timerInterval;

            // выполнить один цикл системы 
            sunEarthMoonSystem.AdvansedStep();

            canvas.Invalidate(); // перерисовать панель
        }



        private void canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            int step = 10; // шаг массштабирования
            ((HandledMouseEventArgs)e).Handled = true;//отключить  настройки колёсика мыши заданные по умолчанию
            if (e.Delta > 0)
            {
                if (trackBarZoom.Value + step <= trackBarZoom.Maximum)
                {
                    trackBarZoom.Value += step;
                }
            }
            else
            {
                if (trackBarZoom.Value - step >= trackBarZoom.Minimum)
                {
                    trackBarZoom.Value -= step;
                }
            }

        }

        private void trackBarTimerInterval_Scroll(object sender, EventArgs e)
        {
            timerInterval = trackBarTimerInterval.Maximum - trackBarTimerInterval.Value > trackBarTimerInterval.Minimum
                    ? trackBarTimerInterval.Maximum - trackBarTimerInterval.Value : trackBarTimerInterval.Minimum;
            labelTimerInterval.Text = timerInterval.ToString();
        }

        // обработчик события отрисовки панели 
        private void canvas_Paint(object sender, PaintEventArgs e)
        {         
            // закрасить фон панели 
            e.Graphics.FillRectangle(linGrBrush, 0, 0, canvas.ClientRectangle.Width, canvas.ClientRectangle.Height);

            // отрисовать систему 
            sunEarthMoonSystem.Draw(e.Graphics, checkBoxOrbitVisible.Checked, checkBoxNamesVisible.Checked);
        }


        // кнопки запуска, остановки и сброса    
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Reset();
            canvas.Invalidate(); // перерисовать панель
        }

        // установка масштаба  с помощью трекбара 
        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            double c = Constants.SCALE / trackBarZoom.Maximum;
            sunEarthMoonSystem.ScaleCoef = c * trackBarZoom.Value;
            labelZoom.Text = trackBarZoom.Value.ToString();
            canvas.Invalidate(); // перерисовать панель
        }


        // установка чекбоксов 
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate(); // перерисовать панель
        }

        // форма не закрывается совсем, а скрывается
        private void TriBodyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        // установка массы  с помощью трекбара        
        // для солнца 
        private void trackBarSunMass_Scroll(object sender, EventArgs e)
        {
            var sun = sunEarthMoonSystem.Bodies["Sun"];
            var c = Constants.Masses["SUN"] / 500;
            sun.Mass = trackBarSunMass.Value * c;
            labelSunMass.Text = sun.Mass.ToString();
        }


        // установка массы  с помощью трекбара 
        // для земли 
        private void trackBarEarthMass_Scroll(object sender, EventArgs e)
        {
            var earth = sunEarthMoonSystem.Bodies["Earth"];
            var c = Constants.Masses["EARTH"] / 500;
            earth.Mass = trackBarEarthMass.Value * c;
            labelEarthMass.Text = earth.Mass.ToString();
        }

        // установка массы  с помощью трекбара 
        // для луны 
        private void trackBarMoonMass_Scroll(object sender, EventArgs e)
        {
            var moon = sunEarthMoonSystem.Bodies["Moon"];
            var c = Constants.Masses["MOON"] / 500;
            moon.Mass = trackBarMoonMass.Value * c;
            labelMoonMass.Text = moon.Mass.ToString();
        }


        private void trackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            trackBarZoom_Scroll(trackBarZoom, EventArgs.Empty);
        }
    }
}
