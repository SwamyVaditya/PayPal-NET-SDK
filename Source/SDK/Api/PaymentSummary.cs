//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// The payment and refund summary.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class PaymentSummary : PayPalSerializableObject
    {
        /// <summary>
        /// The total amount paid or refunded through PayPal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paypal")]
        public Currency paypal { get; set; }

        /// <summary>
        /// The total amount paid or refunded through other sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "other")]
        public Currency other { get; set; }
    }
}