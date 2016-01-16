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
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    [AstDoNotEmitXmlSchemaTypeAttribute]
    [FriendlyNameAttribute("ContainerBase")]
    [AstSchemaTypeBindingAttribute("ContainerTaskBaseElemType", "http://tempuri.org/vulcan2.xsd")]
    public abstract partial class AstContainerTaskBaseNode : VulcanEngine.IR.Ast.Task.AstTaskNode
    {
        #region Private Storage
        private VulcanCollection<VulcanEngine.IR.Ast.Task.AstTaskNode> _tasks;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Read Only")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(false)]
        [AstXNameBinding("Staging", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstStagingContainerTaskNode))]
        [AstXNameBinding("Container", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstContainerTaskNode))]
        [AstXNameBinding("ExecuteSQL", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstExecuteSqlTaskNode))]
        [AstXNameBinding("ETL", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstEtlRootNode))]
        [AstXNameBinding("ExecutePackage", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstExecutePackageTaskNode))]
        [AstXNameBinding("StoredProc", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstStoredProcNode))]
        [AstXNameBinding("Merge", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstMergeTaskNode))]
        [AstXNameBinding("ReadPersistentVariable", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstReadPersistentVariableNode))]
        [AstXNameBinding("WritePersistentVariable", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstWritePersistentVariableNode))]
        [AstXNameBinding("CommitPersistentVariable", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstCommitPersistentVariableNode))]
        [AstXNameBinding("TaskTemplateInstance", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstTaskTemplateInstanceNode))]
        [AstXNameBinding("ForLoop", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstForLoopContainerTaskNode))]
        [AstXNameBinding("RetryContainer", ChildType.ListChildDefinition, SubtypeOverride = typeof(VulcanEngine.IR.Ast.Task.AstRetryContainerTaskNode))]
        public VulcanCollection<VulcanEngine.IR.Ast.Task.AstTaskNode> Tasks
        {
            get { return _tasks; }
        }


        #endregion Public Accessor Properties

        #region Collection Methods
        private void _tasks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            VulcanEngine.IR.Ast.Task.AstTaskNode.ProcessAstNamedNodeCollectionAction(e);
            VulcanOnCollectionPropertyChanged("Tasks", e);
        }

        #endregion Collection Methods

        #region Initialization
        private void InitializeAstNode()
        {
            _tasks = new VulcanCollection<VulcanEngine.IR.Ast.Task.AstTaskNode>();
            _tasks.CollectionChanged += _tasks_CollectionChanged;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());
            foreach (var item in _tasks)
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
            if (targetItem == null || !typeof(AstContainerTaskBaseNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstContainerTaskBaseNode)targetItem;
            foreach (var item in _tasks)
            {
                IFrameworkItem candidate = cloneMapping[item];
                castedTargetItem._tasks.Add((VulcanEngine.IR.Ast.Task.AstTaskNode)candidate);
                item.CloneInto(candidate, cloneMapping);
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            throw new NotSupportedException("Cannot clone abstract IFrameworkElement class.  You are missing a Clone method on a non-abstract derived type.");
        }

        #endregion Cloning Support


    }
}
