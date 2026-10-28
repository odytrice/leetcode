class ReferenceSolution:
    # O(n) time. A monotonic stack holds days still waiting for a warmer day.
    def daily_temperatures(self, temperatures: list[int]) -> list[int]:
        answer = [0] * len(temperatures)
        waiting: list[int] = []
        for today, temperature in enumerate(temperatures):
            while waiting and temperatures[waiting[-1]] < temperature:
                earlier = waiting.pop()
                answer[earlier] = today - earlier
            waiting.append(today)
        return answer
