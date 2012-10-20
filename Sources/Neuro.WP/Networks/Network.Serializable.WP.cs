// AForge Neural Net Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2007-2012
// contacts@aforgenet.com
//

namespace AForge.Neuro
{
	using System;
	using System.IO;
	using System.Runtime.Serialization;

	/// <summary>
	/// Base neural network class.
	/// </summary>
	/// 
	/// <remarks>This is a base neural netwok class, which represents
	/// collection of neuron's layers.</remarks>
	/// 
	public abstract partial class Network
	{
		/// <summary>
		/// Save network to specified file.
		/// </summary>
		/// 
		/// <param name="stream">Stream to save network into.</param>
		/// 
		/// <remarks><para>The neural network is saved using .NET serialization (binary formatter is used).</para></remarks>
		/// 
		public void Save(Stream stream)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Load network from specified file.
		/// </summary>
		/// 
		/// <param name="stream">Stream to load network from.</param>
		/// 
		/// <returns>Returns instance of <see cref="Network"/> class with all properties initialized from file.</returns>
		/// 
		/// <remarks><para>Neural network is loaded from file using .NET serialization (binary formater is used).</para></remarks>
		/// 
		public static Network Load(Stream stream)
		{
			throw new NotImplementedException();

			Network network = default(Network);
			return network;
		}
	}
}
