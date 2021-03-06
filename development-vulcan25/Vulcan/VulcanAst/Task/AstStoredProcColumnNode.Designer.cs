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

namespace VulcanEngine.IR.Ast.Task
{
    [AstSchemaTypeBindingAttribute("StoredProcColumnElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstStoredProcColumnNode : VulcanEngine.IR.Ast.AstNamedNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean IsOutput_BackingField;
        private bool _isIsOutputExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.ColumnType ColumnType_BackingField;
        private bool __isNotFirstSet_ColumnType_BackingField;
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
        protected System.String Default_BackingField;
        private bool _isDefaultExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean IsReadOnly_BackingField;
        private bool _isIsReadOnlyExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Optional")]
        [VulcanDefaultValue(false)]
        [Browsable(true)]
        [AstXNameBinding("IsOutput", ChildType.Attribute, DefaultValue = "false")]
        public System.Boolean IsOutput
        {
            get { return IsOutput_BackingField; }
            set
            {
                if (IsOutput_BackingField != value)
                {
                    System.Boolean oldValue = IsOutput_BackingField;
                    IsOutput_BackingField = value;
                    VulcanOnPropertyChanged("IsOutput", oldValue, IsOutput_BackingField);
                    IsIsOutputExplicitlySet = true;
                }
            }
        }

        public bool IsIsOutputExplicitlySet
        {
            get { return _isIsOutputExplicitlySet; }
            protected set
            {
                if (_isIsOutputExplicitlySet != value)
                {
                    bool oldValue = _isIsOutputExplicitlySet;
                    _isIsOutputExplicitlySet = value;
                    VulcanOnPropertyChanged("IsIsOutputExplicitlySet", oldValue, _isIsOutputExplicitlySet);
                }
            }
        }


        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [Browsable(true)]
        [AstXNameBinding("Type", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.ColumnType ColumnType
        {
            get { return ColumnType_BackingField; }
            set
            {
                if (ColumnType_BackingField != value || !__isNotFirstSet_ColumnType_BackingField)
                {
                    __isNotFirstSet_ColumnType_BackingField = true;
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
        [VulcanDefaultValue(0)]
        [Browsable(true)]
        [AstXNameBinding("Length", ChildType.Attribute, DefaultValue = "0")]
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
        [VulcanDefaultValue(0)]
        [Browsable(true)]
        [AstXNameBinding("Precision", ChildType.Attribute, DefaultValue = "0")]
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
        [VulcanDefaultValue(0)]
        [Browsable(true)]
        [AstXNameBinding("Scale", ChildType.Attribute, DefaultValue = "0")]
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
        [VulcanDefaultValue(false)]
        [Browsable(true)]
        [AstXNameBinding("IsReadOnly", ChildType.Attribute, DefaultValue = "false")]
        public System.Boolean IsReadOnly
        {
            get { return IsReadOnly_BackingField; }
            set
            {
                if (IsReadOnly_BackingField != value)
                {
                    System.Boolean oldValue = IsReadOnly_BackingField;
                    IsReadOnly_BackingField = value;
                    VulcanOnPropertyChanged("IsReadOnly", oldValue, IsReadOnly_BackingField);
                    IsIsReadOnlyExplicitlySet = true;
                }
            }
        }

        public bool IsIsReadOnlyExplicitlySet
        {
            get { return _isIsReadOnlyExplicitlySet; }
            protected set
            {
                if (_isIsReadOnlyExplicitlySet != value)
                {
                    bool oldValue = _isIsReadOnlyExplicitlySet;
                    _isIsReadOnlyExplicitlySet = value;
                    VulcanOnPropertyChanged("IsIsReadOnlyExplicitlySet", oldValue, _isIsReadOnlyExplicitlySet);
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
            IsOutput_BackingField = false;
            Length_BackingField = 0;
            Precision_BackingField = 0;
            Scale_BackingField = 0;
            IsReadOnly_BackingField = false;
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
            if (targetItem == null || !typeof(AstStoredProcColumnNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstStoredProcColumnNode)targetItem;
            castedTargetItem.IsOutput_BackingField = IsOutput_BackingField;

            castedTargetItem.ColumnType_BackingField = ColumnType_BackingField;

            castedTargetItem.Length_BackingField = Length_BackingField;

            castedTargetItem.Precision_BackingField = Precision_BackingField;

            castedTargetItem.Scale_BackingField = Scale_BackingField;

            castedTargetItem.CustomType_BackingField = CustomType_BackingField;

            castedTargetItem.Default_BackingField = Default_BackingField;

            castedTargetItem.IsReadOnly_BackingField = IsReadOnly_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstStoredProcColumnNode(parentItem);
        }

        #endregion Cloning Support


    }
}
