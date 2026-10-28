class ReferenceSolution:
    # O(n) time. Restart after every deficit; a total surplus guarantees one circuit.
    def can_complete_circuit(self, gas: list[int], cost: list[int]) -> int:
        total = tank = start = 0
        for index in range(len(gas)):
            difference = gas[index] - cost[index]
            total += difference
            tank += difference
            if tank < 0:
                start = index + 1
                tank = 0
        return -1 if total < 0 else start
