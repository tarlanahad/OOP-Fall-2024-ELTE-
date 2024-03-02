using System;
namespace BuildingDesctructionProblem
{
	public class Point
	{
		private readonly double x, y;

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public double Distance(Point p)
		{
			return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));

        }

		public double getX()
		{
			return this.x;
		}

        public double getY()
        {
            return this.y;
        }
    }
}

