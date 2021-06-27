using System;
using System.Drawing;
using GravitationalSystemModel;

namespace SolarSystemModel
{
    public class SunEarthMoonSystem : GravitationalSystem, IDrawable
    {
        public SunEarthMoonSystem()
        {
            Bodies = CreateBodies();
        }
        // создание списка из трёх тел 
        OrbitalBodies CreateBodies()
        {
            var sun = new Body
            {
                Name = "Sun",
                Mass = Constants.Masses["SUN"], // реальное значение массы
                Radius = 100000000000 / 2,
                Color = Color.Yellow
            };

            var earth = new Body
            {
                Name = "Earth",
                Mass = Constants.Masses["EARTH"], // реальное значение массы 
                X = Constants.Distance["EARTH"], // реальное  расстояние  между землёй и солнцем
                Radius = 10000000000 / 2,
                VelY = Constants.Velocities["EARTH"],
                Color = Color.DeepSkyBlue
            };
            earth.OrbitRadius = earth.X;

            var moon = new Body
            {
                Name = "Moon",
                Mass = Constants.Masses["MOON"], // реальное значение массы
                X = 0.3209 * Constants.AU,
                Radius = 5000000000 / 2,
                VelY = -51 * 1000,
                Color = Color.Silver
            };
            moon.OrbitRadius = moon.X;



            OrbitalBodies localBodies = new OrbitalBodies { sun,
                earth,
                moon ,
            };
            return localBodies;
        }
        public void Draw(Graphics graphics, bool orbitVisible, bool namesVisible)
        {
            var sun = Bodies["Sun"];

            // установить солнце в центре координатной системы
            float sun_x = (float)CoordCenterX;
            float sun_y = (float)CoordCenterY;

            // вычислить радиус для солнца в пикселях 
            float bodyRadius = (float)(sun.Radius * ScaleCoef);

            // нарисовать тело солнца 
            graphics.FillEllipse(new SolidBrush(sun.Color), sun_x - bodyRadius, sun_y - bodyRadius,
                bodyRadius * 2, bodyRadius * 2);

            // отобразить название 
            if (namesVisible)
                graphics.DrawString(sun.Name, font, Brushes.White, sun_x + bodyRadius, sun_y - bodyRadius);

            var earth = Bodies["Earth"];

            // установить землю  относительно центра координатной системы
            var earth_x = (float)(earth.X * ScaleCoef);
            var earth_y = (float)(earth.Y * ScaleCoef);
            earth_x += (float)CoordCenterX;
            earth_y += (float)CoordCenterY;

            // 
            bodyRadius = (float)(earth.Radius * ScaleCoef);

            // вычислить длину орбиты в пикселях 
            var orbitR = (float)CalculateDistance(sun_x, sun_y, earth_x, earth_y);

            // нарисовать орбиту
            if (orbitVisible)
                graphics.DrawEllipse(new Pen(earth.Color, 1), sun_x - orbitR, sun_y - orbitR, orbitR * 2, orbitR * 2);

            // нарисовать тело земли
            graphics.FillEllipse(new SolidBrush(earth.Color),
                earth_x - bodyRadius, earth_y - bodyRadius,
                bodyRadius * 2, bodyRadius * 2);

            // отобразить название 
            if (namesVisible)
                graphics.DrawString(earth.Name, font, Brushes.White, earth_x + bodyRadius, earth_y - bodyRadius * 2);


            var moon = Bodies["Moon"];

            // установить луну   относительно позиции земли
            float mx = (float)(moon.X * ScaleCoef);
            float my = (float)(moon.Y * ScaleCoef);
            mx += earth_x;
            my += earth_y;

            // вычислить радиус для луны в пикселях 
            bodyRadius = (float)(moon.Radius * ScaleCoef);

            // вычислить длину орбиты в пикселях 
            orbitR = (float)CalculateDistance(earth_x, earth_y, mx, my);

            // нарисовать орбиту
            if (orbitVisible)
                graphics.DrawEllipse(new Pen(moon.Color, 1),
             earth_x - orbitR, earth_y - orbitR, orbitR * 2, orbitR * 2);


            // нарисовать тело луны 
            graphics.FillEllipse(new SolidBrush(moon.Color), mx - bodyRadius, my - bodyRadius, bodyRadius * 2, bodyRadius * 2);

            // отобразить название 
            if (namesVisible)
                graphics.DrawString(moon.Name, font, Brushes.White, mx, my);
        }


        /// <summary>
        /// шрифт, чтобы каждый раз не пересоздавать
        /// </summary>
        Font font = new Font("Arial", 12);
    }

}