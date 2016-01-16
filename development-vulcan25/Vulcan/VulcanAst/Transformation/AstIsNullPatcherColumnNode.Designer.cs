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
    [AstSchemaTypeBindingAttribute("TransformationIsNullPatcherColumnElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstIsNullPatcherColumnNode : VulcanEngine.IR.Ast.AstNamedNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String DefaultValue_BackingField;
        private bool __isNotFirstSet_DefaultValue_BackingField;
        private bool _isDefaultValueExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("__self", ChildType.Self)]
        public System.String DefaultValue
        {
            get { return DefaultValue_BackingField; }
            set
            {
                if (DefaultValue_BackingField != value || !__isNotFirstSet_DefaultValue_BackingField)
                {
                    __isNotFirstSet_DefaultValue_BackingField = true;
                    System.String oldValue = DefaultValue_BackingField;
                    DefaultValue_BackingField = value;
                    VulcanOnPropertyChanged("DefaultValue", oldValue, DefaultValue_BackingField);
                    IsDefaultValueExplicitlySet = true;
                }
            }
        }

        public bool IsDefaultValueExplicitlySet
        {
            get { return _isDefaultValueExplicitlySet; }
            protected set
            {
                if (_isDefaultValueExplicitlySet != value)
                {
                    bool oldValue = _isDefaultValueExplicitlySet;
                    _isDefaultValueExplicitlySet = value;
                    VulcanOnPropertyChanged("IsDefaultValueExplicitlySet", oldValue, _isDefaultValueExplicitlySet);
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
            if (targetItem == null || !typeof(AstIsNullPatcherColumnNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstIsNullPatcherColumnNode)targetItem;
            castedTargetItem.DefaultValue_BackingField = DefaultValue_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstIsNullPatcherColumnNode(parentItem);
        }

        #endregion Cloning Support


    }
}
