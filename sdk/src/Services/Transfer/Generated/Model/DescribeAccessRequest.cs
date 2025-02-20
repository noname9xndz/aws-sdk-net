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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccess operation.
    /// Describes the access that is assigned to the specific file transfer protocol-enabled
    /// server, as identified by its <code>ServerId</code> property and its <code>ExternalID</code>.
    /// 
    ///  
    /// <para>
    /// The response from this call returns the properties of the access that is associated
    /// with the <code>ServerId</code> value that was specified.
    /// </para>
    /// </summary>
    public partial class DescribeAccessRequest : AmazonTransferRequest
    {
        private string _externalId;
        private string _serverId;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// A unique identifier that is required to identify specific groups within your directory.
        /// The users of the group you associate have access to your Amazon S3 or Amazon EFS resources
        /// over the enabled protocols using AWS Transfer Family. If you know the group name,
        /// you can view the SID values by running the following command using Windows PowerShell.
        /// </para>
        ///  
        /// <para>
        ///  <code>Get-ADGroup -Filter {samAccountName -like "<i>YourGroupName</i>*"} -Properties
        /// * | Select SamaccountName,ObjectSid</code> 
        /// </para>
        ///  
        /// <para>
        /// In that command, replace <i>YourGroupName</i> with the name of your Active Directory
        /// group.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// uppercase and lowercase alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server that has this access assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

    }
}