//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Varigence Ast Designer tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.  Do not edit this file unless you know exactly
//     you are doing and are synchronized with the Vulcan development team.
//
//     For more information about the Varigence Ast Designer tool, email
//     support@varigence.com.
//
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Collections.Specialized;
using Vulcan.Utility.ComponentModel;
using AstFramework;
using AstFramework.Engine.Binding;
using AstFramework.Model;
using AstFramework.Markup;
using VulcanEngine.AstFramework;
using Vulcan.Utility.Collections;
using System.Reflection;
using System.Collections.Generic;
using Vulcan.Utility.Xml;
using Vulcan.Utility.Common;
using Vulcan.Utility.Markup;

namespace VulcanEngine.IR.Ast.Table
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("MultipleColumnTableReference")]
    [AstSchemaTypeBindingAttribute("", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstMultipleColumnTableReferenceNode : VulcanEngine.IR.Ast.Table.AstMultipleColumnTableReferenceBaseNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Table.AstTableNode _table;
        private bool __isNotFirstSet__table;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"Specifies the name of a table to reference.  This creates a column matching the type of the primary key of the referenced table and also creates a foreign key constraint on the referenced table.")]
        [Browsable(false)]
        [AstXNameBinding("TableName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Table.AstTableNode Table
        {
            get { return _table; }
            set
            {
                if (_table != value || !__isNotFirstSet__table)
                {
                    __isNotFirstSet__table = true;
                    if (_table != null)
                    {
                        _table.Unreference(this, "Table");
                    }
                    VulcanEngine.IR.Ast.Table.AstTableNode oldValue = _table;
                    _table = value;
                    if (_table != null)
                    {
                        _table.Reference(this, "Table");
                    }
                    VulcanOnPropertyChanged("Table", oldValue, _table);
                }
            }
        }


        #endregion Public Accessor Properties

        #region Collection Methods

        #endregion Collection Methods

        #region Initialization
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private void InitializeAstNode()
        {
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());

            return definedAstNodes;
        }


        public override IEnumerable<IScopeBoundary> BindingScopeBoundaries()
        {
            var bindingScopeBoundaries = new List<IScopeBoundary>();
            bindingScopeBoundaries.Add(ScopeBoundary);
            return bindingScopeBoundaries;
        }


        #region Cloning Support
        public override IFrameworkItem Clone()
        {
            return Clone(ParentItem);
        }

        public override IFrameworkItem Clone(Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            return Clone(ParentItem, cloneMapping);
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem)
        {
            return Clone(parentItem, new Dictionary<IFrameworkItem, IFrameworkItem>());
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            SymbolTable.GetSourceToCloneDefinitionMappings(this, parentItem, cloneMapping);
            CloneInto(cloneMapping[this], cloneMapping);
            return cloneMapping[this];
        }

        public override void CloneInto(IFrameworkItem targetItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            base.CloneInto(targetItem, cloneMapping);
            if (targetItem == null || !typeof(AstMultipleColumnTableReferenceNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstMultipleColumnTableReferenceNode)targetItem;
            if (_table == null)
            {
                castedTargetItem._table = null;
            }
            else if (cloneMapping.ContainsKey(_table))
            {
                castedTargetItem._table = (VulcanEngine.IR.Ast.Table.AstTableNode)cloneMapping[_table];
            }
            else
            {
                castedTargetItem._table = _table;
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstMultipleColumnTableReferenceNode(parentItem);
        }

        #endregion Cloning Support


    }
}
