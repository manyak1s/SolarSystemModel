using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationalSystemModel
{
    /// <summary>
    /// класс небесное тело
    /// </summary>
    public class Body
    {
        /// <summary>
        /// конструктор класса без параметров
        /// </summary>
        public Body()
        {

        }


        /// <summary>
        // Открытые свойства для доступа к полям 
        /// </summary>

        /// скорость по оси Х
        public double VelX
        {
            get
            {
                return vx;
            }

            set
            {
                vx = value;
            }
        }

        /// скорость по оси У
        public double VelY
        {
            get
            {
                return vy;
            }

            set
            {
                vy = value;
            }
        }

        /// имя небесного тела
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// сила по оси Х
        public double ForceX
        {
            get
            {
                return forcex;
            }

            set
            {
                forcex = value;
            }
        }

        /// сила по оси У
        public double ForceY
        {
            get
            {
                return forcey;
            }

            set
            {
                forcey = value;
            }
        }

        /// масса небесного тела
        public double Mass
        {
            get
            {
                return mass;
            }

            set
            {
                mass = value;
            }
        }
        /// <summary>
        /// координата X
        /// </summary>
        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        /// <summary>
        /// координата Y
        /// </summary>
        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        /// <summary>
        /// цвет небесного тела
        /// </summary>
        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        /// <summary>
        /// радиус 
        /// </summary>
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }


        /// <summary>
        /// радиус орбиты
        /// </summary>
        public double OrbitRadius
        {
            get
            {
                return orbitRadius;
            }

            set
            {
                orbitRadius = value;
            }
        }

        string name; // имя небесного тела
        double x, y;    // позиция
        double vx, vy; // скорость
        double mass; // масса небесного тела
        double forcex, forcey; // сила
        double radius;
        double orbitRadius;
        Color color; // цвет 
    }
}

