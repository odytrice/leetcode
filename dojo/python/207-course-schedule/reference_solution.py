class ReferenceSolution:
    # O(courses + prerequisites) time. Kahn's algorithm: peel off courses with no unmet prerequisite.
    def can_finish(self, num_courses: int, prerequisites: list[list[int]]) -> bool:
        edges: list[list[int]] = [[] for _ in range(num_courses)]
        degree = [0] * num_courses
        for course, prerequisite in prerequisites:
            edges[prerequisite].append(course)
            degree[course] += 1
        queue = [course for course in range(num_courses) if degree[course] == 0]
        done = 0
        while queue:
            course = queue.pop()
            done += 1
            for following in edges[course]:
                degree[following] -= 1
                if degree[following] == 0:
                    queue.append(following)
        return done == num_courses
