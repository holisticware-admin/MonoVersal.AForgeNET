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
    /// Bipolar sigmoid activation function.
    /// </summary>
    ///
    /// <remarks><para>The class represents bipolar sigmoid activation function with
    /// the next expression:
    /// <code lang="none">
    ///                2
    /// f(x) = ------------------ - 1
    ///        1 + exp(-alpha * x)
    ///
    ///           2 * alpha * exp(-alpha * x )
    /// f'(x) = -------------------------------- = alpha * (1 - f(x)^2) / 2
    ///           (1 + exp(-alpha * x))^2
    /// </code>
    /// </para>
    /// 
    /// <para>Output range of the function: <b>[-1, 1]</b>.</para>
    /// 
    /// <para>Functions graph:</para>
    /// <img src="img/neuro/sigmoid_bipolar.bmp" width="242" height="172" />
    /// </remarks>
    /// 
    [Serializable]
    public partial class BipolarSigmoidFunction : ICloneable
    {
    }
}
