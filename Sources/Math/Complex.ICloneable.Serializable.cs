// AForge Math Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © Andrew Kirillov, 2005-2009
// andrew.kirillov@aforgenet.com
//
// Copyright © Israel Lot, 2008
// israel.lot@gmail.com
//

namespace AForge.Math
{
    using System;
    using System.Text.RegularExpressions;
    using System.Runtime.Serialization;

    /// <summary>
    /// Complex number wrapper class.
    /// </summary>
    /// 
    /// <remarks><para>The class encapsulates complex number and provides
    /// set of different operators to manipulate it, lake adding, subtractio,
    /// multiplication, etc.</para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // define two complex numbers
    /// Complex c1 = new Complex( 3, 9 );
    /// Complex c2 = new Complex( 8, 3 );
    /// // sum
    /// Complex s1 = Complex.Add( c1, c2 );
    /// Complex s2 = c1 + c2;
    /// Complex s3 = c1 + 5;
    /// // difference
    /// Complex d1 = Complex.Subtract( c1, c2 );
    /// Complex d2 = c1 - c2;
    /// Complex d3 = c1 - 2;
    /// </code>
    /// </remarks>
    /// 
    public partial struct Complex : ICloneable, ISerializable
    {
		#region ICloneable Members
		/// <summary>
		/// Creates an exact copy of this <see cref="Complex"/> object.
		/// </summary>
		/// 
		/// <returns>Returns clone of the complex number.</returns>
		///
		/// 
		object ICloneable.Clone( )
		{
			return new Complex( this );
		}
		#endregion


        #region ISerializable Members
        /// <summary>
        /// Populates a <see cref="SerializationInfo"/> with the data needed to serialize the target object.
        /// </summary>
        /// 
        /// <param name="info">The <see cref="SerializationInfo"/> to populate with data. </param>
        /// <param name="context">The destination (see <see cref="StreamingContext"/>) for this serialization.</param>
        /// 
        public void GetObjectData( SerializationInfo info, StreamingContext context )
        {
            info.AddValue( "Real", this.Re );
            info.AddValue( "Imaginary", this.Im );
        }
        #endregion
    }
}