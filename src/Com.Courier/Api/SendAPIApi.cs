/*
 * Courier API Reference
 *
 * The Courier REST API.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@courier.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Com.Courier.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISendAPIApiSync : IApiAccessor
    {
        #region Synchronous Operations

        InlineResponse200 SendPost(Send send = default(Send));

        InlineResponse202 SendPost(SendV2 sendV2 = default(SendV2));

        ApiResponse<InlineResponse200> SendPostWithHttpInfo(Send send = default(Send));

        ApiResponse<InlineResponse202> SendPostWithHttpInfo(SendV2 sendV2 = default(SendV2));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISendAPIApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        System.Threading.Tasks.Task<InlineResponse200> SendPostAsync(Send send = default(Send), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        System.Threading.Tasks.Task<InlineResponse202> SendPostAsync(SendV2 sendV2 = default(SendV2), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> SendPostWithHttpInfoAsync(Send send = default(Send), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> SendPostWithHttpInfoAsync(SendV2 sendV2 = default(SendV2), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISendAPIApi : ISendAPIApiSync, ISendAPIApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SendAPIApi : ISendAPIApi
    {
        private Com.Courier.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SendAPIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SendAPIApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendAPIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SendAPIApi(string basePath)
        {
            this.Configuration = Com.Courier.Client.Configuration.MergeConfigurations(
                Com.Courier.Client.GlobalConfiguration.Instance,
                new Com.Courier.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Com.Courier.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Courier.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Com.Courier.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendAPIApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SendAPIApi(Com.Courier.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Com.Courier.Client.Configuration.MergeConfigurations(
                Com.Courier.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Com.Courier.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Courier.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Com.Courier.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendAPIApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SendAPIApi(Com.Courier.Client.ISynchronousClient client, Com.Courier.Client.IAsynchronousClient asyncClient, Com.Courier.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Com.Courier.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Com.Courier.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Com.Courier.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Courier.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Courier.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// POST /send Send a notification to a specified recipient.
        /// </summary>
        /// <exception cref="Com.Courier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="send"> (optional)</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 SendPost(Send send = default(Send))
        {
            Com.Courier.Client.ApiResponse<InlineResponse200> localVarResponse = SendPostWithHttpInfo(send);
            return localVarResponse.Data;
        }

        public InlineResponse202 SendPost(SendV2 sendV2 = default(SendV2))
        {
            Com.Courier.Client.ApiResponse<InlineResponse202> localVarResponse = SendPostWithHttpInfo(sendV2);
            return localVarResponse.Data;
        }

        public Com.Courier.Client.ApiResponse<InlineResponse200> SendPostWithHttpInfo(Send send = default(Send))
        {
            Com.Courier.Client.RequestOptions localVarRequestOptions = new Com.Courier.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Courier.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Courier.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = send;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Com.Courier.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InlineResponse200>("/send", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        public Com.Courier.Client.ApiResponse<InlineResponse202> SendPostWithHttpInfo(SendV2 sendV2 = default(SendV2))
        {
            Com.Courier.Client.RequestOptions localVarRequestOptions = new Com.Courier.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Courier.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Courier.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = sendV2;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Com.Courier.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<InlineResponse202>("/send", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        public async System.Threading.Tasks.Task<InlineResponse200> SendPostAsync(Send send = default(Send), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Courier.Client.ApiResponse<InlineResponse200> localVarResponse = await SendPostWithHttpInfoAsync(send, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        public async System.Threading.Tasks.Task<InlineResponse202> SendPostAsync(SendV2 sendV2 = default(SendV2), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Courier.Client.ApiResponse<InlineResponse202> localVarResponse = await SendPostWithHttpInfoAsync(sendV2, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        public async System.Threading.Tasks.Task<Com.Courier.Client.ApiResponse<InlineResponse200>> SendPostWithHttpInfoAsync(Send send = default(Send), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Com.Courier.Client.RequestOptions localVarRequestOptions = new Com.Courier.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Com.Courier.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Courier.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = send;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Com.Courier.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse200>("/send", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        public async System.Threading.Tasks.Task<Com.Courier.Client.ApiResponse<InlineResponse202>> SendPostWithHttpInfoAsync(SendV2 sendV2 = default(SendV2), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Com.Courier.Client.RequestOptions localVarRequestOptions = new Com.Courier.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Com.Courier.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Courier.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = sendV2;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Com.Courier.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<InlineResponse202>("/send", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
