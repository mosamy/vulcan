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
    [AstSchemaTypeBindingAttribute("ETLInputPathElemType", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstDataflowInputPathNode : VulcanEngine.IR.Ast.AstNode
    {
        #region Private Storage
        private VulcanEngine.IR.Ast.Transformation.AstDataflowOutputPathNode _outputPath;
        private bool __isNotFirstSet__outputPath;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("OutputPathName", ChildType.Attribute)]
        public VulcanEngine.IR.Ast.Transformation.AstDataflowOutputPathNode OutputPath
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
                    VulcanEngine.IR.Ast.Transformation.AstDataflowOutputPathNode oldValue = _outputPath;
                    _outputPath = value;
                    if (_outputPath != null)
                    {
                        _outputPath.Reference(this, "OutputPath");
                    }
                    VulcanOnPropertyChanged("OutputPath", oldValue, _outputPath);
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
            if (targetItem == null || !typeof(AstDataflowInputPathNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstDataflowInputPathNode)targetItem;
            if (_outputPath == null)
            {
                castedTargetItem._outputPath = null;
            }
            else if (cloneMapping.ContainsKey(_outputPath))
            {
                castedTargetItem._outputPath = (VulcanEngine.IR.Ast.Transformation.AstDataflowOutputPathNode)cloneMapping[_outputPath];
            }
            else
            {
                castedTargetItem._outputPath = _outputPath;
            }

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstDataflowInputPathNode(parentItem);
        }

        #endregion Cloning Support


    }
}
