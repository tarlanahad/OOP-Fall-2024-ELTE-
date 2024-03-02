using System;
using TextFile;

namespace BuildingDesctructionProblem{

class Program
    {

        static void Main() {

            TextFileReader reader = new TextFileReader("/Users/tarlanahadli/Documents/ELTE/OOP Fall 2024 (ELTE)/Projects/PointCircle/PointCircle/input.txt");

            reader.ReadDouble(out double c_x);
            reader.ReadDouble(out double c_y);
            reader.ReadDouble(out double c_r);


            Circle circle = new Circle(new Point(c_x, c_y), c_r);

            reader.ReadInt(out int num_devices);

            Point[] points = new Point[num_devices];

            for (int i = 0; i < num_devices; i++)
            {
                reader.ReadDouble(out double p_x);
                reader.ReadDouble(out double p_y);

                points[i] = new Point(p_x, p_y);
            }


            for (int i = 0; i < num_devices; i++)
            {
                if (circle.Contains(points[i])) {
                    Console.WriteLine($"Point index is: {i} | X = {points[i].getX()} | Y = {points[i].getY()}");
                    break;
                }

            }

        }
    }

}