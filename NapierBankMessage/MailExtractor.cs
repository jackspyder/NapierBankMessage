using System.Text.RegularExpressions;


namespace NapierBankMessage
{
    class MailExtractor
    {
        internal static string ExtractEmails(string body)
        {
            string cleaned = Regex.Replace(body, @"((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)", "<URL Removed>");

            return cleaned;
        }
    }
}
