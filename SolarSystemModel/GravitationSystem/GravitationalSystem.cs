using System;

namespace GravitationalSystemModel
{
    /// <summary>
    /// класс гравитационная система 
    /// задачи класса
    /// 1) Вычисление всех сил действующих на тело используя закон Всемирного тяготения Ньютона.
    ///2) Вычисление ускорения для каждого тела, через суммы сил действующих на него,
    ///используя второй закон Ньютона о движении a = F / m
    ///3)Вычисление для каждого тела новой скорости через ускорение
    ///4) Вычисление для каждого тела новой позиции через скорость

    /// </summary>

    public class GravitationalSystem
    {

        // длина вектора
        public double CalculateVectorLength(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        // вычислить расстояние между телами 
        public double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = (x1 - x2);
            double dy = (y1 - y2);
            return CalculateVectorLength(dx ,  dy);
        }


        // посчитать все силы действующие на все тела
        public void CalculateForces()
        {

            // посчитать все силы действующие на тело
            foreach (var body in bodies)
            {
                // очистить текущие силы
                body.ForceX = 0.0;
                body.ForceY = 0.0;
                foreach (var other in bodies)
                {
                    //  не сравнивать с самим собой
                    if (body == other )
                        continue;
                    // вычислить силу от одного тела
                    var p = CalculateForceFromTo(other, body);
                    // и сложить в общую кучу
                    body.ForceX += p.Item1;
                    body.ForceY += p.Item2;
                }
            }

    
        }

        //посчитать силу действующую на  тело другим телом.
        public Tuple<double, double> CalculateForceFromTo(Body from, Body to)
        {
            // вычислить расстояние между телами 
            double dx = (from.X - to.X);
            double dy = (from.Y - to.Y);
            double d = Math.Sqrt(dx * dx + dy * dy);
    
            // Сообщить об ошибке при столкновении тел
            if (Math.Abs(d - 0.0) <= 0.0000001)
                throw new InvalidOperationException("Collision between objects "
                         + to.Name + " and " + from.Name);

            // Compute the force of attraction
            //  вычислить силу притяжения используя закон Всемирного тяготения Ньютона
            double f = G * to.Mass * from.Mass / (d * d);

            // Compute the direction of the force.
            // вычислить направления силы
            double theta = Math.Atan2(dy, dx);
            double fx = Math.Cos(theta) * f;
            double fy = Math.Sin(theta) * f;
            return new Tuple<double, double>(fx, fy);
        }
        //Вычисление ускорения для каждого тела, через суммы сил действующих на него,
        //используя второй закон Ньютона о движении a = F / m
        //Вычисление для каждого тела новой скорости через ускорение 
        //Вычисление для каждого тела новой позиции через скорость
        public void UpdateBodies()
        {
            foreach (var body in bodies)
            {
                // подсчёт ускорения,  второй закон Ньютона a = F / m
                // и обновление скорости
                body.VelX += body.ForceX / body.Mass * Timestep;
                body.VelY += body.ForceY / body.Mass * Timestep;

                // Обновление позиции тела
                body.X += body.VelX * Timestep;
                body.Y += body.VelY * Timestep;
            }

        }

        // обновить счетчик дней и лет
        public void UpdatesDays()
        {
            if (days > 365)
            {
                days = 0;
                years++;
            }
            days++;
        }

        // выполнить все операции за один шаг
        public void AdvansedStep()
        {
            CalculateForces();
            UpdateBodies();
            UpdatesDays();

        }


        /// <summary>
        /// свойство список небесных тел
        /// </summary>


        public OrbitalBodies Bodies
        {
            get
            {
                return bodies;
            }

            set
            {
                bodies = value;
            }
        }



        /// <summary>
        /// свойство коэффициент масштабирования
        /// </summary>


        public double ScaleCoef
        {
            get
            {
                return scaleCoef;
            }

            set
            {
                scaleCoef = value;
            }
        }
        /// <summary>
        /// свойство коэффициент масштабирования
        /// </summary>
        public double CoordCenterX
        {
            get
            {
                return coordCenterX;
            }

            set
            {
                coordCenterX = value;
            }
        }

        public double CoordCenterY
        {
            get
            {
                return coordCenterY;
            }

            set
            {
                coordCenterY = value;
            }
        }


        /// <summary>
        /// свойство координатный центр модели
        /// </summary>
        public int Years
        {
            get
            {
                return years;
            }

            set
            {
                years = value;
            }
        }
        public int Days
        {
            get
            {
                return days;
            }

            set
            {
                days = value;
            }
        }
        /// <summary>
        ///  один шаг за который выполнятся все операции
        /// </summary>
        public double Timestep
        {
            get
            {
                return timestep;
            }

            set
            {
                timestep = value;
            }
        }

        /// <summary>
        /// список небесных тел
        /// </summary>
        OrbitalBodies bodies = new OrbitalBodies();

        /// <summary>
        ///  время за  один шаг 
        /// </summary>
        double timestep = 0;

        /// <summary>
        /// коэффициент масштабирования
        /// </summary>
        double scaleCoef = 0;// Constants.SCALE;

        /// <summary>
        /// координатный центр модели
        /// </summary>
        double coordCenterX = 0;
        double coordCenterY = 0;

        /// <summary>
        /// счётчики земных лет и дней
        /// </summary>
        int days;
        int years;

        // гравитационная постоянная  G
        public const double G = 6.67428e-11;
    }
}



