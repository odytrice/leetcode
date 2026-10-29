import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/** O(total emails log total emails) time. Unions accounts that share an email. */
class ReferenceSolution extends Solution {
    // parent[a] points toward account a's set representative; a root points to itself.
    private int[] parent;

    @Override
    public List<List<String>> accountsMerge(List<List<String>> accounts) {
        parent = new int[accounts.size()];
        for (int account = 0; account < parent.length; account += 1) {
            parent[account] = account;
        }

        // owner maps each email to the first account that listed it.
        Map<String, Integer> owner = new HashMap<>();
        for (int account = 0; account < accounts.size(); account += 1) {
            // Index 0 is the name, so the emails start at index 1.
            for (String email : accounts.get(account).subList(1, accounts.get(account).size())) {
                Integer first = owner.get(email);
                if (first == null) {
                    owner.put(email, account);
                } else {
                    // A shared email means both accounts belong to the same person.
                    parent[find(account)] = find(first);
                }
            }
        }

        // Gather every email under the representative account of its set.
        Map<Integer, List<String>> groups = new HashMap<>();
        for (Map.Entry<String, Integer> entry : owner.entrySet()) {
            int root = find(entry.getValue());
            groups.computeIfAbsent(root, key -> new ArrayList<>()).add(entry.getKey());
        }

        // Each merged account is the name followed by its emails in sorted order.
        List<List<String>> result = new ArrayList<>();
        for (Map.Entry<Integer, List<String>> entry : groups.entrySet()) {
            List<String> emails = entry.getValue();
            Collections.sort(emails);
            List<String> account = new ArrayList<>();
            account.add(accounts.get(entry.getKey()).get(0));
            account.addAll(emails);
            result.add(account);
        }
        return result;
    }

    private int find(int node) {
        while (parent[node] != node) {
            // Path halving: point at the grandparent so later lookups are shorter.
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}
