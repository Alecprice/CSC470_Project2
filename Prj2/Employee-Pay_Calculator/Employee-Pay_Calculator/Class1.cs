using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Pay_Calculator
{
	class Employee
	{
		private String firstName;
		private String lastName;
		private int age;
		private double hourlyRate;
		private double OT = 1.5;
		private double weeklyPay;
		private double defaultWorkWeek = 40;
		private double hoursWorked;
		private double formula1;
		private double formula2;

		public Employee()
		{
			Console.WriteLine("This is the default constructor");
		}

		public void employeeValues(String firstName, String lastName, int age, double hourlyRate, double hoursWorked)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.hourlyRate = hourlyRate;
			this.hoursWorked = hoursWorked;
			
			

		}

		public double calc()
		{
			formula1 = (hoursWorked - defaultWorkWeek) * (hourlyRate * OT);
			formula2 = (defaultWorkWeek * hourlyRate);

			return formula1 + formula2;
		}

	}
}
