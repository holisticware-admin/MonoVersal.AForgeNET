// AForge Math Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2005-2011
// contacts@aforgenet.com
//

namespace AForge.Math
{
    using System;

    /// <summary>
    /// Histogram for discrete random values.
    /// </summary>
    /// 
    /// <remarks><para>The class wraps histogram for discrete stochastic function, which is represented
    /// by integer array, where indexes of the array are treated as values of the stochastic function,
    /// but array values are treated as "probabilities" (total amount of hits).
    /// </para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // create histogram
    /// Histogram histogram = new Histogram( new int[10] { 0, 0, 1, 3, 6, 8, 11, 0, 0, 0 } );
    /// // get mean and standard deviation values
    /// Console.WriteLine( "mean = " + histogram.Mean + ", std.dev = " + histogram.StdDev );
    /// </code>
    /// </remarks>
    ///
    [Serializable]
    public partial class Histogram
    {
    }
}
