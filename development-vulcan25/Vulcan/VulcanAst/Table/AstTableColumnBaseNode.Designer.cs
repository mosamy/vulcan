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
    [AstDoNotEmitXmlSchemaTypeAttribute]
    [AstSchemaTypeBindingAttribute("", "http://tempuri.org/vulcan2.xsd")]
    public abstract partial class AstTableColumnBaseNode : VulcanEngine.IR.Ast.AstSecurableNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.ColumnType ColumnType_BackingField;
        private bool _isColumnTypeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 Length_BackingField;
        private bool _isLengthExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 Precision_BackingField;
        private bool _isPrecisionExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Int32 Scale_BackingField;
        private bool _isScaleExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String CustomType_BackingField;
        private bool _isCustomTypeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String Computed_BackingField;
        private bool _isComputedExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String Default_BackingField;
        private bool _isDefaultExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Table.ScdType ScdType_BackingField;
        private bool _isScdTypeExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean IsNullable_BackingField;
        private bool _isIsNullableExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [VulcanDescription(@"Specifies the type of the attribute. A complete list of allowed types is available at http://msdn.microsoft.com/de-de/library/ms127023(SQL.90).aspx.")]
        [Browsable(true)]
        [AstXNameBinding("Type", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.ColumnType ColumnType
        {
            get { return ColumnType_BackingField; }
            set
            {
                if (ColumnType_BackingField != value)
                {
                    VulcanEngine.IR.Ast.ColumnType oldValue = ColumnType_BackingField;
                    ColumnType_BackingField = value;
                    VulcanOnPropertyChanged("ColumnType", oldValue, ColumnType_BackingField);
                    IsColumnTypeExplicitlySet = true;
                }
            }
        }

        public bool IsColumnTypeExplicitlySet
        {
            get { return _isColumnTypeExplicitlySet; }
            protected set
            {
                if (_isColumnTypeExplicitlySet != value)
                {
                    bool oldValue = _isColumnTypeExplicitlySet;
                    _isColumnTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsColumnTypeExplicitlySet", oldValue, _isColumnTypeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(-1)]
        [VulcanDescription(@"Specifies Length.")]
        [Browsable(true)]
        [AstXNameBinding("Length", ChildType.Attribute, DefaultValue = "-1")]
        public System.Int32 Length
        {
            get { return Length_BackingField; }
            set
            {
                if (Length_BackingField != value)
                {
                    System.Int32 oldValue = Length_BackingField;
                    Length_BackingField = value;
                    VulcanOnPropertyChanged("Length", oldValue, Length_BackingField);
                    IsLengthExplicitlySet = true;
                }
            }
        }

        public bool IsLengthExplicitlySet
        {
            get { return _isLengthExplicitlySet; }
            protected set
            {
                if (_isLengthExplicitlySet != value)
                {
                    bool oldValue = _isLengthExplicitlySet;
                    _isLengthExplicitlySet = value;
                    VulcanOnPropertyChanged("IsLengthExplicitlySet", oldValue, _isLengthExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(-1)]
        [VulcanDescription(@"Specifies Precision.")]
        [Browsable(true)]
        [AstXNameBinding("Precision", ChildType.Attribute, DefaultValue = "-1")]
        public System.Int32 Precision
        {
            get { return Precision_BackingField; }
            set
            {
                if (Precision_BackingField != value)
                {
                    System.Int32 oldValue = Precision_BackingField;
                    Precision_BackingField = value;
                    VulcanOnPropertyChanged("Precision", oldValue, Precision_BackingField);
                    IsPrecisionExplicitlySet = true;
                }
            }
        }

        public bool IsPrecisionExplicitlySet
        {
            get { return _isPrecisionExplicitlySet; }
            protected set
            {
                if (_isPrecisionExplicitlySet != value)
                {
                    bool oldValue = _isPrecisionExplicitlySet;
                    _isPrecisionExplicitlySet = value;
                    VulcanOnPropertyChanged("IsPrecisionExplicitlySet", oldValue, _isPrecisionExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(-1)]
        [VulcanDescription(@"Specifies Scale.")]
        [Browsable(true)]
        [AstXNameBinding("Scale", ChildType.Attribute, DefaultValue = "-1")]
        public System.Int32 Scale
        {
            get { return Scale_BackingField; }
            set
            {
                if (Scale_BackingField != value)
                {
                    System.Int32 oldValue = Scale_BackingField;
                    Scale_BackingField = value;
                    VulcanOnPropertyChanged("Scale", oldValue, Scale_BackingField);
                    IsScaleExplicitlySet = true;
                }
            }
        }

        public bool IsScaleExplicitlySet
        {
            get { return _isScaleExplicitlySet; }
            protected set
            {
                if (_isScaleExplicitlySet != value)
                {
                    bool oldValue = _isScaleExplicitlySet;
                    _isScaleExplicitlySet = value;
                    VulcanOnPropertyChanged("IsScaleExplicitlySet", oldValue, _isScaleExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies CustomType.")]
        [Browsable(true)]
        [AstXNameBinding("CustomType", ChildType.Attribute)]
        public System.String CustomType
        {
            get { return CustomType_BackingField; }
            set
            {
                if (CustomType_BackingField != value)
                {
                    System.String oldValue = CustomType_BackingField;
                    CustomType_BackingField = value;
                    VulcanOnPropertyChanged("CustomType", oldValue, CustomType_BackingField);
                    IsCustomTypeExplicitlySet = true;
                }
            }
        }

        public bool IsCustomTypeExplicitlySet
        {
            get { return _isCustomTypeExplicitlySet; }
            protected set
            {
                if (_isCustomTypeExplicitlySet != value)
                {
                    bool oldValue = _isCustomTypeExplicitlySet;
                    _isCustomTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsCustomTypeExplicitlySet", oldValue, _isCustomTypeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies Computed.")]
        [Browsable(true)]
        [AstXNameBinding("Computed", ChildType.Attribute)]
        public System.String Computed
        {
            get { return Computed_BackingField; }
            set
            {
                if (Computed_BackingField != value)
                {
                    System.String oldValue = Computed_BackingField;
                    Computed_BackingField = value;
                    VulcanOnPropertyChanged("Computed", oldValue, Computed_BackingField);
                    IsComputedExplicitlySet = true;
                }
            }
        }

        public bool IsComputedExplicitlySet
        {
            get { return _isComputedExplicitlySet; }
            protected set
            {
                if (_isComputedExplicitlySet != value)
                {
                    bool oldValue = _isComputedExplicitlySet;
                    _isComputedExplicitlySet = value;
                    VulcanOnPropertyChanged("IsComputedExplicitlySet", oldValue, _isComputedExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"Specifies Default Value.")]
        [Browsable(true)]
        [AstXNameBinding("Default", ChildType.Attribute)]
        public System.String Default
        {
            get { return Default_BackingField; }
            set
            {
                if (Default_BackingField != value)
                {
                    System.String oldValue = Default_BackingField;
                    Default_BackingField = value;
                    VulcanOnPropertyChanged("Default", oldValue, Default_BackingField);
                    IsDefaultExplicitlySet = true;
                }
            }
        }

        public bool IsDefaultExplicitlySet
        {
            get { return _isDefaultExplicitlySet; }
            protected set
            {
                if (_isDefaultExplicitlySet != value)
                {
                    bool oldValue = _isDefaultExplicitlySet;
                    _isDefaultExplicitlySet = value;
                    VulcanOnPropertyChanged("IsDefaultExplicitlySet", oldValue, _isDefaultExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Table.ScdType.Update)]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("ScdType", ChildType.Attribute, DefaultValue = "Update")]
        public VulcanEngine.IR.Ast.Table.ScdType ScdType
        {
            get { return ScdType_BackingField; }
            set
            {
                if (ScdType_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Table.ScdType oldValue = ScdType_BackingField;
                    ScdType_BackingField = value;
                    VulcanOnPropertyChanged("ScdType", oldValue, ScdType_BackingField);
                    IsScdTypeExplicitlySet = true;
                }
            }
        }

        public bool IsScdTypeExplicitlySet
        {
            get { return _isScdTypeExplicitlySet; }
            protected set
            {
                if (_isScdTypeExplicitlySet != value)
                {
                    bool oldValue = _isScdTypeExplicitlySet;
                    _isScdTypeExplicitlySet = value;
                    VulcanOnPropertyChanged("IsScdTypeExplicitlySet", oldValue, _isScdTypeExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(false)]
        [Browsable(false)]
        [AstXNameBinding("IsNullable", ChildType.Attribute, DefaultValue = "false")]
        public virtual System.Boolean IsNullable
        {
            get { return IsNullable_BackingField; }
            set
            {
                if (IsNullable_BackingField != value)
                {
                    System.Boolean oldValue = IsNullable_BackingField;
                    IsNullable_BackingField = value;
                    VulcanOnPropertyChanged("IsNullable", oldValue, IsNullable_BackingField);
                    IsIsNullableExplicitlySet = true;
                }
            }
        }

        public virtual bool IsIsNullableExplicitlySet
        {
            get { return _isIsNullableExplicitlySet; }
            protected set
            {
                if (_isIsNullableExplicitlySet != value)
                {
                    bool oldValue = _isIsNullableExplicitlySet;
                    _isIsNullableExplicitlySet = value;
                    VulcanOnPropertyChanged("IsIsNullableExplicitlySet", oldValue, _isIsNullableExplicitlySet);
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
            Length_BackingField = -1;
            Precision_BackingField = -1;
            Scale_BackingField = -1;
            ScdType_BackingField = VulcanEngine.IR.Ast.Table.ScdType.Update;
            IsNullable_BackingField = false;
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
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override IFrameworkItem Clone(Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override IFrameworkItem Clone(IFrameworkItem parentItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        public override void CloneInto(IFrameworkItem targetItem, Dictionary<IFrameworkItem, IFrameworkItem> cloneMapping)
        {
            base.CloneInto(targetItem, cloneMapping);
            if (targetItem == null || !typeof(AstTableColumnBaseNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTableColumnBaseNode)targetItem;
            castedTargetItem.ColumnType_BackingField = ColumnType_BackingField;

            castedTargetItem.Length_BackingField = Length_BackingField;

            castedTargetItem.Precision_BackingField = Precision_BackingField;

            castedTargetItem.Scale_BackingField = Scale_BackingField;

            castedTargetItem.CustomType_BackingField = CustomType_BackingField;

            castedTargetItem.Computed_BackingField = Computed_BackingField;

            castedTargetItem.Default_BackingField = Default_BackingField;

            castedTargetItem.ScdType_BackingField = ScdType_BackingField;

            castedTargetItem.IsNullable_BackingField = IsNullable_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        #endregion Cloning Support


    }
}
