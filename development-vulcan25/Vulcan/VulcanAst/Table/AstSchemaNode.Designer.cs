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
    [FriendlyNameAttribute("Schema")]
    [AstSchemaTypeBindingAttribute("SchemaElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstSchemaNode : VulcanEngine.IR.Ast.AstSecurableNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Connection.AstConnectionNode _connection;
        private bool __isNotFirstSet__connection;

        private VulcanEngine.IR.Ast.Task.AstContainerTaskNode _customExtensions;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.Boolean Emit_BackingField;
        private bool _isEmitExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("ConnectionName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Connection.AstConnectionNode Connection
        {
            get { return _connection; }
            set
            {
                if (_connection != value || !__isNotFirstSet__connection)
                {
                    __isNotFirstSet__connection = true;
                    if (_connection != null)
                    {
                        _connection.Unreference(this, "Connection");
                    }
                    VulcanEngine.IR.Ast.Connection.AstConnectionNode oldValue = _connection;
                    _connection = value;
                    if (_connection != null)
                    {
                        _connection.Reference(this, "Connection");
                    }
                    VulcanOnPropertyChanged("Connection", oldValue, _connection);
                }
            }
        }


        [VulcanCategory("Read Only")]
        [VulcanDescription(@"")]
        [Browsable(false)]
        [AstXNameBinding("CustomExtensions", ChildType.ChildDefinition)]
        public VulcanEngine.IR.Ast.Task.AstContainerTaskNode CustomExtensions
        {
            get { return _customExtensions; }
            set
            {
                if (_customExtensions != value)
                {
                    if (_customExtensions != null)
                    {
                        _customExtensions.Undefine();
                    }
                    VulcanEngine.IR.Ast.Task.AstContainerTaskNode oldValue = _customExtensions;
                    _customExtensions = value;
                    if (_customExtensions != null)
                    {
                        _customExtensions.DefineSymbol();
                    }
                    VulcanOnPropertyChanged("CustomExtensions", oldValue, _customExtensions);
                }
            }
        }


        [VulcanCategory("Optional")]
        [VulcanDefaultValue(true)]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("Emit", ChildType.Attribute, DefaultValue = "true")]
        public System.Boolean Emit
        {
            get { return Emit_BackingField; }
            set
            {
                if (Emit_BackingField != value)
                {
                    System.Boolean oldValue = Emit_BackingField;
                    Emit_BackingField = value;
                    VulcanOnPropertyChanged("Emit", oldValue, Emit_BackingField);
                    IsEmitExplicitlySet = true;
                }
            }
        }

        public bool IsEmitExplicitlySet
        {
            get { return _isEmitExplicitlySet; }
            protected set
            {
                if (_isEmitExplicitlySet != value)
                {
                    bool oldValue = _isEmitExplicitlySet;
                    _isEmitExplicitlySet = value;
                    VulcanOnPropertyChanged("IsEmitExplicitlySet", oldValue, _isEmitExplicitlySet);
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
            Emit_BackingField = true;
        }

        #endregion Initialization

        public override VulcanCollection<IFrameworkItem> DefinedAstNodes()
        {
            var definedAstNodes = new VulcanCollection<IFrameworkItem>();
            definedAstNodes.AddRange(base.DefinedAstNodes());

            if (_customExtensions != null)
            {
                definedAstNodes.Add(_customExtensions);
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
            if (targetItem == null || !typeof(AstSchemaNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstSchemaNode)targetItem;
            if (_connection == null)
            {
                castedTargetItem._connection = null;
            }
            else if (cloneMapping.ContainsKey(_connection))
            {
                castedTargetItem._connection = (VulcanEngine.IR.Ast.Connection.AstConnectionNode)cloneMapping[_connection];
            }
            else
            {
                castedTargetItem._connection = _connection;
            }

            if (_customExtensions == null)
            {
                castedTargetItem._customExtensions = null;
            }
            else if (cloneMapping.ContainsKey(_customExtensions))
            {
                castedTargetItem._customExtensions = (VulcanEngine.IR.Ast.Task.AstContainerTaskNode)cloneMapping[_customExtensions];
                _customExtensions.CloneInto(cloneMapping[_customExtensions], cloneMapping);
            }
            else
            {
                castedTargetItem._customExtensions = _customExtensions;
            }

            castedTargetItem.Emit_BackingField = Emit_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstSchemaNode(parentItem);
        }

        #endregion Cloning Support


    }
}
