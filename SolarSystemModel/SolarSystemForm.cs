using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;

using System.Windows.Forms;
using GravitationalSystemModel;


namespace SolarSystemModel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // включить двойную буферизацию для панели 
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           canvas, new object[] { true });

            // установить кисть для фона панели 
            linGrBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, -canvas.ClientRectangle.Height),
                       Color.FromArgb(255, 30, 45, 80), Color.FromArgb(255, 10, 10, 35));

            // подписать панель для рисования на событие вращения колёсика мыши
            canvas.MouseWheel += new MouseEventHandler(canvas_MouseWheel);

        Reset();
   
        }
        SolarSystem solarSystem = new SolarSystem();
        int timerInterval = 0;
        OrbitalBodies bodies = new OrbitalBodies();

        //  кисть для фона панели 
        LinearGradientBrush linGrBrush;


            // сброс всех настроек к первоначальным 
            void Reset()
        {
            solarSystem = new SolarSystem();
            // добавить планеты в солнечную систему
          //  solarSystem.Bodies = CreateBodies();

            //установить для системы один шаг за который выполнятся все операции
            solarSystem.Timestep =  Constants.TIME_STEP;


            // установить для системы коэффициент масштабирования          
            solarSystem.ScaleCoef =  Constants.SCALE;

            // установить центр координатной системы на панели 
            solarSystem.CoordCenterX = canvas.ClientSize.Width / 2;
            solarSystem.CoordCenterY = canvas.ClientSize.Height / 2;

            timer1.Interval = trackBarTimerInterval.Maximum;
            checkBoxOrbitVisible.Checked = checkBoxNamesVisible.Checked = true;
            trackBarZoom.Value = trackBarZoom.Maximum;

            timerInterval = timer1.Interval;
            trackBarTimerInterval.Value = trackBarTimerInterval.Minimum;
            trackBarZoom.Value = trackBarZoom.Maximum;
            trackBarSunMass.Value = 500;
            trackBarMercuryMass.Value = 500;
            trackBarVenusMass.Value = 500;
            trackBarEarthMass.Value = 500;
            trackBarMarsMass.Value = 500;
            trackBarJupiterMass.Value = 500;
            trackBarSaturnMass.Value = 500;
            trackBarUranusMass.Value = 500;
            trackBarNeptuneMass.Value = 500;


            checkBoxNamesVisible.Checked = checkBoxOrbitVisible.Checked = true;
            labelTimerInterval.Text = timerInterval.ToString();
            labelSunMass.Text = solarSystem.Bodies["Sun"].Mass.ToString();
            labelMercuryMass.Text = solarSystem.Bodies["Mercury"].Mass.ToString();
            labelVenusMass.Text = solarSystem.Bodies["Venus"].Mass.ToString();
            labelEarthMass.Text = solarSystem.Bodies["Earth"].Mass.ToString();
            labelMarsMass.Text = solarSystem.Bodies["Mars"].Mass.ToString();
            labelJupiterMass.Text = solarSystem.Bodies["Jupiter"].Mass.ToString();
            labelSaturnMass.Text = solarSystem.Bodies["Saturn"].Mass.ToString();
            labelUranusMass.Text = solarSystem.Bodies["Uranus"].Mass.ToString();
            labelNeptuneMass.Text = solarSystem.Bodies["Neptune"].Mass.ToString();
            labelZoom.Text = (trackBarZoom.Maximum / 250.0 / trackBarZoom.Value).ToString();
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


        // обработчик события тика таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = timerInterval;
            solarSystem.AdvansedStep();
            canvas.Invalidate(); // перерисовать панель
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
            solarSystem.Draw(e.Graphics, checkBoxOrbitVisible.Checked, checkBoxNamesVisible.Checked);
        }

        // обработчик события изменения  масштаба отображения объектов на панели 
        // трекбаром 
        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            double c = Constants.SCALE / trackBarZoom.Maximum;
            solarSystem.ScaleCoef = c * trackBarZoom.Value;
            labelZoom.Text = (trackBarZoom.Maximum / 250.0 / trackBarZoom.Value) .ToString();
            canvas.Invalidate(); // перерисовать панель
        }


        // обработчик события прокрутки колёсика мыши
        private void canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            int step = 30;  // шаг массштабирования
            ((HandledMouseEventArgs)e).Handled = true;//отключить  настройки колёсика мыши заданные по умолчанию
            if (e.Delta > 0)
            {
                if (trackBarZoom.Value + step <= trackBarZoom.Maximum)
                {
                    trackBarZoom.Value+= step;
                }
            }
            else
            {
                if (trackBarZoom.Value - step >= trackBarZoom.Minimum)
                {
                    trackBarZoom.Value-= step;
                }
            }
         
        }
        // форма не закрывается, а скрывается
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        // переменные для перетаскивания 
        private bool Dragging = false;
        private int LastX, LastY;

        // обработчик события перетаскивания на панели 
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!Dragging) return;

                solarSystem.CoordCenterX += e.X - LastX;
                solarSystem.CoordCenterY += e.Y - LastY;
                LastX = e.X;
                LastY = e.Y;

                canvas.Invalidate(); // перерисовать панель
            }
        }

        // при нажатии левой клавиши зафиксировать позицию для перетаскивания
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            LastX = e.X;
            LastY = e.Y;
            Dragging = true;
        }
   

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate(); // перерисовать панель
        }


  
        private void trackBarMass_Scroll(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            var name = trackBar.Name.Replace("Mass","").Replace("trackBar", "");
            var body = solarSystem.Bodies[name];
            var c = Constants.Masses[name.ToUpper()] / (trackBar.Maximum /2);
             body.Mass = trackBar.Value* c;   
            (GetControlByName(groupBoxAllMasses, "label" + name +"Mass") as Label).Text = body.Mass.ToString();
        }

 

        private void trackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            trackBarZoom_Scroll(trackBarZoom, EventArgs.Empty);
        }

        // вспомагательный метод поиска контрола по имени
        public Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            if (ParentCntl.Name == NameToSearch)
                return ParentCntl;

            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                Control ResultCntl = GetControlByName(ChildCntl, NameToSearch);
                if (ResultCntl != null)
                    return ResultCntl;
            }
            return null;
        }
    }
}
