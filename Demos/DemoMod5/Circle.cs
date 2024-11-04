using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
	public class Circle
	{
		private double radius;

		public double Radius
		{
			get { return radius; }
			set
			{
				if (value >= 0)
				{
					radius = value;
				}
				else
				{
					//throw new ArgumentException("Radius cant be negative");
					//throw new InvalidRadiusException(); // calls non parameterized constructor
					throw new InvalidRadiusException(value); // calls parameterized constructor
				}
			}
		}
		public Circle() { }
		public Circle(double radius) 
		{
			this.Radius = radius;
		}
		public override string ToString()
		{
			return $"Circle with {radius}";

		}
	}
}
