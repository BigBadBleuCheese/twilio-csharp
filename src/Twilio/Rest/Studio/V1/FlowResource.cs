/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// FlowResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Studio.V1 
{

    public class FlowResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum Published = new StatusEnum("published");
        }

        private static Request BuildReadRequest(ReadFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Flows.
        /// </summary>
        /// <param name="options"> Read Flow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Flow </returns> 
        public static ResourceSet<FlowResource> Read(ReadFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FlowResource>.FromJson("flows", response.Content);
            return new ResourceSet<FlowResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Flows.
        /// </summary>
        /// <param name="options"> Read Flow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Flow </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<FlowResource>> ReadAsync(ReadFlowOptions options, 
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FlowResource>.FromJson("flows", response.Content);
            return new ResourceSet<FlowResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Flows.
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Flow </returns> 
        public static ResourceSet<FlowResource> Read(int? pageSize = null, 
                                                     long? limit = null, 
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadFlowOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Flows.
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Flow </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<FlowResource>> ReadAsync(int? pageSize = null, 
                                                                                             long? limit = null, 
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadFlowOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<FlowResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FlowResource>.FromJson("flows", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<FlowResource> NextPage(Page<FlowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FlowResource>.FromJson("flows", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<FlowResource> PreviousPage(Page<FlowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FlowResource>.FromJson("flows", response.Content);
        }

        private static Request BuildFetchRequest(FetchFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a specific Flow.
        /// </summary>
        /// <param name="options"> Fetch Flow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Flow </returns> 
        public static FlowResource Fetch(FetchFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Flow.
        /// </summary>
        /// <param name="options"> Fetch Flow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Flow </returns> 
        public static async System.Threading.Tasks.Task<FlowResource> FetchAsync(FetchFlowOptions options, 
                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a specific Flow.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Flow </returns> 
        public static FlowResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFlowOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Flow.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Flow </returns> 
        public static async System.Threading.Tasks.Task<FlowResource> FetchAsync(string pathSid, 
                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchFlowOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteFlowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific Flow.
        /// </summary>
        /// <param name="options"> Delete Flow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Flow </returns> 
        public static bool Delete(DeleteFlowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Flow.
        /// </summary>
        /// <param name="options"> Delete Flow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Flow </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFlowOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Flow.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Flow </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFlowOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Flow.
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Flow </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFlowOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FlowResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FlowResource object represented by the provided JSON </returns> 
        public static FlowResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FlowResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Flow.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The Status of this Flow
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FlowResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The latest version number of this Flow's definition.
        /// </summary>
        [JsonProperty("version")]
        public int? Version { get; private set; }
        /// <summary>
        /// The date this Flow was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Flow was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private FlowResource()
        {

        }
    }

}