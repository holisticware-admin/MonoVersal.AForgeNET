// AForge Core Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2007-2011
// contacts@aforgenet.com
//

namespace AForge
{
	using System;
	using System.ComponentModel;

	/// <summary>
	/// Structure for representing a pair of coordinates of integer type.
	/// </summary>
	/// 
	/// <remarks><para>The structure is used to store a pair of integer coordinates.</para>
	/// 
	/// <para>Sample usage:</para>
	/// <code>
	/// // assigning coordinates in the constructor
	/// IntPoint p1 = new IntPoint( 10, 20 );
	/// // creating a point and assigning coordinates later
	/// IntPoint p2;
	/// p2.X = 30;
	/// p2.Y = 40;
	/// // calculating distance between two points
	/// float distance = p1.DistanceTo( p2 );
	/// </code>
	/// </remarks>
	/// 
	[Serializable]
	public partial struct IntPoint
	{
	}    
}
