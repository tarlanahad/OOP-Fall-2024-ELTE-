using System;
namespace BuildingDesctructionProblem
{
	public class BadRadiusException:Exception
	{
		public BadRadiusException():base("You have entered bad value for the radius of a circle")
		{
		}
	}
}

