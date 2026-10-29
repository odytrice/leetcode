public class ReferenceSolution : Solution
{
    // Union-find over accounts: two accounts that share an email belong to the same person.
    public override IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var parent = Enumerable.Range(0, accounts.Count).ToArray();
        // owner maps each email to the first account that listed it.
        var owner = new Dictionary<string, int>();

        // Path halving keeps the trees shallow.
        int Find(int x)
        {
            while (parent[x] != x)
            {
                parent[x] = parent[parent[x]];
                x = parent[x];
            }
            return x;
        }

        for (int i = 0; i < accounts.Count; i += 1)
        {
            foreach (string email in accounts[i].Skip(1))
            {
                if (owner.TryGetValue(email, out int j))
                {
                    // The email was seen before, so join this account with the earlier one.
                    parent[Find(i)] = Find(j);
                }
                else
                {
                    owner[email] = i;
                }
            }
        }

        // Gather every email under the root account of its group.
        var groups = new Dictionary<int, List<string>>();
        foreach (var (email, i) in owner)
        {
            int root = Find(i);
            if (!groups.ContainsKey(root))
            {
                groups[root] = [];
            }
            groups[root].Add(email);
        }

        var result = new List<IList<string>>();
        foreach (var (root, emails) in groups)
        {
            // The output lists the emails in sorted order after the name.
            emails.Sort(StringComparer.Ordinal);
            // Every account in a group has the same name, so take the root's.
            var account = new List<string> { accounts[root][0] };
            account.AddRange(emails);
            result.Add(account);
        }
        return result;
    }
}
