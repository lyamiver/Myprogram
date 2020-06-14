using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ближайшие_точки
{
    class Ближайшие_точки
    {
        public static void Main()
        {
            GetInputData(out var points);

            var result = Solve(points);

            PrintResult(result);
        }

        private static void GetInputData(out Point[] points)
        {
            var n = int.Parse(Console.ReadLine());
            var coordinates = Console.ReadLine().Split();

            points = new Point[n];
            for (var i = 0; i < n; i++)
            {
                points[i] = new Point(i + 1, int.Parse(coordinates[i]));
            }
        }

        public static Result Solve(Point[] points)
        {
            var result = new Result();

            Array.Sort(points, new PointComparer());

            var min = int.MaxValue;
            for (var i = 0; i < points.Length - 1; i++)
            {
                var distance = points[i + 1].Coordinate - points[i].Coordinate;
                if (distance < min)
                {
                    min = distance;
                    result.Point1 = points[i];
                    result.Point2 = points[i + 1];
                }

                if (min == 1)
                {
                    break;
                }
            }

            return result;
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result.Distance);
            Console.WriteLine($"{result.Point1} {result.Point2}");
        }

        public struct Point
        {
            public int Number { get; }

            public int Coordinate { get; }

            public Point(int number, int coordinate)
            {
                Number = number;
                Coordinate = coordinate;
            }

            public override string ToString() => $"{Number}";
        }

        public class Result
        {
            public Point Point1 { get; set; }

            public Point Point2 { get; set; }

            public int Distance => Math.Abs(Point2.Coordinate - Point1.Coordinate);
        }

        private class PointComparer : IComparer<Point>
        {
            public int Compare(Point x, Point y)
            {
                return x.Coordinate.CompareTo(y.Coordinate);
            }
        }
    }

}

