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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class GetOfficeEditURLRequest : RpcAcsRequest<GetOfficeEditURLResponse>
    {
        public GetOfficeEditURLRequest()
            : base("imm", "2017-09-06", "GetOfficeEditURL", "imm", "openAPI")
        {
        }

		private string srcType;

		private string project;

		private string userID;

		private string notifyEndpoint;

		private string fileID;

		private string notifyTopicName;

		private string fileName;

		private string srcUri;

		private string tgtUri;

		private string userName;

		public string SrcType
		{
			get
			{
				return srcType;
			}
			set	
			{
				srcType = value;
				DictionaryUtil.Add(QueryParameters, "SrcType", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string UserID
		{
			get
			{
				return userID;
			}
			set	
			{
				userID = value;
				DictionaryUtil.Add(QueryParameters, "UserID", value);
			}
		}

		public string NotifyEndpoint
		{
			get
			{
				return notifyEndpoint;
			}
			set	
			{
				notifyEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "NotifyEndpoint", value);
			}
		}

		public string FileID
		{
			get
			{
				return fileID;
			}
			set	
			{
				fileID = value;
				DictionaryUtil.Add(QueryParameters, "FileID", value);
			}
		}

		public string NotifyTopicName
		{
			get
			{
				return notifyTopicName;
			}
			set	
			{
				notifyTopicName = value;
				DictionaryUtil.Add(QueryParameters, "NotifyTopicName", value);
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(QueryParameters, "FileName", value);
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
				DictionaryUtil.Add(QueryParameters, "SrcUri", value);
			}
		}

		public string TgtUri
		{
			get
			{
				return tgtUri;
			}
			set	
			{
				tgtUri = value;
				DictionaryUtil.Add(QueryParameters, "TgtUri", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetOfficeEditURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetOfficeEditURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
