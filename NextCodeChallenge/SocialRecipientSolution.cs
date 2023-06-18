using System.Text.RegularExpressions;

namespace NextCodeChallnge
{
    public class SocialRecipientSolution
    {
        public string GetRecipient_UsingRegx(string message, int position)
        {
            if (position < 1) return string.Empty;

            Regex regex = new Regex("@[a-zA-Z0-9_-][\\w'-]+");
            var recipients = regex.Matches(message);

            return position > recipients.Count ? string.Empty : recipients[position - 1].Value.Remove(0, 1);
        }

        public string GetRecipient_UsingWhile(string message, int position)
        {
            if (position < 1)
            {
                return string.Empty;
            }

            int current = 0;
            int nthUser = 0;
            char[] chars = message.ToCharArray();
            int messageLength = chars.Length;
            char identifierSymbol = '@';

            while (current < messageLength)
            {
                while (current < messageLength && chars[current] != identifierSymbol)
                {
                    current++;
                }

                if (current >= messageLength)
                {
                    return string.Empty;
                }

                current++;
                nthUser++;
                int start = current;
                char ch = chars[current];
                while (current < messageLength && IsValidChar(ch))
                {
                    current++;
                    ch = chars[current];
                }

                if (nthUser == position)
                {
                    return message.Substring(start, current - start);
                }
            }

            return string.Empty;
        }
        private bool IsValidChar(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') ||
                    (ch >= 'a' && ch <= 'z') ||
                    (ch >= '0' && ch <= '9') ||
                    ch == '_' ||
                    ch == '-';
        }
    }
}
