// AForge Core Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © Andrew Kirillov, 2007-2009
// andrew.kirillov@aforgenet.com
//

namespace AForge
{
	using System;

	/// <summary>
	/// Represents an integer range with minimum and maximum values.
	/// </summary>
	/// 
	/// <remarks>
	/// <para>The class represents an integer range with inclusive limits -
	/// both minimum and maximum values of the range are included into it.
	/// Mathematical notation of such range is <b>[min, max]</b>.</para>
	/// 
	/// <para>Sample usage:</para>
	/// <code>
	/// // create [1, 10] range
	/// IntRange range1 = new IntRange( 1, 10 );
	/// // create [5, 15] range
	/// IntRange range2 = new IntRange( 5, 15 );
	/// // check if values is inside of the first range
	/// if ( range1.IsInside( 7 ) )
	/// {
	///     // ...
	/// }
	/// // check if the second range is inside of the first range
	/// if ( range1.IsInside( range2 ) )
	/// {
	///     // ...
	/// }
	/// // check if two ranges overlap
	/// if ( range1.IsOverlapping( range2 ) )
	/// {
	///     // ...
	/// }
	/// </code>
	/// </remarks>
	///
	[Serializable]
	public partial struct IntRange
	{
	}
}
