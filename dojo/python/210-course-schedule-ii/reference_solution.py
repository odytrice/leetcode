class ReferenceSolution:
    # O(courses + prerequisites) time. Kahn's algorithm emits one valid order.
    def find_order(self, num_courses: int, prerequisites: list[list[int]]) -> list[int]:
        edges: list[list[int]] = [[] for _ in range(num_courses)]
        degree = [0] * num_courses
        for course, prerequisite in prerequisites:
            edges[prerequisite].append(course)
            degree[course] += 1
        queue = [course for course in range(num_courses) if degree[course] == 0]
        order: list[int] = []
        while queue:
            course = queue.pop()
            order.append(course)
            for following in edges[course]:
                degree[following] -= 1
                if degree[following] == 0:
                    queue.append(following)
        return order if len(order) == num_courses else []
