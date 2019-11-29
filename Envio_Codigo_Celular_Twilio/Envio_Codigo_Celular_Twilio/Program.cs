using System;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Api.V2010.Account;

namespace Envio_Codigo_Celular_Twilio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const string accountSid = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
                const string authToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: "Código de confirmação 1591",
                    from: new Twilio.Types.PhoneNumber("+55xxxxxxxxxxx"),
                    to: new Twilio.Types.PhoneNumber("+55xxxxxxxxxxx")
                );

                Console.WriteLine(message.Sid);

            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Twilio Error {e.Code} - {e.MoreInfo}");
            }
        }
    }
}
