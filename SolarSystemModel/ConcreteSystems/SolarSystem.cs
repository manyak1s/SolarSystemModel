using System;
using System.Collections.Generic;
using System.Drawing;
using GravitationalSystemModel;


namespace SolarSystemModel
{
    public class SolarSystem : GravitationalSystem, IDrawable
    {
        public  SolarSystem()
        {
            Bodies = CreateBodies();
        }

        // создание списка тел для системы 
        OrbitalBodies CreateBodies()
        {
            var sun = new Body
            {
                Name = "Sun",
                Mass = Constants.Masses["SUN"],
                Color = Color.OrangeRed,
                Radius = 69500000000 / 2
            };


            var mercury = new Body
            {
                Name = "Mercury",
                Mass = Constants.Masses["MERCURY"],
                X = Constants.Distance["MERCURY"],
                VelY = Constants.Velocities["MERCURY"],
                Radius = 2400000000,
                Color = Color.Gray
            };

            mercury.OrbitRadius = mercury.X;

            var venus = new Body
            {
                Name = "Venus",
                Mass = Constants.Masses["VENUS"],
                X = Constants.Distance["VENUS"],
                VelY = Constants.Velocities["VENUS"],
                Radius = 6100000000,
                Color = Color.LightYellow
            };
            venus.OrbitRadius = venus.X;
            var earth = new Body
            {
                Name = "Earth",
                Mass = Constants.Masses["EARTH"],
                X = Constants.Distance["EARTH"],
                VelY = Constants.Velocities["EARTH"],
                Radius = 6400000000,
                Color = Color.LightBlue
            };
            earth.OrbitRadius = earth.X;



            var mars = new Body
            {
                Name = "Mars",
                Mass = Constants.Masses["MARS"],
                X = Constants.Distance["MARS"],
                VelY = Constants.Velocities["MARS"],
                Radius = 3400000000,
                Color = Color.Red
            };

            mars.OrbitRadius = mars.X;
            var jupiter = new Body
            {
                Name = "Jupiter",
                Mass = Constants.Masses["JUPITER"],
                X = Constants.Distance["JUPITER"],
                VelY = Constants.Velocities["JUPITER"],
                Radius = 71000000000,
                Color = Color.Orange
            };
            jupiter.OrbitRadius = jupiter.X;
            var saturn = new Body()
            {
                Name = "Saturn",
                Mass = Constants.Masses["SATURN"],
                X = Constants.Distance["SATURN"],
                VelY = Constants.Velocities["SATURN"],
                Radius = 60000000000,
                Color = Color.LightGoldenrodYellow
            };
            saturn.OrbitRadius = saturn.X;
            var uranus = new Body()
            {
                Name = "Uranus",
                Mass = Constants.Masses["URANUS"],
                X = Constants.Distance["URANUS"],
                VelY = Constants.Velocities["URANUS"],
              
                Radius = 26000000000,
                Color = Color.LightSkyBlue
            };
            uranus.OrbitRadius = uranus.X;
            var neptune = new Body()
            {
                Name = "Neptune",
                Mass = Constants.Masses["NEPTUNE"],
                X = Constants.Distance["NEPTUNE"],
                VelY = Constants.Velocities["NEPTUNE"],

                Radius = 25000000000,
                Color = Color.LightBlue
            };
            neptune.OrbitRadius = neptune.X;

            OrbitalBodies localBodies = new OrbitalBodies { sun,
                mercury,
                venus,
                earth,
                mars,
                jupiter,
                saturn,
                uranus,
                neptune
            };

            return localBodies;
        }
        public void Draw(Graphics graphics, bool orbitVisible, bool namesVisible)
        {
            // нарисовать на панели сколько дней и лет прошло после запуска модели
            graphics.DrawString("Земных лет: " + Years, font, Brushes.White, 10, 20);
            graphics.DrawString("Земных дней: " + Days, font, Brushes.White, 10, 50);
         //   graphics.DrawString("Орбитальная скорость, км/с: ", font, Brushes.White, 10, 80);
            //graphics.DrawString("Земля. Скорость по оси Y: " + Bodies["Earth"].VelY, font, Brushes.White, 10, 110);

         //   int shift = 110;
            // для всех тел 
            foreach (var body in Bodies)
            {
                //graphics.DrawString(body.Name +": " + CalculateVectorLength(body.VelX, body.VelY), font, Brushes.White, 10, shift);
                //shift += 30;

                // установить координаты относительно масштаба 
                // и координатного центра
                var x = (float)(body.X * ScaleCoef);
                var y = (float)(body.Y * ScaleCoef);
                x += (float)CoordCenterX;
                y += (float)CoordCenterY;

                // вычислить длину орбиты в пикселях 
                var orbitR = (float)CalculateDistance(CoordCenterX, CoordCenterY, x, y);

                // нарисовать орбиты
                // если орбита должна быть видна 
                // и радиус орбиты больше 50 пикселей 
                if (orbitVisible && orbitR > 50)
                {
                    graphics.DrawEllipse(new Pen(body.Color, 1), (float)CoordCenterX - orbitR, (float)CoordCenterY - orbitR, orbitR * 2, orbitR * 2);
                }

                // вычислить радиус тела в пикселях 
                var bodyRadius = (float)(body.Radius * ScaleCoef);


                if (body.Name == "Sun" && bodyRadius < 50)
                    bodyRadius = 50;

                // нарисовать тела 
                graphics.FillEllipse(new SolidBrush(body.Color), x - bodyRadius, y - bodyRadius, bodyRadius * 2, bodyRadius * 2);

                // отобразить названия планет 
                if (namesVisible)
                {
                    if (body.Name == "Sun" )
                      
                            graphics.DrawString(body.Name, font, Brushes.White, x + bodyRadius, y - bodyRadius);
                        else
                          if ( orbitR > 50)
                        graphics.DrawString(body.Name, font, Brushes.White, x + bodyRadius, y + bodyRadius);
                }

            }


        }

        /// <summary>
        /// шрифт, чтобы каждый раз не пересоздавать
        /// </summary>
        Font font = new Font("Arial", 12);

    }

}

