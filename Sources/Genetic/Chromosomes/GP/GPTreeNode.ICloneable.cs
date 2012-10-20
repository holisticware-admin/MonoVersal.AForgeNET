// AForge Genetic Library
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © Andrew Kirillov, 2006-2009
// andrew.kirillov@aforgenet.com
//

namespace AForge.Genetic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents tree node of genetic programming tree.
    /// </summary>
    /// 
    /// <remarks><para>In genetic programming a chromosome is represented by a tree, which
    /// is represented by <see cref="GPTreeChromosome"/> class. The <see cref="GPTreeNode"/>
    /// class represents single node of such genetic programming tree.</para>
    /// 
    /// <para>Each node may or may not have children. This means that particular node of a genetic
    /// programming tree may represent its sub tree or even entire tree.</para>
    /// </remarks>
    /// 
    public partial class GPTreeNode : ICloneable
    {
        /// <summary>
        /// Clone the tree node.
        /// </summary>
        /// 
        /// <returns>Returns exact clone of the node.</returns>
        /// 
        public object Clone( )
        {
            GPTreeNode clone = new GPTreeNode( );

            // clone gene
            clone.Gene = this.Gene.Clone( );
            // clone its children
            if ( this.Children != null )
            {
                clone.Children = new List<GPTreeNode>( );
                // clone each child gene
                foreach ( GPTreeNode node in Children )
                {
                    clone.Children.Add( (GPTreeNode) node.Clone( ) );
                }
            }
            return clone;
        }
    }
}
