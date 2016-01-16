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
    [FriendlyNameAttribute("TransformationTemplate")]
    [AstSchemaTypeBindingAttribute("", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstTransformationTemplateNode : VulcanEngine.IR.Ast.AstTemplateNode
    {
        #region Private Storage
        private VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstTransformationNode> _transformations;

        #endregion Private Storage

        #region Public Accessor Properties
        [Browsable(false)]
        [AstXNameBinding("DerivedColumns", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstDerivedColumnListNode))]
        [AstXNameBinding("Destination", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstDestinationNode))]
        [AstXNameBinding("IsNullPatcher", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstIsNullPatcherNode))]
        [AstXNameBinding("OleDBCommand", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstOleDBCommandNode))]
        [AstXNameBinding("Sort", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstSortNode))]
        [AstXNameBinding("TermLookup", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstTermLookupNode))]
        [AstXNameBinding("ConditionalSplit", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstConditionalSplitNode))]
        [AstXNameBinding("Multicast", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstMulticastNode))]
        [AstXNameBinding("Lookup", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstLookupNode))]
        [AstXNameBinding("LateArrivingLookup", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstLateArrivingLookupNode))]
        [AstXNameBinding("Scd", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstSlowlyChangingDimensionNode))]
        [AstXNameBinding("XmlSource", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstXmlSourceNode))]
        [AstXNameBinding("UnionAll", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstUnionAllNode))]
        [AstXNameBinding("QuerySource", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstQuerySourceNode))]
        [AstXNameBinding("TransformationTemplateInstance", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstTransformationTemplateInstanceNode))]
        [AstXNameBinding("EtlFragmentReference", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Transformation.AstEtlFragmentReferenceNode))]
        public VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstTransformationNode> Transformations
        {
            get { return _transformations; }
        }


        #endregion Public Accessor Properties

        #region Collection Methods
        private void _transformations_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanEngine.IR.Ast.Transformation.AstTransformationNode.ProcessAstNamedNodeCollectionAction(e);
            VulcanOnCollectionPropertyChanged("Transformations", e);
        }

        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            _transformations = new VulcanCollection<VulcanEngine.IR.Ast.Transformation.AstTransformationNode>();
            _transformations.CollectionChanged += _transformations_CollectionChanged;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());
            foreach (var item in _transformations)
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
            if (targetItem == null || !typeof(AstTransformationTemplateNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTransformationTemplateNode)targetItem;
            foreach (var item in _transformations)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._transformations.Add((VulcanEngine.IR.Ast.Transformation.AstTransformationNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstTransformationTemplateNode(parentItem);
        }

        #endregion Cloning Support


    }
}
