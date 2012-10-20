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

	// Just a copy-paste of SVD algorithm from Numerical Recipes but updated for C#
	// (as authors state, the code is aimed to be machine readable, so blame them
	// for all those c/f/g/h/s variable)
	internal partial class svd
	{
		private static void Throw()
		{
			throw new ApplicationException("No convergence in 30 svdcmp iterations");
		}

	}
}
