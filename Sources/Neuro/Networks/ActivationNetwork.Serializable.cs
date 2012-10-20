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
    /// Activation network.
    /// </summary>
    /// 
    /// <remarks><para>Activation network is a base for multi-layer neural network
    /// with activation functions. It consists of <see cref="ActivationLayer">activation
    /// layers</see>.</para>
    ///
    /// <para>Sample usage:</para>
    /// <code>
    /// // create activation network
    ///	ActivationNetwork network = new ActivationNetwork(
    ///		new SigmoidFunction( ), // sigmoid activation function
    ///		3,                      // 3 inputs
    ///		4, 1 );                 // 2 layers:
    ///                             // 4 neurons in the firs layer
    ///                             // 1 neuron in the second layer
    ///	</code>
    /// </remarks>
    /// 
    [Serializable]
    public partial class ActivationNetwork 
    {
    }
}
