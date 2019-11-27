using System;

namespace attributeAndReflection
{

    public class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }

        public string Path { get; set; }

        public Photo(string name)
        {
            // Проверка

            Name = name;
        }


    }
}
