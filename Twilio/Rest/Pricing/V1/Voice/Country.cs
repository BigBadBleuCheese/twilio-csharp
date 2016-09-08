using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Fetchers.Pricing.V1.Voice;
using Twilio.Http;
using Twilio.Readers.Pricing.V1.Voice;
using Twilio.Types;

namespace Twilio.Rest.Pricing.V1.Voice {

    public class Country : SidResource {
        /**
         * read
         * 
         * @return CountryReader capable of executing the read
         */
        public static CountryReader Read() {
            return new CountryReader();
        }
    
        /**
         * fetch
         * 
         * @param isoCountry The iso_country
         * @return CountryFetcher capable of executing the fetch
         */
        public static CountryFetcher Fetch(string isoCountry) {
            return new CountryFetcher(isoCountry);
        }
    
        /**
         * Converts a JSON string into a Country object
         * 
         * @param json Raw JSON string
         * @return Country object represented by the provided JSON
         */
        public static Country FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<Country>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("country")]
        private readonly string country;
        [JsonProperty("iso_country")]
        private readonly string isoCountry;
        [JsonProperty("outbound_prefix_prices")]
        private readonly List<OutboundPrefixPrice> outboundPrefixPrices;
        [JsonProperty("inbound_call_prices")]
        private readonly List<InboundCallPrice> inboundCallPrices;
        [JsonProperty("price_unit")]
        private readonly string priceUnit;
        [JsonProperty("url")]
        private readonly Uri url;
    
        public Country() {
        
        }
    
        private Country([JsonProperty("country")]
                        string country, 
                        [JsonProperty("iso_country")]
                        string isoCountry, 
                        [JsonProperty("outbound_prefix_prices")]
                        List<OutboundPrefixPrice> outboundPrefixPrices, 
                        [JsonProperty("inbound_call_prices")]
                        List<InboundCallPrice> inboundCallPrices, 
                        [JsonProperty("price_unit")]
                        string priceUnit, 
                        [JsonProperty("url")]
                        Uri url) {
            this.country = country;
            this.isoCountry = isoCountry;
            this.outboundPrefixPrices = outboundPrefixPrices;
            this.inboundCallPrices = inboundCallPrices;
            this.priceUnit = priceUnit;
            this.url = url;
        }
    
        /**
         * @return The iso_country
         */
        public override string GetSid() {
            return this.GetIsoCountry();
        }
    
        /**
         * @return The country
         */
        public string GetCountry() {
            return this.country;
        }
    
        /**
         * @return The iso_country
         */
        public string GetIsoCountry() {
            return this.isoCountry;
        }
    
        /**
         * @return The outbound_prefix_prices
         */
        public List<OutboundPrefixPrice> GetOutboundPrefixPrices() {
            return this.outboundPrefixPrices;
        }
    
        /**
         * @return The inbound_call_prices
         */
        public List<InboundCallPrice> GetInboundCallPrices() {
            return this.inboundCallPrices;
        }
    
        /**
         * @return The price_unit
         */
        public string GetPriceUnit() {
            return this.priceUnit;
        }
    
        /**
         * @return The url
         */
        public Uri GetUrl() {
            return this.url;
        }
    }
}