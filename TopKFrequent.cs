public class TopKFrequent
{
    public int[] TopKFrequent0(int[] nums, int k)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];

        for (int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }

        foreach (int n in nums)
        {
            if (count.ContainsKey(n))
            {
                count[n]++;
            }
            else
            {
                count[n] = 1;
            }
        }

        foreach (var entry in count)
        {
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--)
        {
            foreach (int n in freq[i])
            {
                res[index++] = n;
                if (index == k)
                {
                    return res;
                }
            }
        }
        return res;
    }
}
