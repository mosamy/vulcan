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
    [AstSchemaTypeBindingAttribute("TransformationSortInputColumnElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstSortColumnNode : VulcanEngine.IR.Ast.AstNamedNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Transformation.SortColumnUsageType InputColumnUsageType_BackingField;
        private bool __isNotFirstSet_InputColumnUsageType_BackingField;
        private bool _isInputColumnUsageTypeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Transformation.SortOrder SortOrder_BackingField;
        private bool __isNotFirstSet_SortOrder_BackingField;
        private bool _isSortOrderExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String OutputAs_BackingField;
        private bool __isNotFirstSet_OutputAs_BackingField;
        private bool _isOutputAsExplicitlySet;

        private VulcanCollection<VulcanEngine.IR.Ast.Transformation.SortComparisonFlag> _comparisonFlags;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("InputColumnUsageType", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Transformation.SortColumnUsageType InputColumnUsageType
        {
            get { return InputColumnUsageType_BackingField; }
            set
            {
                if (InputColumnUsageType_BackingField != value || !__isNotFirstSet_InputColumnUsageType_BackingField)
                {
                    __isNotFirstSet_InputColumnUsageType_BackingField = true;
                    VulcanEngine.IR.Ast.Transformation.SortColumnUsageType oldValue = InputColumnUsageType_BackingField;
                    InputColumnUsageType_BackingField = value;
                    VulcanOnPropertyChanged("InputColumnUsageType", oldValue, InputColumnUsageType_BackingField);
                    IsInputColumnUsageTypeExplicitlySet = true;
                }
            }
        }

        public bool IsInputColumnUsageTypeExplicitlySet
        {
            get { return _isInputColumnUsageTypeExplicitlySet; }
            protected set
            {
                if (_isInputColumnUsageTypeExplicitlySet != value)
                {
                    bool oldValue = _isInputColumnUsageTypeExplicitlySet;
                    _isInputColumnUsageTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsInputColumnUsageTypeExplicitlySet", oldValue, _isInputColumnUsageTypeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("SortOrder", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Transformation.SortOrder SortOrder
        {
            get { return SortOrder_BackingField; }
            set
            {
                if (SortOrder_BackingField != value || !__isNotFirstSet_SortOrder_BackingField)
                {
                    __isNotFirstSet_SortOrder_BackingField = true;
                    VulcanEngine.IR.Ast.Transformation.SortOrder oldValue = SortOrder_BackingField;
                    SortOrder_BackingField = value;
                    VulcanOnPropertyChanged("SortOrder", oldValue, SortOrder_BackingField);
                    IsSortOrderExplicitlySet = true;
                }
            }
        }

        public bool IsSortOrderExplicitlySet
        {
            get { return _isSortOrderExplicitlySet; }
            protected set
            {
                if (_isSortOrderExplicitlySet != value)
                {
                    bool oldValue = _isSortOrderExplicitlySet;
                    _isSortOrderExplicitlySet = value;
                    VulcanOnPropertyChanged("IsSortOrderExplicitlySet", oldValue, _isSortOrderExplicitlySet);
                }
            }
        }


        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("OutputAs", ChildType.Attribute)]
        public System.String OutputAs
        {
            get { return OutputAs_BackingField; }
            set
            {
                if (OutputAs_BackingField != value || !__isNotFirstSet_OutputAs_BackingField)
                {
                    __isNotFirstSet_OutputAs_BackingField = true;
                    System.String oldValue = OutputAs_BackingField;
                    OutputAs_BackingField = value;
                    VulcanOnPropertyChanged("OutputAs", oldValue, OutputAs_BackingField);
                    IsOutputAsExplicitlySet = true;
                }
            }
        }

        public bool IsOutputAsExplicitlySet
        {
            get { return _isOutputAsExplicitlySet; }
            protected set
            {
                if (_isOutputAsExplicitlySet != value)
                {
                    bool oldValue = _isOutputAsExplicitlySet;
                    _isOutputAsExplicitlySet = value;
                    VulcanOnPropertyChanged("IsOutputAsExplicitlySet", oldValue, _isOutputAsExplicitlySet);
                }
            }
        }


        [VulcanCategory("Read Only")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(false)]
        [AstXNameBinding("ComparisonFlag", ChildType.ListChildDefinition)]
        public VulcanCollection<VulcanEngine.IR.Ast.Transformation.SortComparisonFlag> ComparisonFlags
        {
            get { return _comparisonFlags; }
        }


        #endregion Public Accessor Properties

        #region Collection Methods



        private void _comparisonFlags_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanOnCollectionPropertyChanged("ComparisonFlags", e);
        }

        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            _comparisonFlags = new VulcanCollection<VulcanEngine.IR.Ast.Transformation.SortComparisonFlag>();
            _comparisonFlags.CollectionChanged += _comparisonFlags_CollectionChanged;
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
            if (targetItem == null || !typeof(AstSortColumnNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstSortColumnNode)targetItem;
            castedTargetItem.InputColumnUsageType_BackingField = InputColumnUsageType_BackingField;

            castedTargetItem.SortOrder_BackingField = SortOrder_BackingField;

            castedTargetItem.OutputAs_BackingField = OutputAs_BackingField;

            castedTargetItem._comparisonFlags = _comparisonFlags;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstSortColumnNode(parentItem);
        }

        #endregion Cloning Support


    }
}
