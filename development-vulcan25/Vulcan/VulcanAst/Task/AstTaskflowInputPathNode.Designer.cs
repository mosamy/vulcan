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
    [FriendlyNameAttribute("TaskflowInputPath")]
    [AstSchemaTypeBindingAttribute("TaskflowInputPathElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstTaskflowInputPathNode : VulcanEngine.IR.Ast.AstNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Task.AstTaskflowOutputPathNode _outputPath;
        private bool __isNotFirstSet__outputPath;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Task.TaskEvaluationOperationType EvaluationOperation_BackingField;
        private bool _isEvaluationOperationExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected VulcanEngine.IR.Ast.Task.TaskEvaluationOperationValue EvaluationValue_BackingField;
        private bool _isEvaluationValueExplicitlySet;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String Expression_BackingField;
        private bool _isExpressionExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("OutputPathName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Task.AstTaskflowOutputPathNode OutputPath
        {
            get { return _outputPath; }
            set
            {
                if (_outputPath != value || !__isNotFirstSet__outputPath)
                {
                    __isNotFirstSet__outputPath = true;
                    if (_outputPath != null)
                    {
                        _outputPath.Unreference(this, "OutputPath");
                    }
                    VulcanEngine.IR.Ast.Task.AstTaskflowOutputPathNode oldValue = _outputPath;
                    _outputPath = value;
                    if (_outputPath != null)
                    {
                        _outputPath.Reference(this, "OutputPath");
                    }
                    VulcanOnPropertyChanged("OutputPath", oldValue, _outputPath);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Task.TaskEvaluationOperationType.Constraint)]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("EvaluationOperation", ChildType.Attribute, DefaultValue = "Constraint")]
        public VulcanEngine.IR.Ast.Task.TaskEvaluationOperationType EvaluationOperation
        {
            get { return EvaluationOperation_BackingField; }
            set
            {
                if (EvaluationOperation_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Task.TaskEvaluationOperationType oldValue = EvaluationOperation_BackingField;
                    EvaluationOperation_BackingField = value;
                    VulcanOnPropertyChanged("EvaluationOperation", oldValue, EvaluationOperation_BackingField);
                    IsEvaluationOperationExplicitlySet = true;
                }
            }
        }

        public bool IsEvaluationOperationExplicitlySet
        {
            get { return _isEvaluationOperationExplicitlySet; }
            protected set
            {
                if (_isEvaluationOperationExplicitlySet != value)
                {
                    bool oldValue = _isEvaluationOperationExplicitlySet;
                    _isEvaluationOperationExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEvaluationOperationExplicitlySet", oldValue, _isEvaluationOperationExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(VulcanEngine.IR.Ast.Task.TaskEvaluationOperationValue.Success)]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("EvaluationValue", ChildType.Attribute, DefaultValue = "Success")]
        public VulcanEngine.IR.Ast.Task.TaskEvaluationOperationValue EvaluationValue
        {
            get { return EvaluationValue_BackingField; }
            set
            {
                if (EvaluationValue_BackingField != value)
                {
                    VulcanEngine.IR.Ast.Task.TaskEvaluationOperationValue oldValue = EvaluationValue_BackingField;
                    EvaluationValue_BackingField = value;
                    VulcanOnPropertyChanged("EvaluationValue", oldValue, EvaluationValue_BackingField);
                    IsEvaluationValueExplicitlySet = true;
                }
            }
        }

        public bool IsEvaluationValueExplicitlySet
        {
            get { return _isEvaluationValueExplicitlySet; }
            protected set
            {
                if (_isEvaluationValueExplicitlySet != value)
                {
                    bool oldValue = _isEvaluationValueExplicitlySet;
                    _isEvaluationValueExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEvaluationValueExplicitlySet", oldValue, _isEvaluationValueExplicitlySet);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("Expression", ChildType.Attribute)]
        public System.String Expression
        {
            get { return Expression_BackingField; }
            set
            {
                if (Expression_BackingField != value)
                {
                    System.String oldValue = Expression_BackingField;
                    Expression_BackingField = value;
                    VulcanOnPropertyChanged("Expression", oldValue, Expression_BackingField);
                    IsExpressionExplicitlySet = true;
                }
            }
        }

        public bool IsExpressionExplicitlySet
        {
            get { return _isExpressionExplicitlySet; }
            protected set
            {
                if (_isExpressionExplicitlySet != value)
                {
                    bool oldValue = _isExpressionExplicitlySet;
                    _isExpressionExplicitlySet = value;
                    VulcanOnPropertyChanged("IsExpressionExplicitlySet", oldValue, _isExpressionExplicitlySet);
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
            EvaluationOperation_BackingField = VulcanEngine.IR.Ast.Task.TaskEvaluationOperationType.Constraint;
            EvaluationValue_BackingField = VulcanEngine.IR.Ast.Task.TaskEvaluationOperationValue.Success;
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
            if (targetItem == null || !typeof(AstTaskflowInputPathNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstTaskflowInputPathNode)targetItem;
            if (_outputPath == null)
            {
                castedTargetItem._outputPath = null;
            }
            else if (cloneMapping.ContainsKey(_outputPath))
            {
                castedTargetItem._outputPath = (VulcanEngine.IR.Ast.Task.AstTaskflowOutputPathNode)cloneMapping[_outputPath];
            }
            else
            {
                castedTargetItem._outputPath = _outputPath;
            }

            castedTargetItem.EvaluationOperation_BackingField = EvaluationOperation_BackingField;

            castedTargetItem.EvaluationValue_BackingField = EvaluationValue_BackingField;

            castedTargetItem.Expression_BackingField = Expression_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstTaskflowInputPathNode(parentItem);
        }

        #endregion Cloning Support


    }
}