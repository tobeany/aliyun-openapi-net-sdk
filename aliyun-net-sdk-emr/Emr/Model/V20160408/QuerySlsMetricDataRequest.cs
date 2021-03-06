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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class QuerySlsMetricDataRequest : RpcAcsRequest<QuerySlsMetricDataResponse>
    {
        public QuerySlsMetricDataRequest()
            : base("Emr", "2016-04-08", "QuerySlsMetricData", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private long? period;

		private string regionId;

		private string clusterId;

		private long? startTimeStamp;

		private string metricName;

		private string hostRole;

		private string accessKeyId;

		private long? endTimeStamp;

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

		public long? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public long? StartTimeStamp
		{
			get
			{
				return startTimeStamp;
			}
			set	
			{
				startTimeStamp = value;
				DictionaryUtil.Add(QueryParameters, "StartTimeStamp", value.ToString());
			}
		}

		public string MetricName
		{
			get
			{
				return metricName;
			}
			set	
			{
				metricName = value;
				DictionaryUtil.Add(QueryParameters, "MetricName", value);
			}
		}

		public string HostRole
		{
			get
			{
				return hostRole;
			}
			set	
			{
				hostRole = value;
				DictionaryUtil.Add(QueryParameters, "HostRole", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public long? EndTimeStamp
		{
			get
			{
				return endTimeStamp;
			}
			set	
			{
				endTimeStamp = value;
				DictionaryUtil.Add(QueryParameters, "EndTimeStamp", value.ToString());
			}
		}

        public override QuerySlsMetricDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QuerySlsMetricDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
