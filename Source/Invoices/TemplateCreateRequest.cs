// This class was generated on Mon, 08 Jan 2018 16:45:18 CST by version 0.1 of Braintree SDK Generator
// TemplateCreateRequest.cs
// @version 0.1
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Invoices
{
    /// <summary>
    /// Creates a template.
    /// </summary>
    public class TemplateCreateRequest : HttpRequest
    {
        public TemplateCreateRequest() : base("/v1/invoicing/templates?", HttpMethod.Post, typeof(Template))
        {
            
            this.ContentType =  "application/json";
        }
        

        public TemplateCreateRequest RequestBody(Template Body) 
        {
            this.Body = Body;
            return this;
        }
    }
}