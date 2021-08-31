﻿using System;

namespace ObjectsDemo
{
    class Car
    {
        public int Model;
        public Car(int a)
        {
            Model = a;
        }
        public void Display_Model()
        {
            Console.WriteLine(Model);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car(22);
            Ford.Model = 10;
            Car BMW = Ford;
            BMW.Display_Model();
            Ford.Display_Model();
        }
    }
}