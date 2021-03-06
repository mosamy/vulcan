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
    [FriendlyNameAttribute("Etl Fragment Path Column Declaration")]
    [AstSchemaTypeBindingAttribute("EtlFragmentPathColumnDeclarationElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstEtlFragmentPathColumnDeclarationNode : VulcanEngine.IR.Ast.AstNode
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String PathColumnName_BackingField;
        private bool __isNotFirstSet_PathColumnName_BackingField;
        private bool _isPathColumnNameExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("PathColumnName", ChildType.Attribute)]
        public System.String PathColumnName
        {
            get { return PathColumnName_BackingField; }
            set
            {
                if (PathColumnName_BackingField != value || !__isNotFirstSet_PathColumnName_BackingField)
                {
                    __isNotFirstSet_PathColumnName_BackingField = true;
                    System.String oldValue = PathColumnName_BackingField;
                    PathColumnName_BackingField = value;
                    VulcanOnPropertyChanged("PathColumnName", oldValue, PathColumnName_BackingField);
                    IsPathColumnNameExplicitlySet = true;
                }
            }
        }

        public bool IsPathColumnNameExplicitlySet
        {
            get { return _isPathColumnNameExplicitlySet; }
            protected set
            {
                if (_isPathColumnNameExplicitlySet != value)
                {
                    bool oldValue = _isPathColumnNameExplicitlySet;
                    _isPathColumnNameExplicitlySet = value;
                    VulcanOnPropertyChanged("IsPathColumnNameExplicitlySet", oldValue, _isPathColumnNameExplicitlySet);
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
            if (targetItem == null || !typeof(AstEtlFragmentPathColumnDeclarationNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstEtlFragmentPathColumnDeclarationNode)targetItem;
            castedTargetItem.PathColumnName_BackingField = PathColumnName_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstEtlFragmentPathColumnDeclarationNode(parentItem);
        }

        #endregion Cloning Support


    }
}
