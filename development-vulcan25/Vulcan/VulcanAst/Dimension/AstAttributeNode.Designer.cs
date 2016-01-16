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

namespace VulcanEngine.IR.Ast.Dimension
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("Attribute")]
    [AstSchemaTypeBindingAttribute("AttributeElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstAttributeNode : VulcanEngine.IR.Ast.Dimension.AstDimensionNamedBaseNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasAttributeUsage AttributeUsage_BackingField;
        private bool _isAttributeUsageExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasOrderBy OrderBy_BackingField;
        private bool _isOrderByExplicitlySet;

        private VulcanEngine.IR.Ast.Dimension.AstAttributeNode _orderByAttribute;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean MemberNamesUnique_BackingField;
        private bool _isMemberNamesUniqueExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 EstimatedCount_BackingField;
        private bool _isEstimatedCountExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean IsAggregatable_BackingField;
        private bool _isIsAggregatableExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean AttributeHierarchyEnabled_BackingField;
        private bool _isAttributeHierarchyEnabledExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean AttributeHierarchyOrdered_BackingField;
        private bool _isAttributeHierarchyOrderedExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasOptimizedState AttributeHierarchyOptimizedState_BackingField;
        private bool _isAttributeHierarchyOptimizedStateExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean AttributeHierarchyVisible_BackingField;
        private bool _isAttributeHierarchyVisibleExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String AttributeHierarchyDisplayFolder_BackingField;
        private bool _isAttributeHierarchyDisplayFolderExplicitlySet;

        private VulcanCollection<VulcanEngine.IR.Ast.Dimension.AstAttributeKeyColumnNode> _keyColumns;

        private VulcanEngine.IR.Ast.Dimension.AstAttributeNameColumnNode _nameColumn;

        private VulcanEngine.IR.Ast.Dimension.AstAttributeValueColumnNode _valueColumn;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasAttributeUsage.Regular)]
        [VulcanDescription(@"Indicates how an attribute is used. The default setting is Regular. Other possible settings are Key and Parent.")]
        [Browsable(true)]
        [AstXNameBinding("Usage", ChildType.Attribute, DefaultValue = "Regular")]
        public VulcanEngine.IR.Ast.Cube.SsasAttributeUsage AttributeUsage
        {
            get { return AttributeUsage_BackingField; }
            set
            {
                if (AttributeUsage_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasAttributeUsage oldValue = AttributeUsage_BackingField;
                    AttributeUsage_BackingField = value;
                    VulcanOnPropertyChanged("AttributeUsage", oldValue, AttributeUsage_BackingField);
                    IsAttributeUsageExplicitlySet = true;
                }
            }
        }

        public bool IsAttributeUsageExplicitlySet
        {
            get { return _isAttributeUsageExplicitlySet; }
            protected set
            {
                if (_isAttributeUsageExplicitlySet != value)
                {
                    bool oldValue = _isAttributeUsageExplicitlySet;
                    _isAttributeUsageExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAttributeUsageExplicitlySet", oldValue, _isAttributeUsageExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasOrderBy.Key)]
        [VulcanDescription(@"Specifies the OrderBy")]
        [Browsable(true)]
        [AstXNameBinding("OrderBy", ChildType.Attribute, DefaultValue = "Key")]
        public VulcanEngine.IR.Ast.Cube.SsasOrderBy OrderBy
        {
            get { return OrderBy_BackingField; }
            set
            {
                if (OrderBy_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasOrderBy oldValue = OrderBy_BackingField;
                    OrderBy_BackingField = value;
                    VulcanOnPropertyChanged("OrderBy", oldValue, OrderBy_BackingField);
                    IsOrderByExplicitlySet = true;
                }
            }
        }

        public bool IsOrderByExplicitlySet
        {
            get { return _isOrderByExplicitlySet; }
            protected set
            {
                if (_isOrderByExplicitlySet != value)
                {
                    bool oldValue = _isOrderByExplicitlySet;
                    _isOrderByExplicitlySet = value;
                    VulcanOnPropertyChanged("IsOrderByExplicitlySet", oldValue, _isOrderByExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Defines the ordering of the members contained in the attribute hierarchy. The default setting is Name, indicating that ordering of the attribute members is based on the value of the NameColumn property. If the NameColumn property is left undefined, members are ordered by the value of the Key column. The Key setting indicates ordering by the value of the key column of the attribute member. The AttributeKey setting indicates ordering by the value of the member key of a specified attribute. The AttributeName setting indicates ordering by the value of the member name of a specified attribute.")]
        [Browsable(false)]
        [AstXNameBinding("OrderByAttributeName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Dimension.AstAttributeNode OrderByAttribute
        {
            get { return _orderByAttribute; }
            set
            {
                if (_orderByAttribute != value)
                {
                    if (_orderByAttribute != null)
                    {
                        _orderByAttribute.Unreference(this, "OrderByAttribute");
                    }
                    VulcanEngine.IR.Ast.Dimension.AstAttributeNode oldValue = _orderByAttribute;
                    _orderByAttribute = value;
                    if (_orderByAttribute != null)
                    {
                        _orderByAttribute.Reference(this, "OrderByAttribute");
                    }
                    VulcanOnPropertyChanged("OrderByAttribute", oldValue, _orderByAttribute);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(false)]
        [VulcanDescription(@"Indicates whether or not member names in the attribute hierarchy must be unique.")]
        [Browsable(true)]
        [AstXNameBinding("MemberNameUnique", ChildType.Attribute, DefaultValue = "false")]
        public System.Boolean MemberNamesUnique
        {
            get { return MemberNamesUnique_BackingField; }
            set
            {
                if (MemberNamesUnique_BackingField != value)
                {
                    System.Boolean oldValue = MemberNamesUnique_BackingField;
                    MemberNamesUnique_BackingField = value;
                    VulcanOnPropertyChanged("MemberNamesUnique", oldValue, MemberNamesUnique_BackingField);
                    IsMemberNamesUniqueExplicitlySet = true;
                }
            }
        }

        public bool IsMemberNamesUniqueExplicitlySet
        {
            get { return _isMemberNamesUniqueExplicitlySet; }
            protected set
            {
                if (_isMemberNamesUniqueExplicitlySet != value)
                {
                    bool oldValue = _isMemberNamesUniqueExplicitlySet;
                    _isMemberNamesUniqueExplicitlySet = value;
                    VulcanOnPropertyChanged("IsMemberNamesUniqueExplicitlySet", oldValue, _isMemberNamesUniqueExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(0)]
        [VulcanDescription(@"Indicates the estimated number of items in the attribute. The default setting is zero.")]
        [Browsable(true)]
        [AstXNameBinding("EstimatedCount", ChildType.Attribute, DefaultValue = "0")]
        public System.Int32 EstimatedCount
        {
            get { return EstimatedCount_BackingField; }
            set
            {
                if (EstimatedCount_BackingField != value)
                {
                    System.Int32 oldValue = EstimatedCount_BackingField;
                    EstimatedCount_BackingField = value;
                    VulcanOnPropertyChanged("EstimatedCount", oldValue, EstimatedCount_BackingField);
                    IsEstimatedCountExplicitlySet = true;
                }
            }
        }

        public bool IsEstimatedCountExplicitlySet
        {
            get { return _isEstimatedCountExplicitlySet; }
            protected set
            {
                if (_isEstimatedCountExplicitlySet != value)
                {
                    bool oldValue = _isEstimatedCountExplicitlySet;
                    _isEstimatedCountExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEstimatedCountExplicitlySet", oldValue, _isEstimatedCountExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"Indicates whether or not the values of the attribute members can be aggregated. The default setting is True, which causes the attribute hierarchy to contain an (All) level. If the setting is changed to False, the attribute hierarchy does not contain an (All) level.")]
        [Browsable(true)]
        [AstXNameBinding("IsAggregatable", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean IsAggregatable
        {
            get { return IsAggregatable_BackingField; }
            set
            {
                if (IsAggregatable_BackingField != value)
                {
                    System.Boolean oldValue = IsAggregatable_BackingField;
                    IsAggregatable_BackingField = value;
                    VulcanOnPropertyChanged("IsAggregatable", oldValue, IsAggregatable_BackingField);
                    IsIsAggregatableExplicitlySet = true;
                }
            }
        }

        public bool IsIsAggregatableExplicitlySet
        {
            get { return _isIsAggregatableExplicitlySet; }
            protected set
            {
                if (_isIsAggregatableExplicitlySet != value)
                {
                    bool oldValue = _isIsAggregatableExplicitlySet;
                    _isIsAggregatableExplicitlySet = value;
                    VulcanOnPropertyChanged("IsIsAggregatableExplicitlySet", oldValue, _isIsAggregatableExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"Indicates whether an attribute hierarchy will be generated by SQL Server Analysis Services. When attribute hierarchy is not enabled, the attribute cannot be employed in a user-defined hierarchy, and the attribute hierarchy cannot be referenced in MDX statements.")]
        [Browsable(true)]
        [AstXNameBinding("AttributeHierarchyEnabled", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean AttributeHierarchyEnabled
        {
            get { return AttributeHierarchyEnabled_BackingField; }
            set
            {
                if (AttributeHierarchyEnabled_BackingField != value)
                {
                    System.Boolean oldValue = AttributeHierarchyEnabled_BackingField;
                    AttributeHierarchyEnabled_BackingField = value;
                    VulcanOnPropertyChanged("AttributeHierarchyEnabled", oldValue, AttributeHierarchyEnabled_BackingField);
                    IsAttributeHierarchyEnabledExplicitlySet = true;
                }
            }
        }

        public bool IsAttributeHierarchyEnabledExplicitlySet
        {
            get { return _isAttributeHierarchyEnabledExplicitlySet; }
            protected set
            {
                if (_isAttributeHierarchyEnabledExplicitlySet != value)
                {
                    bool oldValue = _isAttributeHierarchyEnabledExplicitlySet;
                    _isAttributeHierarchyEnabledExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAttributeHierarchyEnabledExplicitlySet", oldValue, _isAttributeHierarchyEnabledExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"Indicates whether or not the attribute hierarchy is ordered. The default setting is True. If an attribute hierarchy will not be used for querying, processing time is improved by changing the setting to False.")]
        [Browsable(true)]
        [AstXNameBinding("AttributeHierarchyOrdered", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean AttributeHierarchyOrdered
        {
            get { return AttributeHierarchyOrdered_BackingField; }
            set
            {
                if (AttributeHierarchyOrdered_BackingField != value)
                {
                    System.Boolean oldValue = AttributeHierarchyOrdered_BackingField;
                    AttributeHierarchyOrdered_BackingField = value;
                    VulcanOnPropertyChanged("AttributeHierarchyOrdered", oldValue, AttributeHierarchyOrdered_BackingField);
                    IsAttributeHierarchyOrderedExplicitlySet = true;
                }
            }
        }

        public bool IsAttributeHierarchyOrderedExplicitlySet
        {
            get { return _isAttributeHierarchyOrderedExplicitlySet; }
            protected set
            {
                if (_isAttributeHierarchyOrderedExplicitlySet != value)
                {
                    bool oldValue = _isAttributeHierarchyOrderedExplicitlySet;
                    _isAttributeHierarchyOrderedExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAttributeHierarchyOrderedExplicitlySet", oldValue, _isAttributeHierarchyOrderedExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasOptimizedState.FullyOptimized)]
        [VulcanDescription(@"Indicates the level of optimization applied to the attribute hierarchy. Selecting the default option will cause the attribute hierarchy to be fully optimized, and SQL Server Analysis Services will build indexes for the attribute hierarchy to enhance query performance. Selecting NotOptimized will mean that no indexes are built for the attribute hierarchy. Choose this option if the attribute hierarchy is not intended for querying, but for another purpose such as the ordering of another attribute hierarchy.")]
        [Browsable(true)]
        [AstXNameBinding("AttributeHierarchyOptimizedState", ChildType.Attribute, DefaultValue = "FullyOptimized")]
        public VulcanEngine.IR.Ast.Cube.SsasOptimizedState AttributeHierarchyOptimizedState
        {
            get { return AttributeHierarchyOptimizedState_BackingField; }
            set
            {
                if (AttributeHierarchyOptimizedState_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasOptimizedState oldValue = AttributeHierarchyOptimizedState_BackingField;
                    AttributeHierarchyOptimizedState_BackingField = value;
                    VulcanOnPropertyChanged("AttributeHierarchyOptimizedState", oldValue, AttributeHierarchyOptimizedState_BackingField);
                    IsAttributeHierarchyOptimizedStateExplicitlySet = true;
                }
            }
        }

        public bool IsAttributeHierarchyOptimizedStateExplicitlySet
        {
            get { return _isAttributeHierarchyOptimizedStateExplicitlySet; }
            protected set
            {
                if (_isAttributeHierarchyOptimizedStateExplicitlySet != value)
                {
                    bool oldValue = _isAttributeHierarchyOptimizedStateExplicitlySet;
                    _isAttributeHierarchyOptimizedStateExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAttributeHierarchyOptimizedStateExplicitlySet", oldValue, _isAttributeHierarchyOptimizedStateExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"Indicates whether or not the attribute hierarchy is visible to client applications. The default setting is True. If the attribute hierarchy is not intended for querying but for another purpose, such as the ordering of another attribute hierarchy, processing time is improved by changing the setting to False.")]
        [Browsable(true)]
        [AstXNameBinding("AttributeHierarchyVisible", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean AttributeHierarchyVisible
        {
            get { return AttributeHierarchyVisible_BackingField; }
            set
            {
                if (AttributeHierarchyVisible_BackingField != value)
                {
                    System.Boolean oldValue = AttributeHierarchyVisible_BackingField;
                    AttributeHierarchyVisible_BackingField = value;
                    VulcanOnPropertyChanged("AttributeHierarchyVisible", oldValue, AttributeHierarchyVisible_BackingField);
                    IsAttributeHierarchyVisibleExplicitlySet = true;
                }
            }
        }

        public bool IsAttributeHierarchyVisibleExplicitlySet
        {
            get { return _isAttributeHierarchyVisibleExplicitlySet; }
            protected set
            {
                if (_isAttributeHierarchyVisibleExplicitlySet != value)
                {
                    bool oldValue = _isAttributeHierarchyVisibleExplicitlySet;
                    _isAttributeHierarchyVisibleExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAttributeHierarchyVisibleExplicitlySet", oldValue, _isAttributeHierarchyVisibleExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Denotes the folder where the associated attribute hierarchy is displayed to end users.")]
        [Browsable(true)]
        [AstXNameBinding("AttributeHierarchyDisplayFolder", ChildType.Attribute)]
        public System.String AttributeHierarchyDisplayFolder
        {
            get { return AttributeHierarchyDisplayFolder_BackingField; }
            set
            {
                if (AttributeHierarchyDisplayFolder_BackingField != value)
                {
                    System.String oldValue = AttributeHierarchyDisplayFolder_BackingField;
                    AttributeHierarchyDisplayFolder_BackingField = value;
                    VulcanOnPropertyChanged("AttributeHierarchyDisplayFolder", oldValue, AttributeHierarchyDisplayFolder_BackingField);
                    IsAttributeHierarchyDisplayFolderExplicitlySet = true;
                }
            }
        }

        public bool IsAttributeHierarchyDisplayFolderExplicitlySet
        {
            get { return _isAttributeHierarchyDisplayFolderExplicitlySet; }
            protected set
            {
                if (_isAttributeHierarchyDisplayFolderExplicitlySet != value)
                {
                    bool oldValue = _isAttributeHierarchyDisplayFolderExplicitlySet;
                    _isAttributeHierarchyDisplayFolderExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAttributeHierarchyDisplayFolderExplicitlySet", oldValue, _isAttributeHierarchyDisplayFolderExplicitlySet);
                }
            }
        }


        [VulcanCategory("Read Only")]
        [AstRequiredProperty]
        [VulcanDescription(@"Specifies the names of the physical columns from the underlying SQL Server table that define the key and granularity for the attribute.  The value of this column for each member is displayed to users unless a value is specified for the NameColumn property.")]
        [Browsable(false)]
        [AstXNameBinding("KeyColumn", ChildType.ListChildDefinition)]
        public VulcanCollection<VulcanEngine.IR.Ast.Dimension.AstAttributeKeyColumnNode> KeyColumns
        {
            get { return _keyColumns; }
        }


        [VulcanCategory("Read Only")]
        [VulcanDescription(@"Indicates the column that provides the display name of the attribute. This column displays an easily comprehensible name to users when the key column value for an attribute member is cryptic or not useful, or when the key column is based on a composite key. The NameColumn property is not used in parent-child hierarchies.")]
        [Browsable(false)]
        [AstXNameBinding("NameColumn", ChildType.ChildDefinition)]
        public VulcanEngine.IR.Ast.Dimension.AstAttributeNameColumnNode NameColumn
        {
            get { return _nameColumn; }
            set
            {
                if (_nameColumn != value)
                {
                    VulcanEngine.IR.Ast.Dimension.AstAttributeNameColumnNode oldValue = _nameColumn;
                    _nameColumn = value;
                    VulcanOnPropertyChanged("NameColumn", oldValue, _nameColumn);
                }
            }
        }


        [VulcanCategory("Read Only")]
        [VulcanDescription(@"Indicates the column that provides the value of the attribute. When the NameColumn element is specified, the same DataItem values are used as default values for the ValueColumn element. When the NameColumn element is not specified and the KeyColumns collection contains an element representing a key column with a string data type, the same DataItem values are used as default values for the ValueColumn element.")]
        [Browsable(false)]
        [AstXNameBinding("ValueColumn", ChildType.ChildDefinition)]
        public VulcanEngine.IR.Ast.Dimension.AstAttributeValueColumnNode ValueColumn
        {
            get { return _valueColumn; }
            set
            {
                if (_valueColumn != value)
                {
                    VulcanEngine.IR.Ast.Dimension.AstAttributeValueColumnNode oldValue = _valueColumn;
                    _valueColumn = value;
                    VulcanOnPropertyChanged("ValueColumn", oldValue, _valueColumn);
                }
            }
        }


        #endregion Public Accessor Properties

        #region Collection Methods











        private void _keyColumns_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanOnCollectionPropertyChanged("KeyColumns", e);
        }



        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            AttributeUsage_BackingField = VulcanEngine.IR.Ast.Cube.SsasAttributeUsage.Regular;
            OrderBy_BackingField = VulcanEngine.IR.Ast.Cube.SsasOrderBy.Key;
            MemberNamesUnique_BackingField = false;
            EstimatedCount_BackingField = 0;
            IsAggregatable_BackingField = true;
            AttributeHierarchyEnabled_BackingField = true;
            AttributeHierarchyOrdered_BackingField = true;
            AttributeHierarchyOptimizedState_BackingField = VulcanEngine.IR.Ast.Cube.SsasOptimizedState.FullyOptimized;
            AttributeHierarchyVisible_BackingField = true;
            _keyColumns = new VulcanCollection<VulcanEngine.IR.Ast.Dimension.AstAttributeKeyColumnNode>();
            _keyColumns.CollectionChanged += _keyColumns_CollectionChanged;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());











            foreach (var item in _keyColumns)
            {
                definedAstNodes.Add(item);
            }

            if (_nameColumn != null)
            {
                definedAstNodes.Add(_nameColumn);
            }

            if (_valueColumn != null)
            {
                definedAstNodes.Add(_valueColumn);
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
            if (targetItem == null || !typeof(AstAttributeNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstAttributeNode)targetItem;
            castedTargetItem.AttributeUsage_BackingField = AttributeUsage_BackingField;

            castedTargetItem.OrderBy_BackingField = OrderBy_BackingField;

            if (_orderByAttribute == null)
            {
                castedTargetItem._orderByAttribute = null;
            }
            else if (cloneMapping.ContainsKey(_orderByAttribute))
            {
                castedTargetItem._orderByAttribute = (VulcanEngine.IR.Ast.Dimension.AstAttributeNode)cloneMapping[_orderByAttribute];
            }
            else
            {
                castedTargetItem._orderByAttribute = _orderByAttribute;
            }

            castedTargetItem.MemberNamesUnique_BackingField = MemberNamesUnique_BackingField;

            castedTargetItem.EstimatedCount_BackingField = EstimatedCount_BackingField;

            castedTargetItem.IsAggregatable_BackingField = IsAggregatable_BackingField;

            castedTargetItem.AttributeHierarchyEnabled_BackingField = AttributeHierarchyEnabled_BackingField;

            castedTargetItem.AttributeHierarchyOrdered_BackingField = AttributeHierarchyOrdered_BackingField;

            castedTargetItem.AttributeHierarchyOptimizedState_BackingField = AttributeHierarchyOptimizedState_BackingField;

            castedTargetItem.AttributeHierarchyVisible_BackingField = AttributeHierarchyVisible_BackingField;

            castedTargetItem.AttributeHierarchyDisplayFolder_BackingField = AttributeHierarchyDisplayFolder_BackingField;

            foreach (var item in _keyColumns)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._keyColumns.Add((VulcanEngine.IR.Ast.Dimension.AstAttributeKeyColumnNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

            if (_nameColumn == null)
            {
                castedTargetItem._nameColumn = null;
            }
            else if (cloneMapping.ContainsKey(_nameColumn))
            {
                castedTargetItem._nameColumn = (VulcanEngine.IR.Ast.Dimension.AstAttributeNameColumnNode)cloneMapping[_nameColumn];
                _nameColumn.CloneInto(cloneMapping[_nameColumn], cloneMapping);
            }
            else
            {
                castedTargetItem._nameColumn = _nameColumn;
            }

            if (_valueColumn == null)
            {
                castedTargetItem._valueColumn = null;
            }
            else if (cloneMapping.ContainsKey(_valueColumn))
            {
                castedTargetItem._valueColumn = (VulcanEngine.IR.Ast.Dimension.AstAttributeValueColumnNode)cloneMapping[_valueColumn];
                _valueColumn.CloneInto(cloneMapping[_valueColumn], cloneMapping);
            }
            else
            {
                castedTargetItem._valueColumn = _valueColumn;
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstAttributeNode(parentItem);
        }

        #endregion Cloning Support


    }
}
