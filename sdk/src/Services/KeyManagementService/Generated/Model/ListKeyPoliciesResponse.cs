/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListKeyPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<string> _policyNames = new List<string>();
        private bool? _truncated;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If <code>Truncated</code> is true, this value is present and contains the value to
        /// use for the <code>Marker</code> request parameter in a subsequent pagination request.
        /// 
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// A list of policy names. Currently, there is only one policy and it is named "Default".
        /// </para>
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this._policyNames; }
            set { this._policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this._policyNames != null && this._policyNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        /// A flag that indicates whether there are more items in the list. If your results were
        /// truncated, you can make a subsequent pagination request using the <code>Marker</code>
        /// request parameter to retrieve more policies in the list. 
        /// </para>
        /// </summary>
        public bool Truncated
        {
            get { return this._truncated.GetValueOrDefault(); }
            set { this._truncated = value; }
        }

        // Check to see if Truncated property is set
        internal bool IsSetTruncated()
        {
            return this._truncated.HasValue; 
        }

    }
}