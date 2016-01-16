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

namespace VulcanEngine.IR.Ast
{
    [AstSchemaTypeBindingAttribute("", "http://tempuri.org/vulcan2.xsd")]
    public partial class AstNamedNode : VulcanEngine.IR.Ast.AstNode, IReferenceableItem
    {
        #region Private Storage
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        protected System.String Name_BackingField;
        private bool __isNotFirstSet_Name_BackingField;
        private bool _isNameExplicitlySet;

        #endregion Private Storage

        #region Public Accessor Properties
        [VulcanCategory("Required")]
        [AstRequiredProperty]
        [VulcanDescription(@"")]
        [Browsable(true)]
        [AstXNameBinding("Name", ChildType.Attribute)]
        public System.String Name
        {
            get { return Name_BackingField; }
            set
            {
                if (Name_BackingField != value || !__isNotFirstSet_Name_BackingField)
                {
                    __isNotFirstSet_Name_BackingField = true;
                    System.String oldValue = Name_BackingField;
                    Name_BackingField = value;
                    VulcanOnPropertyChanged("Name", oldValue, Name_BackingField);
                    IsNameExplicitlySet = true;
                }
            }
        }

        public bool IsNameExplicitlySet
        {
            get { return _isNameExplicitlySet; }
            protected set
            {
                if (_isNameExplicitlySet != value)
                {
                    bool oldValue = _isNameExplicitlySet;
                    _isNameExplicitlySet = value;
                    VulcanOnPropertyChanged("IsNameExplicitlySet", oldValue, _isNameExplicitlySet);
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
            References = new HashSet<FrameworkItemReference>();
            if (ScopeBoundary != null)
            {
                ScopeBoundary.PropertyChanged += ScopeBoundary_PropertyChanged;
            }
            SingletonPropertyChanged += AstNamedNode_SingletonPropertyChanged;
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
            if (targetItem == null || !typeof(AstNamedNode).IsAssignableFrom(targetItem.GetType()))
            {
                throw new ArgumentException("Provided target node is not of the correct type.");
            }
            var castedTargetItem = (AstNamedNode)targetItem;
            castedTargetItem.Name_BackingField = Name_BackingField;

        }

        public override IFrameworkItem CloneHusk(IFrameworkItem parentItem)
        {
            return new AstNamedNode(parentItem);
        }

        #endregion Cloning Support


        [BrowsableAttribute(false)]
        public HashSet<FrameworkItemReference> References { get; private set; }

        public bool Reference(IFrameworkItem frameworkItem, string propertyName)
        {
            var reference = new FrameworkItemReference(frameworkItem, propertyName, this);
            if (!References.Contains(reference))
            {
                References.Add(reference);
                return true;
            }

            return true;
        }

        public bool Unreference(IFrameworkItem frameworkItem, string propertyName)
        {
            if (frameworkItem != null && propertyName != null)
            {
                var reference = new FrameworkItemReference(frameworkItem, propertyName, this);
                return References.Remove(reference);
            }

            return false;
        }

        public bool Unreference(IFrameworkItem frameworkItem)
        {
            if (frameworkItem != null)
            {
                bool anythingRemoved = false;
                var processReferences = new List<FrameworkItemReference>(References);
                foreach (var reference in processReferences)
                {
                    if (reference.ReferencingItem == frameworkItem && reference.ReferencedItem == this)
                    {
                        anythingRemoved = anythingRemoved || References.Remove(reference);
                    }
                }

                return anythingRemoved;
            }

            return false;
        }

        public bool DefineSymbol()
        {
            SymbolTableProvider.SymbolTable.Add(this);
            return true;
        }

        public bool Undefine()
        {
            var referencesCache = new List<FrameworkItemReference>(References);
            foreach (var reference in referencesCache)
            {
                PropertyInfo property = reference.ReferencingItem.GetType().GetProperty(reference.PropertyName);
                property.SetValue(reference.ReferencingItem, null, null);
            }

            return SymbolTableProvider.SymbolTable.Remove(this);
        }

        public static bool ProcessAstNamedNodeCollectionAction(NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (IReferenceableItem oldItem in e.OldItems)
                {
                    oldItem.Undefine();
                }
            }

            if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (IReferenceableItem newItem in e.NewItems)
                {
                    newItem.DefineSymbol();
                }
            }

            return true;
        }

        private void AstNamedNode_SingletonPropertyChanged(object sender, VulcanPropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ScopeBoundary")
            {
                var oldScopeBoundary = e.OldValue as IScopeBoundary;
                if (oldScopeBoundary != null)
                {
                    oldScopeBoundary.PropertyChanged -= ScopeBoundary_PropertyChanged;
                }

                var newScopeBoundary = e.NewValue as IScopeBoundary;
                if (newScopeBoundary != null)
                {
                    newScopeBoundary.PropertyChanged += ScopeBoundary_PropertyChanged;
                }
            }

            if (e.PropertyName == "Name")
            {
                VulcanOnPropertyChanged("ScopedName", ScopedName, ScopedName);
            }
        }

        private void ScopeBoundary_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ScopedName")
            {
                VulcanOnPropertyChanged("ScopedName", ScopedName, ScopedName);
            }
        }

    }
}
