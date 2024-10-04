public class GroupAnagrams
{
    public List<List<string>> GroupAnagrams0(string[] strs)
    {
        var ans = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var count = new int[26];
            foreach (var c in s)
            {
                count[c - 'a']++;
            }

            var key = string.Join(',', count);
            if (!ans.ContainsKey(key))
            {
                ans[key] = new List<string>();
            }

            ans[key].Add(s);
        }

        return new List<List<string>>(ans.Values);
    }
}
