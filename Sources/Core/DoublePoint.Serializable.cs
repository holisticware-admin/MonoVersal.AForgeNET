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
    /// Structure for representing a pair of coordinates of double type.
    /// </summary>
    /// 
    /// <remarks><para>The structure is used to store a pair of floating point
    /// coordinates with double precision.</para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // assigning coordinates in the constructor
    /// DoublePoint p1 = new DoublePoint( 10, 20 );
    /// // creating a point and assigning coordinates later
    /// DoublePoint p2;
    /// p2.X = 30;
    /// p2.Y = 40;
    /// // calculating distance between two points
    /// double distance = p1.DistanceTo( p2 );
    /// </code>
    /// </remarks>
    /// 
    [Serializable]
    public partial struct DoublePoint
    {
    }
}
