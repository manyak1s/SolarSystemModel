using System;
using System.Collections.Generic;

namespace GravitationalSystemModel
{
    /// <summary>
    /// класс коллекция, производный от System.Collections.Generic.List<Body>
    /// создан для упрощения работы с объектами Body
    /// имеет индексатор принимающий в виде индекса строку 
    /// </summary>
    public class OrbitalBodies : List<Body>
    {

        /// <summary>
        /// метод поиска тела в коллекции
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Body GetBody(string name)
        {

            for (int j = 0; j < Count; j++)
            {

                if (this[j].Name == name)
                {
                    // если объект найден, то вернуть его из метода
                    return this[j];
                }
            }
            //если тело не было найдено, то бросается исключение
            throw new System.ArgumentOutOfRangeException(name, "Name must be in the form \"Sun\", \"Moon\", etc");
        }
        /// <summary>
        /// строковый индексатор
        /// </summary>
        /// <param name="name">имя небесного тела</param>
        /// <returns></returns>
        public Body this[string name]
        {
            get { return this.GetBody(name); }
            //   set { Add(name, value); }


        }
    }

}