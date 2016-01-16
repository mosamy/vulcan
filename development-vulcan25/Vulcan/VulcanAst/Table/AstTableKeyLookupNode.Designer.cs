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
    [AstSchemaTypeBindingAttribute("TableKeyLookupElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstTableKeyLookupNode : VulcanEngine.IR.Ast.Table.AstTableLookupBaseNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode _key;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("KeyName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode Key
        {
            get { return _key; }
            set
            {
                if (_key != value)
                {
                    if (_key != null)
                    {
                        _key.Unreference(this, "Key");
                    }
                    VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode oldValue = _key;
                    _key = value;
                    if (_key != null)
                    {
                        _key.Reference(this, "Key");
                    }
                    VulcanOnPropertyChanged("Key", oldValue, _key);
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
            if (targetItem == null || !typeof(AstTableKeyLookupNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTableKeyLookupNode)targetItem;
            if (_key == null)
            {
                castedTargetItem._key = null;
            }
            else if (cloneMapping.ContainsKey(_key))
            {
                castedTargetItem._key = (VulcanEngine.IR.Ast.Table.AstTableKeyBaseNode)cloneMapping[_key];
            }
            else
            {
                castedTargetItem._key = _key;
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstTableKeyLookupNode(parentItem);
        }

        #endregion Cloning Support


    }
}
