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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAssetModel operation
    /// </summary>  
    public class DescribeAssetModelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAssetModelResponse response = new DescribeAssetModelResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("assetModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.AssetModelCreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelHierarchies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetModelHierarchy, AssetModelHierarchyUnmarshaller>(AssetModelHierarchyUnmarshaller.Instance);
                    response.AssetModelHierarchies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelLastUpdateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.AssetModelLastUpdateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetModelProperty, AssetModelPropertyUnmarshaller>(AssetModelPropertyUnmarshaller.Instance);
                    response.AssetModelProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelStatus", targetDepth))
                {
                    var unmarshaller = AssetModelStatusUnmarshaller.Instance;
                    response.AssetModelStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIoTSiteWiseException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeAssetModelResponseUnmarshaller _instance = new DescribeAssetModelResponseUnmarshaller();        

        internal static DescribeAssetModelResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAssetModelResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}