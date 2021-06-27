using System;
using System.Collections.Generic;

namespace SolarSystemModel
{

    /// <summary>
    /// массы планет 
    /// </summary>
  public  class Masses
    {
        public double this[string name]
        {
            get
            {
               switch (name)
                {
                    case "SUN": return 1.98892 * Math.Pow(10, 30);
                    case "MERCURY": return 0.330 * Math.Pow(10, 24);
                    case "VENUS": return 4.8685 * Math.Pow(10, 24);
                    case "EARTH": return 5.9742 * Math.Pow(10, 24);
                    case "MOON": return 0.073 * Math.Pow(10, 24);
                    case "MARS": return 0.642 * Math.Pow(10, 24);
                    case "JUPITER": return 1899 * Math.Pow(10, 24);
                    case "SATURN": return 568 * Math.Pow(10, 24);
                    case "URANUS": return 868 * Math.Pow(10, 24);
                    case "NEPTUNE": return 102 * Math.Pow(10, 24);
                    default:
                        throw new System.ArgumentOutOfRangeException(name, "Name must be in the form \"SUN\", \"MOON\", etc"); ;
                }
            }
        }
    }

    /// <summary>
    /// орбитальные скорости  планет 
    /// </summary>
    public class Velocities
    {
        public double this[string name]
        {
            get
            {
                switch (name)
                {
                   // case "SUN": return 0;
                    case "MERCURY": return 47.4 * 1000;
                    case "VENUS": return 35.02 * 1000;
                    case "EARTH": return 29.783 * 1000;
                    case "MOON": return 1 * 1000;
                    case "MARS": return 24.13 * 1000;
                    case "JUPITER": return 13.1 * 1000;
                    case "SATURN": return 9.7 * 1000;
                    case "URANUS": return 6.8 * 1000;
                    case "NEPTUNE": return 5.4 * 1000;
                    default:
                        throw new System.ArgumentOutOfRangeException(name, "Name must be in the form \"SUN\", \"MOON\", etc"); ;
                }
            }
        }
    }


    /// <summary>
    /// расстояние до солнца
    /// </summary>
    public class Distance
    {
        public double this[string name]
        {
            get
            {
                switch (name)
                {
                    // case "SUN": return 0;
                    case "MERCURY": return 0.39 * Constants.AU;
                    case "VENUS": return 0.723 * Constants.AU;
                    case "EARTH": return 1 * Constants.AU;
                 //   case "MOON": return 1 * 1000;
                    case "MARS": return 1.524 * Constants.AU;
                    case "JUPITER": return 5.203 * Constants.AU;
                    case "SATURN": return 9.539 * Constants.AU;
                    case "URANUS": return 19.18 * Constants.AU;
                    case "NEPTUNE": return 30.06 * Constants.AU;
                    default:
                        throw new System.ArgumentOutOfRangeException(name, "Name must be in the form \"SUN\", \"MOON\", etc"); ;
                }
            }
        }
    }
    public static class Constants
    {
        public const double TIME_STEP = 24 * 3600;  // один земной день;

        //// гравитационная постоянная  G
        //public const double G = 6.67428e-11;

        // константа для астрономических единиц
        public const double AU = (149.6e6 * 1000);

        // коэффициент масштабирования
        public const double SCALE = (250.0 / AU);

            // константный словарь масс

            private static Masses masses = new Masses();
        private static Distance distance = new Distance();
        private static Velocities velocities = new Velocities();


        public static Masses Masses
        {
            get
            {
                return masses;
            }
        }

        public static Distance Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public static Velocities Velocities
        {
            get
            {
                return velocities;
            }

            set
            {
                velocities = value;
            }
        }
    }
}
