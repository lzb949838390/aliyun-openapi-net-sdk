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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170825;
using System.Collections.Generic;

namespace Aliyun.Acs.Green.Model.V20170825
{
    public class ImageAsyncScanResultsRequest : RoaAcsRequest<ImageAsyncScanResultsResponse>
    {
        public ImageAsyncScanResultsRequest()
            : base("Green", "2017-08-25", "ImageAsyncScanResults", "green", "openAPI")
        {
			UriPattern = "/green/image/results";
			Method = MethodType.POST;
        }

		private string clientInfo;

		public string ClientInfo
		{
			get
			{
				return clientInfo;
			}
			set	
			{
				clientInfo = value;
				DictionaryUtil.Add(QueryParameters, "ClientInfo", value);
			}
		}

        public override ImageAsyncScanResultsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ImageAsyncScanResultsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}