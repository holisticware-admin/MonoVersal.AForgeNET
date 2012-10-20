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

    /// <summary>
    /// Threshold activation function.
    /// </summary>
    ///
    /// <remarks><para>The class represents threshold activation function with
    /// the next expression:
    /// <code lang="none">
    /// f(x) = 1, if x >= 0, otherwise 0
    /// </code>
    /// </para>
    /// 
    /// <para>Output range of the function: <b>[0, 1]</b>.</para>
    /// 
    /// <para>Functions graph:</para>
    /// <img src="img/neuro/threshold.bmp" width="242" height="172" />
    /// </remarks>
    ///
    [Serializable]
	public partial class ThresholdFunction : ICloneable
    {
    }
}
