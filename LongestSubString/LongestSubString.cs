namespace LeetCode
{
    public static class LongestSubString
    {
        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            string subString = s[0].ToString();
            int maxLength = 1;
            int startIndex = 0;
            for (int i = 1; i < s.Length; i++)
            {

                if (!subString.Contains(s[i]))
                {
                    subString += s[i];
                    if (subString.Length > maxLength)
                        maxLength = subString.Length;

                }
                else
                {
                    i = ++startIndex;
                    subString = s[i].ToString();
                }
            }

            return maxLength;
        }
    }
}
