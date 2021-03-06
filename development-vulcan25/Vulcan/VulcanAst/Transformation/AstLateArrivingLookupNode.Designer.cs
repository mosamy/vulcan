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

namespace VulcanEngine.IR.Ast.Transformation
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("LateArrivingLookup")]
    [AstSchemaTypeBindingAttribute("TransformationLateArrivingLookupElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstLateArrivingLookupNode : VulcanEngine.IR.Ast.Transformation.AstSingleInTransformationNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Table.AstTableNode _table;
        private bool __isNotFirstSet__table;

        private VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode> _inputs;

        private VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode> _outputs;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
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


        [VulcanCategory("Read Only")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(false)]
        [AstXNameBinding("Input", ChildType.ListChildDefinition)]
        public VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode> Inputs
        {
            get { return _inputs; }
        }


        [VulcanCategory("Read Only")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(false)]
        [AstXNameBinding("Output", ChildType.ListChildDefinition)]
        public VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode> Outputs
        {
            get { return _outputs; }
        }


        #endregion Public Accessor Properties

        #region Collection Methods

        private void _inputs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanOnCollectionPropertyChanged("Inputs", e);
        }

        private void _outputs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanOnCollectionPropertyChanged("Outputs", e);
        }

        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            _inputs = new VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode>();
            _inputs.CollectionChanged += _inputs_CollectionChanged;
            _outputs = new VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode>();
            _outputs.CollectionChanged += _outputs_CollectionChanged;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());

            foreach (var item in _inputs)
            {
                definedAstNodes.Add(item);
            }

            foreach (var item in _outputs)
            {
                definedAstNodes.Add(item);
            }

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
            if (targetItem == null || !typeof(AstLateArrivingLookupNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstLateArrivingLookupNode)targetItem;
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

            foreach (var item in _inputs)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._inputs.Add((VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

            foreach (var item in _outputs)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._outputs.Add((VulcanEngine.IR.Ast.Transformation.AstLookupInputOutputNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstLateArrivingLookupNode(parentItem);
        }

        #endregion Cloning Support


    }
}
