using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using static PayPal.Test.TestHarness;

namespace PayPal.Payments.Test
{
    [Collection("Payments")]
    public class PaymentListTest
    {

        [Fact]
        public async void TestPaymentListRequest()
        {
            PaymentListRequest request = new PaymentListRequest()
                .Count(2);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal((int) response.StatusCode, 200);
            Assert.NotNull(response.Result<PaymentHistory>());
        }
    }
}