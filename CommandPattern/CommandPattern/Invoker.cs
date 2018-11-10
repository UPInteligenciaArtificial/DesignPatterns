using System;

namespace CommandPattern
{
	/// <summary>
	/// The invoker class.
	/// </summary>
	public class Invoker
	{
		/// <summary>
		/// Invoke the specified command.
		/// </summary>
		/// <param name="command">the command to invoke.</param>
		public void Invoke(Command command)
		{
			Console.WriteLine ("Invoker.Invoke(command) called");
			command.Execute();
		}
	}
}
