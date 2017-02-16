﻿// -----------------------------------------------------------------------
// <copyright file="SimpleCompoundTypeMessageContract.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.WcfUnit.Library.Test
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data;
    using System.IO;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>Summary description for <see cref="SimpleCompoundTypeMessageContract"/> class.</summary>
    [MessageContract]
    public class SimpleCompoundTypeMessageContract
    {
        /// <summary>Summary description for class level field of type <c>decimal</c>.</summary>
        [MessageBodyMember]
        private decimal Field1;

        /// <summary>Summary description for class level field of type <c>string</c>.</summary>
        [MessageBodyMember]
        private string Field2;

        /// <summary>Summary description for class level field of type <c>string</c>.</summary>
        private string NonMember;

        /// <summary>Summary description for class level field of type <c>string</c>.</summary>
        private string _property1;

        /// <summary>Summary description for class level field of type <c>int</c>.</summary>
        private int _property2;

        /// <summary>Gets or sets the value for Property1.</summary>
        [MessageHeader]
        public string Property1
        {
            get { return this._property1; }
            set { this._property1 = value; }
        }

        /// <summary>Gets or sets the value for Property2.</summary>
        [MessageBodyMember]
        public int Property2
        {
            get { return this._property2; }
            set { this._property2 = value; }
        }
    }
}
