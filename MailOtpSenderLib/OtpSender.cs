using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MailOtpSenderLib
{
    public class OtpSender
    {
        public bool Send(int otp, string phoneNumber)
        {
            TwilioClient.Init(ConfigurationManager.AppSettings.Get("twilioAccountSid"), ConfigurationManager.AppSettings.Get("twilioAuthToken"));
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                | SecurityProtocolType.Tls11
                                                | SecurityProtocolType.Tls12
                                                | SecurityProtocolType.Ssl3;
            try
            {
                var message = MessageResource.Create(
                body: "Your OTP for HostelX Signup/2FA is: " + otp,
                from: new Twilio.Types.PhoneNumber(ConfigurationManager.AppSettings.Get("twilioPhoneNumber")),
                to: new Twilio.Types.PhoneNumber("+88" + phoneNumber)
            );
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return false;
            }
            return true;
        }
    }
}
