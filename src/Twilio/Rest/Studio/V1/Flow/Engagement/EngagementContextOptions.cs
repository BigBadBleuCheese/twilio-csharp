/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V1.Flow.Engagement 
{

    /// <summary>
    /// Retrieve the most recent context for an Engagement.
    /// </summary>
    public class FetchEngagementContextOptions : IOptions<EngagementContextResource> 
    {
        /// <summary>
        /// Flow Sid.
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// Engagement Sid.
        /// </summary>
        public string PathEngagementSid { get; }

        /// <summary>
        /// Construct a new FetchEngagementContextOptions
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        public FetchEngagementContextOptions(string pathFlowSid, string pathEngagementSid)
        {
            PathFlowSid = pathFlowSid;
            PathEngagementSid = pathEngagementSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}