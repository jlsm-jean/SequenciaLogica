using System;

namespace SequenciaLogica
{
	class Program
	{
		static void Main(string[] args)
		{
			String[] XY = Console.ReadLine().Split();

			int num1 = 0;
			int num2 = 0;
			int cont1 = 1;
			int cont2 = 0;

			num1 = int.Parse(XY[0]);
			num2 = int.Parse(XY[1]);

			if ((1 < num1 & num1 < 20) && (num2 < 100000))
			{
				for (cont1 = 1; cont1 <= num2; cont1++)
				{
					cont2++;
					if (cont2 == num1)
					{
						Console.WriteLine("{0:D}", cont1);
						cont2 = 0;
					}
					else
					{
						Console.Write("{0:D} ", cont1);
					}
				}
			}
		}
	}
}
