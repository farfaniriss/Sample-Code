﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratedContracts
{
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://contoso.com/service/test", ConfigurationName="GeneratedContracts.ICollections")]
    public interface ICollections
    {
        
        // CODEGEN: Parameter 'ProcessCollectionResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://contoso.com/service/test/ICollections/ProcessCollection", ReplyAction="http://contoso.com/service/test/ICollections/ProcessCollectionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        GeneratedContracts.ProcessCollectionResponse ProcessCollection(GeneratedContracts.ProcessCollectionRequest request);
        
        // CODEGEN: Parameter 'ProcessDataSetResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://contoso.com/service/test/ICollections/ProcessDataSet", ReplyAction="http://contoso.com/service/test/ICollections/ProcessDataSetResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        GeneratedContracts.ProcessDataSetResponse ProcessDataSet(GeneratedContracts.ProcessDataSetRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://contoso.com/data/test")]
    public partial class CollectionsData
    {
        
        private object[] arrayListField;
        
        private System.Xml.XmlElement elementField;
        
        private ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType[] hashtableField;
        
        private int[] intIListField;
        
        private int[] intListField;
        
        private System.Xml.XmlElement nodesField;
        
        private object[] nonGenericEnumerableOnlyCollectionField;
        
        private AddRequest[] requestCollectionField;
        
        private ArrayOfKeyValueOfstringAddRequestdTXxnsEqKeyValueOfstringAddRequestdTXxnsEq[] requestDictionaryField;
        
        private AddRequest[] requestICollectionField;
        
        private ArrayOfKeyValueOfstringAddRequestdTXxnsEqKeyValueOfstringAddRequestdTXxnsEq[] requestIDictionaryField;
        
        private AddRequest[] requestIListField;
        
        private AddRequest[] requestListField;
        
        private object sqlDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public object[] ArrayList
        {
            get
            {
                return this.arrayListField;
            }
            set
            {
                this.arrayListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Xml.XmlElement Element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfanyTypeanyType", Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType[] Hashtable
        {
            get
            {
                return this.hashtableField;
            }
            set
            {
                this.hashtableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public int[] IntIList
        {
            get
            {
                return this.intIListField;
            }
            set
            {
                this.intIListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public int[] IntList
        {
            get
            {
                return this.intListField;
            }
            set
            {
                this.intListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Name="Nodes", Namespace="http://contoso.com/data/test", Order=5)]
        public System.Xml.XmlElement Nodes
        {
            get
            {
                return this.nodesField;
            }
            set
            {
                this.nodesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=6)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public object[] NonGenericEnumerableOnlyCollection
        {
            get
            {
                return this.nonGenericEnumerableOnlyCollectionField;
            }
            set
            {
                this.nonGenericEnumerableOnlyCollectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=7)]
        public AddRequest[] RequestCollection
        {
            get
            {
                return this.requestCollectionField;
            }
            set
            {
                this.requestCollectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringAddRequestdTXxnsEq", Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public ArrayOfKeyValueOfstringAddRequestdTXxnsEqKeyValueOfstringAddRequestdTXxnsEq[] RequestDictionary
        {
            get
            {
                return this.requestDictionaryField;
            }
            set
            {
                this.requestDictionaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=9)]
        public AddRequest[] RequestICollection
        {
            get
            {
                return this.requestICollectionField;
            }
            set
            {
                this.requestICollectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringAddRequestdTXxnsEq", Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public ArrayOfKeyValueOfstringAddRequestdTXxnsEqKeyValueOfstringAddRequestdTXxnsEq[] RequestIDictionary
        {
            get
            {
                return this.requestIDictionaryField;
            }
            set
            {
                this.requestIDictionaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=11)]
        public AddRequest[] RequestIList
        {
            get
            {
                return this.requestIListField;
            }
            set
            {
                this.requestIListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=12)]
        public AddRequest[] RequestList
        {
            get
            {
                return this.requestListField;
            }
            set
            {
                this.requestListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public object SqlData
        {
            get
            {
                return this.sqlDataField;
            }
            set
            {
                this.sqlDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://contoso.com/data/test")]
    public partial class AddRequest
    {
        
        private int aField;
        
        private bool aFieldSpecified;
        
        private int bField;
        
        private bool bFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASpecified
        {
            get
            {
                return this.aFieldSpecified;
            }
            set
            {
                this.aFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int B
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BSpecified
        {
            get
            {
                return this.bFieldSpecified;
            }
            set
            {
                this.bFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType
    {
        
        private object keyField;
        
        private object valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public object Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public object Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfstringAddRequestdTXxnsEqKeyValueOfstringAddRequestdTXxnsEq
    {
        
        private string keyField;
        
        private AddRequest valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public AddRequest Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessCollection", WrapperNamespace="http://contoso.com/service/test", IsWrapped=true)]
    public partial class ProcessCollectionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://contoso.com/service/test", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GeneratedContracts.CollectionsData data;
        
        public ProcessCollectionRequest()
        {
        }
        
        public ProcessCollectionRequest(GeneratedContracts.CollectionsData data)
        {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessCollectionResponse", WrapperNamespace="http://contoso.com/service/test", IsWrapped=true)]
    public partial class ProcessCollectionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://contoso.com/service/test", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GeneratedContracts.CollectionsData ProcessCollectionResult;
        
        public ProcessCollectionResponse()
        {
        }
        
        public ProcessCollectionResponse(GeneratedContracts.CollectionsData ProcessCollectionResult)
        {
            this.ProcessCollectionResult = ProcessCollectionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessDataSet", WrapperNamespace="http://contoso.com/service/test", IsWrapped=true)]
    public partial class ProcessDataSetRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://contoso.com/service/test", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataSet data;
        
        public ProcessDataSetRequest()
        {
        }
        
        public ProcessDataSetRequest(System.Data.DataSet data)
        {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessDataSetResponse", WrapperNamespace="http://contoso.com/service/test", IsWrapped=true)]
    public partial class ProcessDataSetResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://contoso.com/service/test", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataSet ProcessDataSetResult;
        
        public ProcessDataSetResponse()
        {
        }
        
        public ProcessDataSetResponse(System.Data.DataSet ProcessDataSetResult)
        {
            this.ProcessDataSetResult = ProcessDataSetResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICollectionsChannel : GeneratedContracts.ICollections, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CollectionsClient : System.ServiceModel.ClientBase<GeneratedContracts.ICollections>, GeneratedContracts.ICollections
    {
        
        public CollectionsClient()
        {
        }
        
        public CollectionsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public CollectionsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CollectionsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public CollectionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GeneratedContracts.ProcessCollectionResponse GeneratedContracts.ICollections.ProcessCollection(GeneratedContracts.ProcessCollectionRequest request)
        {
            return base.Channel.ProcessCollection(request);
        }
        
        public GeneratedContracts.CollectionsData ProcessCollection(GeneratedContracts.CollectionsData data)
        {
            GeneratedContracts.ProcessCollectionRequest inValue = new GeneratedContracts.ProcessCollectionRequest();
            inValue.data = data;
            GeneratedContracts.ProcessCollectionResponse retVal = ((GeneratedContracts.ICollections)(this)).ProcessCollection(inValue);
            return retVal.ProcessCollectionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GeneratedContracts.ProcessDataSetResponse GeneratedContracts.ICollections.ProcessDataSet(GeneratedContracts.ProcessDataSetRequest request)
        {
            return base.Channel.ProcessDataSet(request);
        }
        
        public System.Data.DataSet ProcessDataSet(System.Data.DataSet data)
        {
            GeneratedContracts.ProcessDataSetRequest inValue = new GeneratedContracts.ProcessDataSetRequest();
            inValue.data = data;
            GeneratedContracts.ProcessDataSetResponse retVal = ((GeneratedContracts.ICollections)(this)).ProcessDataSet(inValue);
            return retVal.ProcessDataSetResult;
        }
    }
}
