using System;
namespace CarSimulator
{

	public class Test
	{
		static void Main()
		{
			State myTestState = new State(22,23,24,55);
			Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3} \n", myTestState.time, myTestState.acceleration, myTestState.velocity, myTestState.position);
			myTestState.set(1.1, 2, 3, 4);
			Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3} \n", myTestState.time, myTestState.acceleration, myTestState.velocity, myTestState.position);

		}


	}
}