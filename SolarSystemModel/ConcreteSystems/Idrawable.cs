using System;
using System.Drawing;

namespace SolarSystemModel
{/// <summary>
 /// интерфейс предназначен для отрисовки всех тел 
 /// </summary>
    interface IDrawable
    {
        /// <summary>
        /// метод отрисовки
        /// </summary>
        /// <param name="e">объект Graphics</param>
        /// <param name="orbitVisible">отображать ли орбиты </param>
        /// <param name="namesVisible">отображать ли названия тел </param>
        void Draw(Graphics e, bool orbitVisible, bool namesVisible);
    }
}
