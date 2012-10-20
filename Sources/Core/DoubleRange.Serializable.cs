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

    /// <summary>
    /// Represents a double range with minimum and maximum values.
    /// </summary>
    /// 
    /// <remarks>
    /// <para>The class represents a double range with inclusive limits -
    /// both minimum and maximum values of the range are included into it.
    /// Mathematical notation of such range is <b>[min, max]</b>.</para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // create [0.25, 1.5] range
    /// DoubleRange range1 = new DoubleRange( 0.25, 1.5 );
    /// // create [1.00, 2.25] range
    /// DoubleRange range2 = new DoubleRange( 1.00, 2.25 );
    /// // check if values is inside of the first range
    /// if ( range1.IsInside( 0.75 ) )
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
    public partial struct DoubleRange
    {
    }
}
