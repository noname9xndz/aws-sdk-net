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
    /// Container for the parameters to the UpdateUser operation.
    /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
    /// the home directory, role, and policy for the <code>UserName</code> and <code>ServerId</code>
    /// you specify.
    /// 
    ///  
    /// <para>
    /// The response returns the <code>ServerId</code> and the <code>UserName</code> for the
    /// updated user.
    /// </para>
    /// </summary>
    public partial class UpdateUserRequest : AmazonTransferRequest
    {
        private string _homeDirectory;
        private List<HomeDirectoryMapEntry> _homeDirectoryMappings = new List<HomeDirectoryMapEntry>();
        private HomeDirectoryType _homeDirectoryType;
        private string _policy;
        private PosixProfile _posixProfile;
        private string _role;
        private string _serverId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// Specifies the landing directory (folder) for a user when they log in to the server
        /// using their file transfer protocol client.
        /// </para>
        ///  
        /// <para>
        /// An example is <code>your-Amazon-S3-bucket-name&gt;/home/username</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string HomeDirectory
        {
            get { return this._homeDirectory; }
            set { this._homeDirectory = value; }
        }

        // Check to see if HomeDirectory property is set
        internal bool IsSetHomeDirectory()
        {
            return this._homeDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryMappings. 
        /// <para>
        /// Logical directory mappings that specify what Amazon S3 or Amazon EFS paths and keys
        /// should be visible to your user and how you want to make them visible. You will need
        /// to specify the "<code>Entry</code>" and "<code>Target</code>" pair, where <code>Entry</code>
        /// shows how the path is made visible and <code>Target</code> is the actual Amazon S3
        /// or Amazon EFS path. If you only specify a target, it will be displayed as is. You
        /// will need to also make sure that your IAM role provides access to paths in <code>Target</code>.
        /// The following is an example.
        /// </para>
        ///  
        /// <para>
        ///  <code>'[ "/bucket2/documentation", { "Entry": "your-personal-report.pdf", "Target":
        /// "/bucket3/customized-reports/${transfer:UserName}.pdf" } ]'</code> 
        /// </para>
        ///  
        /// <para>
        /// In most cases, you can use this value instead of the scope-down policy to lock down
        /// your user to the designated home directory ("<code>chroot</code>"). To do this, you
        /// can set <code>Entry</code> to '/' and set <code>Target</code> to the HomeDirectory
        /// parameter value.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the target of a logical directory entry does not exist in Amazon S3 or EFS, the
        /// entry will be ignored. As a workaround, you can use the Amazon S3 API or EFS API to
        /// create 0-byte objects as place holders for your directory. If using the AWS CLI, use
        /// the <code>s3api</code> or <code>efsapi</code> call instead of <code>s3</code> <code>efs</code>
        /// so you can use the put-object operation. For example, you use the following: <code>aws
        /// s3api put-object --bucket bucketname --key path/to/folder/</code>. Make sure that
        /// the end of the key name ends in a / for it to be considered a folder.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<HomeDirectoryMapEntry> HomeDirectoryMappings
        {
            get { return this._homeDirectoryMappings; }
            set { this._homeDirectoryMappings = value; }
        }

        // Check to see if HomeDirectoryMappings property is set
        internal bool IsSetHomeDirectoryMappings()
        {
            return this._homeDirectoryMappings != null && this._homeDirectoryMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryType. 
        /// <para>
        /// The type of landing directory (folder) you want your users' home directory to be when
        /// they log into the server. If you set it to <code>PATH</code>, the user will see the
        /// absolute Amazon S3 bucket or EFS paths as is in their file transfer protocol clients.
        /// If you set it <code>LOGICAL</code>, you will need to provide mappings in the <code>HomeDirectoryMappings</code>
        /// for how you want to make Amazon S3 or EFS paths visible to your users.
        /// </para>
        /// </summary>
        public HomeDirectoryType HomeDirectoryType
        {
            get { return this._homeDirectoryType; }
            set { this._homeDirectoryType = value; }
        }

        // Check to see if HomeDirectoryType property is set
        internal bool IsSetHomeDirectoryType()
        {
            return this._homeDirectoryType != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Allows you to supply a scope-down policy for your user so you can use the same IAM
        /// role across multiple users. The policy scopes down user access to portions of your
        /// Amazon S3 bucket. Variables you can use inside this policy include <code>${Transfer:UserName}</code>,
        /// <code>${Transfer:HomeDirectory}</code>, and <code>${Transfer:HomeBucket}</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For scope-down policies, AWS Transfer Family stores the policy as a JSON blob, instead
        /// of the Amazon Resource Name (ARN) of the policy. You save the policy as a JSON blob
        /// and pass it in the <code>Policy</code> argument.
        /// </para>
        ///  
        /// <para>
        /// For an example of a scope-down policy, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/users.html#users-policies-scope-down">Creating
        /// a scope-down policy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRole.html">AssumeRole</a>
        /// in the <i>AWS Security Token Service API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property PosixProfile. 
        /// <para>
        /// Specifies the full POSIX identity, including user ID (<code>Uid</code>), group ID
        /// (<code>Gid</code>), and any secondary groups IDs (<code>SecondaryGids</code>), that
        /// controls your users' access to your Amazon Elastic File Systems (Amazon EFS). The
        /// POSIX permissions that are set on files and directories in your file system determines
        /// the level of access your users get when transferring files into and out of your Amazon
        /// EFS file systems.
        /// </para>
        /// </summary>
        public PosixProfile PosixProfile
        {
            get { return this._posixProfile; }
            set { this._posixProfile = value; }
        }

        // Check to see if PosixProfile property is set
        internal bool IsSetPosixProfile()
        {
            return this._posixProfile != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that controls your users' access to your Amazon S3 bucket. The policies
        /// attached to this role determine the level of access you want to provide your users
        /// when transferring files into and out of your S3 bucket or buckets. The IAM role should
        /// also contain a trust relationship that allows the server to access your resources
        /// when servicing your users' transfer requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server instance that the user account is
        /// assigned to.
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

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique string that identifies a user and is associated with a server as specified
        /// by the <code>ServerId</code>. This user name must be a minimum of 3 and a maximum
        /// of 100 characters long. The following are valid characters: a-z, A-Z, 0-9, underscore
        /// '_', hyphen '-', period '.', and at sign '@'. The user name can't start with a hyphen,
        /// period, or at sign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=100)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}