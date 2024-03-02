using System;
namespace BuildingDesctructionProblem
{
	public class Circle
	{
		private readonly Point cp;
		private readonly double r;

		public Circle(Point cp, double r)
		{
			this.cp = cp;
			this.r = r;

			if (r <= 0)
			{
				throw new BadRadiusException();
			}
		}

		public bool Contains(Point p)
		{
			return cp.Distance(p) < this.r;
		}


	}
}

