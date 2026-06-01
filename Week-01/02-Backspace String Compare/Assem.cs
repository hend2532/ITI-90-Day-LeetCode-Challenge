// Author: Assem
// Problem: Backspace String Compare
// Link: https://leetcode.com/problems/backspace-string-compare/
// Time: O(n + m) | Space: O(n + m)

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        List<char> s1 = new();
        List<char> s2 = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#' && s1.Count == 0)
            {
                continue;
            }
            else if (s[i] == '#')
            {
                s1.RemoveAt(s1.Count - 1);
            }
            else
            {
                s1.Add(s[i]);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == '#' && s2.Count == 0)
            {
                continue;
            }
            else if (t[i] == '#')
            {
                s2.RemoveAt(s2.Count - 1);
            }
            else
            {
                s2.Add(t[i]);
            }
        }

        if (s1.Count != s2.Count)
            return false;

        for (int i = 0; i < s1.Count; i++)
        {
            if (s1[i] != s2[i])
                return false;
        }

        return true;
    }
}
