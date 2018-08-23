/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.IpMessaging.V2.Service.User 
{

    /// <summary>
    /// List all Channels for a given User.
    /// </summary>
    public class ReadUserChannelOptions : ReadOptions<UserChannelResource> 
    {
        /// <summary>
        /// The unique id of the Service those channels belong to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique id of a User.
        /// </summary>
        public string PathUserSid { get; }

        /// <summary>
        /// Construct a new ReadUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The unique id of the Service those channels belong to. </param>
        /// <param name="pathUserSid"> The unique id of a User. </param>
        public ReadUserChannelOptions(string pathServiceSid, string pathUserSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchUserChannelOptions
    /// </summary>
    public class FetchUserChannelOptions : IOptions<UserChannelResource> 
    {
        /// <summary>
        /// The unique id of the Service those channels belong to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique id of a User.
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The unique id of a Channel.
        /// </summary>
        public string PathChannelSid { get; }

        /// <summary>
        /// Construct a new FetchUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The unique id of the Service those channels belong to. </param>
        /// <param name="pathUserSid"> The unique id of a User. </param>
        /// <param name="pathChannelSid"> The unique id of a Channel. </param>
        public FetchUserChannelOptions(string pathServiceSid, string pathUserSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
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
    /// UpdateUserChannelOptions
    /// </summary>
    public class UpdateUserChannelOptions : IOptions<UserChannelResource> 
    {
        /// <summary>
        /// The unique id of the Service those channels belong to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique id of a User.
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The unique id of a Channel.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Push notification level to be assigned to Channel of the User.
        /// </summary>
        public UserChannelResource.NotificationLevelEnum NotificationLevel { get; }

        /// <summary>
        /// Construct a new UpdateUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The unique id of the Service those channels belong to. </param>
        /// <param name="pathUserSid"> The unique id of a User. </param>
        /// <param name="pathChannelSid"> The unique id of a Channel. </param>
        /// <param name="notificationLevel"> Push notification level to be assigned to Channel of the User. </param>
        public UpdateUserChannelOptions(string pathServiceSid, 
                                        string pathUserSid, 
                                        string pathChannelSid, 
                                        UserChannelResource.NotificationLevelEnum notificationLevel)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
            NotificationLevel = notificationLevel;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (NotificationLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationLevel", NotificationLevel.ToString()));
            }

            return p;
        }
    }

}