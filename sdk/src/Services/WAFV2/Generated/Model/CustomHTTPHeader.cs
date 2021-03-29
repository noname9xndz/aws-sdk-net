/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A custom header for custom request and response handling. This is used in <a>CustomResponse</a>
    /// and <a>CustomRequestHandling</a>.
    /// </summary>
    public partial class CustomHTTPHeader
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom header. 
        /// </para>
        ///  
        /// <para>
        /// For custom request header insertion, when AWS WAF inserts the header into the request,
        /// it prefixes this name <code>x-amzn-waf-</code>, to avoid confusion with the headers
        /// that are already in the request. For example, for the header name <code>sample</code>,
        /// AWS WAF inserts the header <code>x-amzn-waf-sample</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the custom header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}