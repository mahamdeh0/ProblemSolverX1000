public class IsAnagram
{
    public bool IsAnagram0(string s, string t)
    {
        if(s.Length == t.Length) return false;

        int[] store = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            store[s[i] - 'a']++;
            store[t[i] - 'a']--;
        }

        foreach (int n in store) if (n != 0) return false;

        return true;
       
    }
}
