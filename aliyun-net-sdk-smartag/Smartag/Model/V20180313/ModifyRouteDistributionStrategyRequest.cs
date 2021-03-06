/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class ModifyRouteDistributionStrategyRequest : RpcAcsRequest<ModifyRouteDistributionStrategyResponse>
    {
        public ModifyRouteDistributionStrategyRequest()
            : base("Smartag", "2018-03-13", "ModifyRouteDistributionStrategy", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string routeSource;

		private long? resourceOwnerId;

		private string hcInstanceId;

		private string sourceType;

		private string destCidrBlock;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string routeDistribution;

		private long? ownerId;

		private string smartAGId;

		public string RouteSource
		{
			get
			{
				return routeSource;
			}
			set	
			{
				routeSource = value;
				DictionaryUtil.Add(QueryParameters, "RouteSource", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string HcInstanceId
		{
			get
			{
				return hcInstanceId;
			}
			set	
			{
				hcInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "HcInstanceId", value);
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string DestCidrBlock
		{
			get
			{
				return destCidrBlock;
			}
			set	
			{
				destCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "DestCidrBlock", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string RouteDistribution
		{
			get
			{
				return routeDistribution;
			}
			set	
			{
				routeDistribution = value;
				DictionaryUtil.Add(QueryParameters, "RouteDistribution", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
			}
		}

        public override ModifyRouteDistributionStrategyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyRouteDistributionStrategyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
