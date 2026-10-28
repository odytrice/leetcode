class ReferenceSolution:
    # O(total emails log total emails) time. Union accounts that share an email.
    def accounts_merge(self, accounts: list[list[str]]) -> list[list[str]]:
        parent = list(range(len(accounts)))

        def find(node: int) -> int:
            while parent[node] != node:
                parent[node] = parent[parent[node]]
                node = parent[node]
            return node

        owner: dict[str, int] = {}
        for index, account in enumerate(accounts):
            for email in account[1:]:
                if email in owner:
                    parent[find(index)] = find(owner[email])
                else:
                    owner[email] = index

        groups: dict[int, list[str]] = {}
        for email, index in owner.items():
            groups.setdefault(find(index), []).append(email)

        result: list[list[str]] = []
        for root, emails in groups.items():
            result.append([accounts[root][0]] + sorted(emails))
        return result
