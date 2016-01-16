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

namespace VulcanEngine.IR.Ast.Fact
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [FriendlyNameAttribute("FactTable")]
    [AstSchemaTypeBindingAttribute("FactElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstFactNode : VulcanEngine.IR.Ast.Table.AstTableNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String MeasureGroupName_BackingField;
        private bool _isMeasureGroupNameExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String AggregationPrefix_BackingField;
        private bool _isAggregationPrefixExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.DataAggregation DataAggregation_BackingField;
        private bool _isDataAggregationExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String Description_BackingField;
        private bool _isDescriptionExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasErrorConfiguration ErrorConfiguration_BackingField;
        private bool _isErrorConfigurationExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 EstimatedRows_BackingField;
        private bool _isEstimatedRowsExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 EstimatedSize_BackingField;
        private bool _isEstimatedSizeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean IgnoreUnrelatedDimensions_BackingField;
        private bool _isIgnoreUnrelatedDimensionsExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String ProactiveCaching_BackingField;
        private bool _isProactiveCachingExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.ProcessingMode ProcessingMode_BackingField;
        private bool _isProcessingModeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 ProcessingPriority_BackingField;
        private bool _isProcessingPriorityExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.StorageMode StorageMode_BackingField;
        private bool _isStorageModeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Measure.MeasureGroupType MeasureGroupType_BackingField;
        private bool _isMeasureGroupTypeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean Visible_BackingField;
        private bool _isVisibleExplicitlySet;

        private VulcanEngine.IR.Ast.Fact.AstMeasureNode _defaultMeasure;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String StorageLocation_BackingField;
        private bool _isStorageLocationExplicitlySet;

        private VulcanCollection<VulcanEngine.IR.Ast.Fact.AstMeasureNode> _measures;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Optional")]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("MeasureGroupName", ChildType.Attribute)]
        public System.String MeasureGroupName
        {
            get { return MeasureGroupName_BackingField; }
            set
            {
                if (MeasureGroupName_BackingField != value)
                {
                    System.String oldValue = MeasureGroupName_BackingField;
                    MeasureGroupName_BackingField = value;
                    VulcanOnPropertyChanged("MeasureGroupName", oldValue, MeasureGroupName_BackingField);
                    IsMeasureGroupNameExplicitlySet = true;
                }
            }
        }

        public bool IsMeasureGroupNameExplicitlySet
        {
            get { return _isMeasureGroupNameExplicitlySet; }
            protected set
            {
                if (_isMeasureGroupNameExplicitlySet != value)
                {
                    bool oldValue = _isMeasureGroupNameExplicitlySet;
                    _isMeasureGroupNameExplicitlySet = value;
                    VulcanOnPropertyChanged("IsMeasureGroupNameExplicitlySet", oldValue, _isMeasureGroupNameExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the prefix that will be used for aggregation names throughout the parent element.")]
        [Browsable(true)]
        [AstXNameBinding("AggregationPrefix", ChildType.Attribute)]
        public System.String AggregationPrefix
        {
            get { return AggregationPrefix_BackingField; }
            set
            {
                if (AggregationPrefix_BackingField != value)
                {
                    System.String oldValue = AggregationPrefix_BackingField;
                    AggregationPrefix_BackingField = value;
                    VulcanOnPropertyChanged("AggregationPrefix", oldValue, AggregationPrefix_BackingField);
                    IsAggregationPrefixExplicitlySet = true;
                }
            }
        }

        public bool IsAggregationPrefixExplicitlySet
        {
            get { return _isAggregationPrefixExplicitlySet; }
            protected set
            {
                if (_isAggregationPrefixExplicitlySet != value)
                {
                    bool oldValue = _isAggregationPrefixExplicitlySet;
                    _isAggregationPrefixExplicitlySet = value;
                    VulcanOnPropertyChanged("IsAggregationPrefixExplicitlySet", oldValue, _isAggregationPrefixExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies whether persisted and cached data can be aggregated. Allowed settings are None (aggregation is not performed), DataAggregatable (persisted data is aggregatable), CacheAggregatable (cached data is aggregatable) and DataAndCacheAggregatable (both persisted data and cached data are aggregatable).")]
        [Browsable(true)]
        [AstXNameBinding("DataAggregation", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Cube.DataAggregation DataAggregation
        {
            get { return DataAggregation_BackingField; }
            set
            {
                if (DataAggregation_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.DataAggregation oldValue = DataAggregation_BackingField;
                    DataAggregation_BackingField = value;
                    VulcanOnPropertyChanged("DataAggregation", oldValue, DataAggregation_BackingField);
                    IsDataAggregationExplicitlySet = true;
                }
            }
        }

        public bool IsDataAggregationExplicitlySet
        {
            get { return _isDataAggregationExplicitlySet; }
            protected set
            {
                if (_isDataAggregationExplicitlySet != value)
                {
                    bool oldValue = _isDataAggregationExplicitlySet;
                    _isDataAggregationExplicitlySet = value;
                    VulcanOnPropertyChanged("IsDataAggregationExplicitlySet", oldValue, _isDataAggregationExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Describes the parent element. This value cannot contain leading/trailing spaces or control characters.")]
        [Browsable(true)]
        [AstXNameBinding("Description", ChildType.Attribute)]
        public System.String Description
        {
            get { return Description_BackingField; }
            set
            {
                if (Description_BackingField != value)
                {
                    System.String oldValue = Description_BackingField;
                    Description_BackingField = value;
                    VulcanOnPropertyChanged("Description", oldValue, Description_BackingField);
                    IsDescriptionExplicitlySet = true;
                }
            }
        }

        public bool IsDescriptionExplicitlySet
        {
            get { return _isDescriptionExplicitlySet; }
            protected set
            {
                if (_isDescriptionExplicitlySet != value)
                {
                    bool oldValue = _isDescriptionExplicitlySet;
                    _isDescriptionExplicitlySet = value;
                    VulcanOnPropertyChanged("IsDescriptionExplicitlySet", oldValue, _isDescriptionExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the ErrorConfiguration")]
        [Browsable(true)]
        [AstXNameBinding("ErrorConfiguration", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Cube.SsasErrorConfiguration ErrorConfiguration
        {
            get { return ErrorConfiguration_BackingField; }
            set
            {
                if (ErrorConfiguration_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasErrorConfiguration oldValue = ErrorConfiguration_BackingField;
                    ErrorConfiguration_BackingField = value;
                    VulcanOnPropertyChanged("ErrorConfiguration", oldValue, ErrorConfiguration_BackingField);
                    IsErrorConfigurationExplicitlySet = true;
                }
            }
        }

        public bool IsErrorConfigurationExplicitlySet
        {
            get { return _isErrorConfigurationExplicitlySet; }
            protected set
            {
                if (_isErrorConfigurationExplicitlySet != value)
                {
                    bool oldValue = _isErrorConfigurationExplicitlySet;
                    _isErrorConfigurationExplicitlySet = value;
                    VulcanOnPropertyChanged("IsErrorConfigurationExplicitlySet", oldValue, _isErrorConfigurationExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(0)]
        [VulcanDescription(@"Specifies the estimated number of child rows represented by the parent element.")]
        [Browsable(true)]
        [AstXNameBinding("EstimatedRows", ChildType.Attribute, DefaultValue = "0")]
        public System.Int32 EstimatedRows
        {
            get { return EstimatedRows_BackingField; }
            set
            {
                if (EstimatedRows_BackingField != value)
                {
                    System.Int32 oldValue = EstimatedRows_BackingField;
                    EstimatedRows_BackingField = value;
                    VulcanOnPropertyChanged("EstimatedRows", oldValue, EstimatedRows_BackingField);
                    IsEstimatedRowsExplicitlySet = true;
                }
            }
        }

        public bool IsEstimatedRowsExplicitlySet
        {
            get { return _isEstimatedRowsExplicitlySet; }
            protected set
            {
                if (_isEstimatedRowsExplicitlySet != value)
                {
                    bool oldValue = _isEstimatedRowsExplicitlySet;
                    _isEstimatedRowsExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEstimatedRowsExplicitlySet", oldValue, _isEstimatedRowsExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(0)]
        [VulcanDescription(@"Specifies the estimated size (inbytes) of the parent element. This value is read-only.")]
        [Browsable(true)]
        [AstXNameBinding("EstimatedSize", ChildType.Attribute, DefaultValue = "0")]
        public System.Int32 EstimatedSize
        {
            get { return EstimatedSize_BackingField; }
            set
            {
                if (EstimatedSize_BackingField != value)
                {
                    System.Int32 oldValue = EstimatedSize_BackingField;
                    EstimatedSize_BackingField = value;
                    VulcanOnPropertyChanged("EstimatedSize", oldValue, EstimatedSize_BackingField);
                    IsEstimatedSizeExplicitlySet = true;
                }
            }
        }

        public bool IsEstimatedSizeExplicitlySet
        {
            get { return _isEstimatedSizeExplicitlySet; }
            protected set
            {
                if (_isEstimatedSizeExplicitlySet != value)
                {
                    bool oldValue = _isEstimatedSizeExplicitlySet;
                    _isEstimatedSizeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEstimatedSizeExplicitlySet", oldValue, _isEstimatedSizeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"This Boolean setting specifies whether unrelated dimensions are forced to their top level when members of unrelated dimensions are included in a query.")]
        [Browsable(true)]
        [AstXNameBinding("IgnoreUnrelatedDimensions", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean IgnoreUnrelatedDimensions
        {
            get { return IgnoreUnrelatedDimensions_BackingField; }
            set
            {
                if (IgnoreUnrelatedDimensions_BackingField != value)
                {
                    System.Boolean oldValue = IgnoreUnrelatedDimensions_BackingField;
                    IgnoreUnrelatedDimensions_BackingField = value;
                    VulcanOnPropertyChanged("IgnoreUnrelatedDimensions", oldValue, IgnoreUnrelatedDimensions_BackingField);
                    IsIgnoreUnrelatedDimensionsExplicitlySet = true;
                }
            }
        }

        public bool IsIgnoreUnrelatedDimensionsExplicitlySet
        {
            get { return _isIgnoreUnrelatedDimensionsExplicitlySet; }
            protected set
            {
                if (_isIgnoreUnrelatedDimensionsExplicitlySet != value)
                {
                    bool oldValue = _isIgnoreUnrelatedDimensionsExplicitlySet;
                    _isIgnoreUnrelatedDimensionsExplicitlySet = value;
                    VulcanOnPropertyChanged("IsIgnoreUnrelatedDimensionsExplicitlySet", oldValue, _isIgnoreUnrelatedDimensionsExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the ProactiveCaching")]
        [Browsable(true)]
        [AstXNameBinding("ProactiveCaching", ChildType.Attribute)]
        public System.String ProactiveCaching
        {
            get { return ProactiveCaching_BackingField; }
            set
            {
                if (ProactiveCaching_BackingField != value)
                {
                    System.String oldValue = ProactiveCaching_BackingField;
                    ProactiveCaching_BackingField = value;
                    VulcanOnPropertyChanged("ProactiveCaching", oldValue, ProactiveCaching_BackingField);
                    IsProactiveCachingExplicitlySet = true;
                }
            }
        }

        public bool IsProactiveCachingExplicitlySet
        {
            get { return _isProactiveCachingExplicitlySet; }
            protected set
            {
                if (_isProactiveCachingExplicitlySet != value)
                {
                    bool oldValue = _isProactiveCachingExplicitlySet;
                    _isProactiveCachingExplicitlySet = value;
                    VulcanOnPropertyChanged("IsProactiveCachingExplicitlySet", oldValue, _isProactiveCachingExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Indicates whether indexing and aggregation takes place during or after processing. The default setting is Regular (both are performed during processing). The other allowed setting is LazyOptimizations (both are performed after processing).")]
        [Browsable(true)]
        [AstXNameBinding("ProcessingMode", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Cube.ProcessingMode ProcessingMode
        {
            get { return ProcessingMode_BackingField; }
            set
            {
                if (ProcessingMode_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.ProcessingMode oldValue = ProcessingMode_BackingField;
                    ProcessingMode_BackingField = value;
                    VulcanOnPropertyChanged("ProcessingMode", oldValue, ProcessingMode_BackingField);
                    IsProcessingModeExplicitlySet = true;
                }
            }
        }

        public bool IsProcessingModeExplicitlySet
        {
            get { return _isProcessingModeExplicitlySet; }
            protected set
            {
                if (_isProcessingModeExplicitlySet != value)
                {
                    bool oldValue = _isProcessingModeExplicitlySet;
                    _isProcessingModeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsProcessingModeExplicitlySet", oldValue, _isProcessingModeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(0)]
        [VulcanDescription(@"Specifies the processing priority of the parent object during background operations, such as lazy aggregation, indexing, or clustering.")]
        [Browsable(true)]
        [AstXNameBinding("ProcessingPriority", ChildType.Attribute, DefaultValue = "0")]
        public System.Int32 ProcessingPriority
        {
            get { return ProcessingPriority_BackingField; }
            set
            {
                if (ProcessingPriority_BackingField != value)
                {
                    System.Int32 oldValue = ProcessingPriority_BackingField;
                    ProcessingPriority_BackingField = value;
                    VulcanOnPropertyChanged("ProcessingPriority", oldValue, ProcessingPriority_BackingField);
                    IsProcessingPriorityExplicitlySet = true;
                }
            }
        }

        public bool IsProcessingPriorityExplicitlySet
        {
            get { return _isProcessingPriorityExplicitlySet; }
            protected set
            {
                if (_isProcessingPriorityExplicitlySet != value)
                {
                    bool oldValue = _isProcessingPriorityExplicitlySet;
                    _isProcessingPriorityExplicitlySet = value;
                    VulcanOnPropertyChanged("IsProcessingPriorityExplicitlySet", oldValue, _isProcessingPriorityExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the OLAP storage mode for the parent element. Allowed values are MOLAP (multidimensional), ROLAP (relational), and HOLAP (hybrid).")]
        [Browsable(true)]
        [AstXNameBinding("StorageMode", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Cube.StorageMode StorageMode
        {
            get { return StorageMode_BackingField; }
            set
            {
                if (StorageMode_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.StorageMode oldValue = StorageMode_BackingField;
                    StorageMode_BackingField = value;
                    VulcanOnPropertyChanged("StorageMode", oldValue, StorageMode_BackingField);
                    IsStorageModeExplicitlySet = true;
                }
            }
        }

        public bool IsStorageModeExplicitlySet
        {
            get { return _isStorageModeExplicitlySet; }
            protected set
            {
                if (_isStorageModeExplicitlySet != value)
                {
                    bool oldValue = _isStorageModeExplicitlySet;
                    _isStorageModeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsStorageModeExplicitlySet", oldValue, _isStorageModeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the type for the MeasureGroup. Allowed values are Regular, ExchangeRate, Sales, Budget, FinancialReporting, Marketing and Inventory.")]
        [Browsable(true)]
        [AstXNameBinding("MeasureGroupType", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Measure.MeasureGroupType MeasureGroupType
        {
            get { return MeasureGroupType_BackingField; }
            set
            {
                if (MeasureGroupType_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Measure.MeasureGroupType oldValue = MeasureGroupType_BackingField;
                    MeasureGroupType_BackingField = value;
                    VulcanOnPropertyChanged("MeasureGroupType", oldValue, MeasureGroupType_BackingField);
                    IsMeasureGroupTypeExplicitlySet = true;
                }
            }
        }

        public bool IsMeasureGroupTypeExplicitlySet
        {
            get { return _isMeasureGroupTypeExplicitlySet; }
            protected set
            {
                if (_isMeasureGroupTypeExplicitlySet != value)
                {
                    bool oldValue = _isMeasureGroupTypeExplicitlySet;
                    _isMeasureGroupTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsMeasureGroupTypeExplicitlySet", oldValue, _isMeasureGroupTypeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"Specifies the visibility of the parent element.")]
        [Browsable(true)]
        [AstXNameBinding("Visible", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean Visible
        {
            get { return Visible_BackingField; }
            set
            {
                if (Visible_BackingField != value)
                {
                    System.Boolean oldValue = Visible_BackingField;
                    Visible_BackingField = value;
                    VulcanOnPropertyChanged("Visible", oldValue, Visible_BackingField);
                    IsVisibleExplicitlySet = true;
                }
            }
        }

        public bool IsVisibleExplicitlySet
        {
            get { return _isVisibleExplicitlySet; }
            protected set
            {
                if (_isVisibleExplicitlySet != value)
                {
                    bool oldValue = _isVisibleExplicitlySet;
                    _isVisibleExplicitlySet = value;
                    VulcanOnPropertyChanged("IsVisibleExplicitlySet", oldValue, _isVisibleExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Contains an MDX expression defining the default measure for a Cube or Perspective element.")]
        [Browsable(true)]
        [AstXNameBinding("DefaultMeasureName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Fact.AstMeasureNode DefaultMeasure
        {
            get { return _defaultMeasure; }
            set
            {
                if (_defaultMeasure != value)
                {
                    if (_defaultMeasure != null)
                    {
                        _defaultMeasure.Unreference(this, "DefaultMeasure");
                    }
                    VulcanEngine.IR.Ast.Fact.AstMeasureNode oldValue = _defaultMeasure;
                    _defaultMeasure = value;
                    if (_defaultMeasure != null)
                    {
                        _defaultMeasure.Reference(this, "DefaultMeasure");
                    }
                    VulcanOnPropertyChanged("DefaultMeasure", oldValue, _defaultMeasure);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the file system storage location of the parent element.")]
        [Browsable(true)]
        [AstXNameBinding("StorageLocation", ChildType.Attribute)]
        public System.String StorageLocation
        {
            get { return StorageLocation_BackingField; }
            set
            {
                if (StorageLocation_BackingField != value)
                {
                    System.String oldValue = StorageLocation_BackingField;
                    StorageLocation_BackingField = value;
                    VulcanOnPropertyChanged("StorageLocation", oldValue, StorageLocation_BackingField);
                    IsStorageLocationExplicitlySet = true;
                }
            }
        }

        public bool IsStorageLocationExplicitlySet
        {
            get { return _isStorageLocationExplicitlySet; }
            protected set
            {
                if (_isStorageLocationExplicitlySet != value)
                {
                    bool oldValue = _isStorageLocationExplicitlySet;
                    _isStorageLocationExplicitlySet = value;
                    VulcanOnPropertyChanged("IsStorageLocationExplicitlySet", oldValue, _isStorageLocationExplicitlySet);
                }
            }
        }


        [VulcanCategory("Read Only")]
        [VulcanDescription(@"")]
        [Browsable(false)]
        [AstXNameBinding("Measure", ChildType.ListChildDefinition)]
        public VulcanCollection<VulcanEngine.IR.Ast.Fact.AstMeasureNode> Measures
        {
            get { return _measures; }
        }


        #endregion Public Accessor Properties

        #region Collection Methods
















        private void _measures_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanEngine.IR.Ast.Fact.AstMeasureNode.ProcessAstNamedNodeCollectionAction(e);
            VulcanOnCollectionPropertyChanged("Measures", e);
        }

        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            EstimatedRows_BackingField = 0;
            EstimatedSize_BackingField = 0;
            IgnoreUnrelatedDimensions_BackingField = true;
            ProcessingPriority_BackingField = 0;
            Visible_BackingField = true;
            _measures = new VulcanCollection<VulcanEngine.IR.Ast.Fact.AstMeasureNode>();
            _measures.CollectionChanged += _measures_CollectionChanged;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());
















            foreach (var item in _measures)
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
            if (targetItem == null || !typeof(AstFactNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstFactNode)targetItem;
            castedTargetItem.MeasureGroupName_BackingField = MeasureGroupName_BackingField;

            castedTargetItem.AggregationPrefix_BackingField = AggregationPrefix_BackingField;

            castedTargetItem.DataAggregation_BackingField = DataAggregation_BackingField;

            castedTargetItem.Description_BackingField = Description_BackingField;

            castedTargetItem.ErrorConfiguration_BackingField = ErrorConfiguration_BackingField;

            castedTargetItem.EstimatedRows_BackingField = EstimatedRows_BackingField;

            castedTargetItem.EstimatedSize_BackingField = EstimatedSize_BackingField;

            castedTargetItem.IgnoreUnrelatedDimensions_BackingField = IgnoreUnrelatedDimensions_BackingField;

            castedTargetItem.ProactiveCaching_BackingField = ProactiveCaching_BackingField;

            castedTargetItem.ProcessingMode_BackingField = ProcessingMode_BackingField;

            castedTargetItem.ProcessingPriority_BackingField = ProcessingPriority_BackingField;

            castedTargetItem.StorageMode_BackingField = StorageMode_BackingField;

            castedTargetItem.MeasureGroupType_BackingField = MeasureGroupType_BackingField;

            castedTargetItem.Visible_BackingField = Visible_BackingField;

            if (_defaultMeasure == null)
            {
                castedTargetItem._defaultMeasure = null;
            }
            else if (cloneMapping.ContainsKey(_defaultMeasure))
            {
                castedTargetItem._defaultMeasure = (VulcanEngine.IR.Ast.Fact.AstMeasureNode)cloneMapping[_defaultMeasure];
            }
            else
            {
                castedTargetItem._defaultMeasure = _defaultMeasure;
            }

            castedTargetItem.StorageLocation_BackingField = StorageLocation_BackingField;

            foreach (var item in _measures)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._measures.Add((VulcanEngine.IR.Ast.Fact.AstMeasureNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstFactNode(parentItem);
        }

        #endregion Cloning Support


    }
}
