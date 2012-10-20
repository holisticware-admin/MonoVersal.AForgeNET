// AForge Math Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2007-2011
// contacts@aforgenet.com
//

namespace AForge.Math.Geometry
{
	using System;
	using AForge;

	/// <summary>
	/// The class encapsulates 2D line and provides some tool methods related to lines.
	/// </summary>
	/// 
	/// <remarks><para>The class provides some methods which are related to lines:
	/// angle between lines, distance to point, finding intersection point, etc.
	/// </para>
	/// 
	/// <para>Generally, the equation of the line is y = <see cref="Slope"/> * x + 
	/// <see cref="Intercept"/>. However, when <see cref="Slope"/> is an Infinity,
	/// <see name="Intercept"/> would normally be meaningless, and it would be
	/// impossible to distinguish the line x = 5 from the line x = -5. Therefore,
	/// if <see cref="Slope"/> is <see cref="float.PositiveInfinity"/> or
	/// <see cref="float.NegativeInfinity"/>, the line's equation is instead 
	/// x = <see cref="Intercept"/>.</para>
	/// 
	/// <para>Sample usage:</para>
	/// <code>
	/// // create a line
	/// Line line = Line.FromPoints( new Point( 0, 0 ), new Point( 3, 4 ) );
	/// // check if it is vertical or horizontal
	/// if ( line.IsVertical || line.IsHorizontal )
	/// {
	///     // ...
	/// }
	/// 
	/// // get intersection point with another line
	/// Point intersection = line.GetIntersectionWith(
	///     Line.FromPoints( new Point( 3, 0 ), new Point( 0, 4 ) ) );
	/// </code>
	/// </remarks>
	/// 
	public sealed partial class Line
	{
		private static void Throw(float radius)
		{
			throw new ArgumentOutOfRangeException("radius" + radius.ToString(), "Must be non-negative");
		}
	}
}
