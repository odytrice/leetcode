import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/** O(total emails log total emails) time. Unions accounts that share an email. */
class ReferenceSolution extends Solution {
    private int[] parent;

    @Override
    public List<List<String>> accountsMerge(List<List<String>> accounts) {
        parent = new int[accounts.size()];
        for (int account = 0; account < parent.length; account++) {
            parent[account] = account;
        }

        Map<String, Integer> owner = new HashMap<>();
        for (int account = 0; account < accounts.size(); account++) {
            for (String email : accounts.get(account).subList(1, accounts.get(account).size())) {
                Integer first = owner.get(email);
                if (first == null) {
                    owner.put(email, account);
                } else {
                    parent[find(account)] = find(first);
                }
            }
        }

        Map<Integer, List<String>> groups = new HashMap<>();
        for (Map.Entry<String, Integer> entry : owner.entrySet()) {
            int root = find(entry.getValue());
            groups.computeIfAbsent(root, key -> new ArrayList<>()).add(entry.getKey());
        }

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
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}
