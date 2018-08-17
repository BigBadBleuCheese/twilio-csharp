/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Conference 
{

    /// <summary>
    /// Changes the status of the recording to paused, stopped, or in-progress
    /// </summary>
    public class UpdateRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The conference_sid
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The status to change the recording to.
        /// </summary>
        public RecordingResource.StatusEnum Status { get; }

        /// <summary>
        /// Construct a new UpdateRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="status"> The status to change the recording to. </param>
        public UpdateRecordingOptions(string pathConferenceSid, string pathSid, RecordingResource.StatusEnum status)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch an instance of a recording for a call
    /// </summary>
    public class FetchRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique conference Sid for the recording
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Fetch by unique recording Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Fetch by unique conference Sid for the recording </param>
        /// <param name="pathSid"> Fetch by unique recording Sid </param>
        public FetchRecordingOptions(string pathConferenceSid, string pathSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
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

    /// <summary>
    /// Delete a recording from your account
    /// </summary>
    public class DeleteRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique conference Sid for the recording
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Delete by unique recording Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> Fetch by unique conference Sid for the recording </param>
        /// <param name="pathSid"> Delete by unique recording Sid </param>
        public DeleteRecordingOptions(string pathConferenceSid, string pathSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
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

    /// <summary>
    /// Retrieve a list of recordings belonging to the call used to make the request
    /// </summary>
    public class ReadRecordingOptions : ReadOptions<RecordingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The conference_sid
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Filter by date created
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }

        /// <summary>
        /// Construct a new ReadRecordingOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        public ReadRecordingOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", DateCreated.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                if (DateCreatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated<", DateCreatedBefore.Value.ToString("yyyy-MM-dd")));
                }

                if (DateCreatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated>", DateCreatedAfter.Value.ToString("yyyy-MM-dd")));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}