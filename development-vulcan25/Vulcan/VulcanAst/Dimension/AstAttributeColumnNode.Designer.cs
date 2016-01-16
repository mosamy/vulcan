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
    [AstSchemaTypeBindingAttribute("AttributeColumnElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstAttributeColumnNode : VulcanEngine.IR.Ast.Table.AstTableColumnReferenceNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasDataMimeType DataMimeType_BackingField;
        private bool _isDataMimeTypeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasDataFormat DataFormat_BackingField;
        private bool _isDataFormatExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasCollation Collation_BackingField;
        private bool _isCollationExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasTrimming Trimming_BackingField;
        private bool _isTrimmingExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasInvalidXmlCharacterProcessing InvalidXmlCharacterProcessing_BackingField;
        private bool _isInvalidXmlCharacterProcessingExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Cube.SsasNullProcessing NullProcessing_BackingField;
        private bool _isNullProcessingExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasDataMimeType.None)]
        [VulcanDescription(@"Where applicable, specifies the Multipurpose Internet Mail Extensions (MIME) type of the data represented by the parent DataItem element.")]
        [Browsable(true)]
        [AstXNameBinding("DataMimeType", ChildType.Attribute, DefaultValue = "None")]
        public VulcanEngine.IR.Ast.Cube.SsasDataMimeType DataMimeType
        {
            get { return DataMimeType_BackingField; }
            set
            {
                if (DataMimeType_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasDataMimeType oldValue = DataMimeType_BackingField;
                    DataMimeType_BackingField = value;
                    VulcanOnPropertyChanged("DataMimeType", oldValue, DataMimeType_BackingField);
                    IsDataMimeTypeExplicitlySet = true;
                }
            }
        }

        public bool IsDataMimeTypeExplicitlySet
        {
            get { return _isDataMimeTypeExplicitlySet; }
            protected set
            {
                if (_isDataMimeTypeExplicitlySet != value)
                {
                    bool oldValue = _isDataMimeTypeExplicitlySet;
                    _isDataMimeTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsDataMimeTypeExplicitlySet", oldValue, _isDataMimeTypeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the formatting requirements of the DataItem element. The default setting is “none.” Allowed settings are Microsoft Excel formats and the string values TrimRight, TrimLeft, TrimAll, and TrimNone.")]
        [Browsable(true)]
        [AstXNameBinding("DataFormat", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Cube.SsasDataFormat DataFormat
        {
            get { return DataFormat_BackingField; }
            set
            {
                if (DataFormat_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasDataFormat oldValue = DataFormat_BackingField;
                    DataFormat_BackingField = value;
                    VulcanOnPropertyChanged("DataFormat", oldValue, DataFormat_BackingField);
                    IsDataFormatExplicitlySet = true;
                }
            }
        }

        public bool IsDataFormatExplicitlySet
        {
            get { return _isDataFormatExplicitlySet; }
            protected set
            {
                if (_isDataFormatExplicitlySet != value)
                {
                    bool oldValue = _isDataFormatExplicitlySet;
                    _isDataFormatExplicitlySet = value;
                    VulcanOnPropertyChanged("IsDataFormatExplicitlySet", oldValue, _isDataFormatExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies the collation method used by the parent element.")]
        [Browsable(true)]
        [AstXNameBinding("Collation", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Cube.SsasCollation Collation
        {
            get { return Collation_BackingField; }
            set
            {
                if (Collation_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasCollation oldValue = Collation_BackingField;
                    Collation_BackingField = value;
                    VulcanOnPropertyChanged("Collation", oldValue, Collation_BackingField);
                    IsCollationExplicitlySet = true;
                }
            }
        }

        public bool IsCollationExplicitlySet
        {
            get { return _isCollationExplicitlySet; }
            protected set
            {
                if (_isCollationExplicitlySet != value)
                {
                    bool oldValue = _isCollationExplicitlySet;
                    _isCollationExplicitlySet = value;
                    VulcanOnPropertyChanged("IsCollationExplicitlySet", oldValue, _isCollationExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasTrimming.Right)]
        [VulcanDescription(@"Specifies how data from the data source will be trimmed. The default setting is Right. Other allowed settings are Left, LeftRight, and None.")]
        [Browsable(true)]
        [AstXNameBinding("Trimming", ChildType.Attribute, DefaultValue = "Right")]
        public VulcanEngine.IR.Ast.Cube.SsasTrimming Trimming
        {
            get { return Trimming_BackingField; }
            set
            {
                if (Trimming_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasTrimming oldValue = Trimming_BackingField;
                    Trimming_BackingField = value;
                    VulcanOnPropertyChanged("Trimming", oldValue, Trimming_BackingField);
                    IsTrimmingExplicitlySet = true;
                }
            }
        }

        public bool IsTrimmingExplicitlySet
        {
            get { return _isTrimmingExplicitlySet; }
            protected set
            {
                if (_isTrimmingExplicitlySet != value)
                {
                    bool oldValue = _isTrimmingExplicitlySet;
                    _isTrimmingExplicitlySet = value;
                    VulcanOnPropertyChanged("IsTrimmingExplicitlySet", oldValue, _isTrimmingExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasInvalidXmlCharacterProcessing.Preserve)]
        [VulcanDescription(@"Determines how invalid XML characters in the source data will be handled. Preserve retains the character, Remove deletes them, and Replace inserts a question mark (?) in the place of each invalid character.")]
        [Browsable(true)]
        [AstXNameBinding("InvalidXMLCharacterProcessing", ChildType.Attribute, DefaultValue = "Preserve")]
        public VulcanEngine.IR.Ast.Cube.SsasInvalidXmlCharacterProcessing InvalidXmlCharacterProcessing
        {
            get { return InvalidXmlCharacterProcessing_BackingField; }
            set
            {
                if (InvalidXmlCharacterProcessing_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasInvalidXmlCharacterProcessing oldValue = InvalidXmlCharacterProcessing_BackingField;
                    InvalidXmlCharacterProcessing_BackingField = value;
                    VulcanOnPropertyChanged("InvalidXmlCharacterProcessing", oldValue, InvalidXmlCharacterProcessing_BackingField);
                    IsInvalidXmlCharacterProcessingExplicitlySet = true;
                }
            }
        }

        public bool IsInvalidXmlCharacterProcessingExplicitlySet
        {
            get { return _isInvalidXmlCharacterProcessingExplicitlySet; }
            protected set
            {
                if (_isInvalidXmlCharacterProcessingExplicitlySet != value)
                {
                    bool oldValue = _isInvalidXmlCharacterProcessingExplicitlySet;
                    _isInvalidXmlCharacterProcessingExplicitlySet = value;
                    VulcanOnPropertyChanged("IsInvalidXmlCharacterProcessingExplicitlySet", oldValue, _isInvalidXmlCharacterProcessingExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Cube.SsasNullProcessing.Automatic)]
        [VulcanDescription(@"Specifies how null values will be processed. The default setting is Automatic. Other allowed settings are Preserve (which preserves the null value), Error (which generates a null key error, UnknownMember (which generates an unknown member as well as a null conversion error) and ZeroOrBlank (which converts the null value to zero in numeric data items, and a blank string in string data items).")]
        [Browsable(true)]
        [AstXNameBinding("NullProcessing", ChildType.Attribute, DefaultValue = "Automatic")]
        public VulcanEngine.IR.Ast.Cube.SsasNullProcessing NullProcessing
        {
            get { return NullProcessing_BackingField; }
            set
            {
                if (NullProcessing_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Cube.SsasNullProcessing oldValue = NullProcessing_BackingField;
                    NullProcessing_BackingField = value;
                    VulcanOnPropertyChanged("NullProcessing", oldValue, NullProcessing_BackingField);
                    IsNullProcessingExplicitlySet = true;
                }
            }
        }

        public bool IsNullProcessingExplicitlySet
        {
            get { return _isNullProcessingExplicitlySet; }
            protected set
            {
                if (_isNullProcessingExplicitlySet != value)
                {
                    bool oldValue = _isNullProcessingExplicitlySet;
                    _isNullProcessingExplicitlySet = value;
                    VulcanOnPropertyChanged("IsNullProcessingExplicitlySet", oldValue, _isNullProcessingExplicitlySet);
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
            DataMimeType_BackingField = VulcanEngine.IR.Ast.Cube.SsasDataMimeType.None;
            Trimming_BackingField = VulcanEngine.IR.Ast.Cube.SsasTrimming.Right;
            InvalidXmlCharacterProcessing_BackingField = VulcanEngine.IR.Ast.Cube.SsasInvalidXmlCharacterProcessing.Preserve;
            NullProcessing_BackingField = VulcanEngine.IR.Ast.Cube.SsasNullProcessing.Automatic;
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
            if (targetItem == null || !typeof(AstAttributeColumnNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstAttributeColumnNode)targetItem;
            castedTargetItem.DataMimeType_BackingField = DataMimeType_BackingField;

            castedTargetItem.DataFormat_BackingField = DataFormat_BackingField;

            castedTargetItem.Collation_BackingField = Collation_BackingField;

            castedTargetItem.Trimming_BackingField = Trimming_BackingField;

            castedTargetItem.InvalidXmlCharacterProcessing_BackingField = InvalidXmlCharacterProcessing_BackingField;

            castedTargetItem.NullProcessing_BackingField = NullProcessing_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstAttributeColumnNode(parentItem);
        }

        #endregion Cloning Support


    }
}
