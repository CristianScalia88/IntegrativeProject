﻿namespace Integrative_Project.models
{
    internal class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
