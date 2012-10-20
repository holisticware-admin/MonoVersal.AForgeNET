// AForge Math Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2007-2011
// contacts@aforgenet.com
//

namespace AForge.Math
{
    using System;

    /// <summary>
    /// Histogram for continuous random values.
    /// </summary>
    /// 
    /// <remarks><para>The class wraps histogram for continuous stochastic function, which is represented
    /// by integer array and range of the function. Values of the integer array are treated
    /// as total amount of hits on the corresponding subranges, which are calculated by splitting the
    /// specified range into required amount of consequent ranges.</para>
    /// 
    /// <para>For example, if the integer array is equal to { 1, 2, 4, 8, 16 } and the range is set
    /// to [0, 1], then the histogram consists of next subranges:
    /// <list type="bullet">
    /// <item>[0.0, 0.2] - 1 hit;</item>
    /// <item>[0.2, 0.4] - 2 hits;</item>
    /// <item>[0.4, 0.6] - 4 hits;</item>
    /// <item>[0.6, 0.8] - 8 hits;</item>
    /// <item>[0.8, 1.0] - 16 hits.</item>
    /// </list>
    /// </para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // create histogram
    /// ContinuousHistogram histogram = new ContinuousHistogram(
    ///     new int[] { 0, 0, 8, 4, 2, 4, 7, 1, 0 }, new Range( 0.0f, 1.0f ) );
    /// // get mean and standard deviation values
    /// Console.WriteLine( "mean = " + histogram.Mean + ", std.dev = " + histogram.StdDev );
    /// </code>
    /// </remarks>
    /// 
    [Serializable]
    public partial class ContinuousHistogram
    {
    }
}
