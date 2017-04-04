using DatabaseLayer;

namespace EmailService
{
    public class EmailService : IEmailService
    {
        /// <summary>
        /// Triggers the mail.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="uid">The uid.</param>
        /// <returns></returns>
        /// <author>karthik.jayakumar - 04-Apr-17 - 11:53 AM</author>
        public int TriggerMail(string userName, string uid)
        {
            return new Database().TriggerEmail(userName, uid);
        }
    }
}
