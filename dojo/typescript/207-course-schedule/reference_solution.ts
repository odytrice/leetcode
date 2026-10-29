// O(courses + prerequisites) time. Kahn's algorithm: peel off courses with no unmet prerequisite.
export function canFinish(numCourses: number, prerequisites: number[][]): boolean {
  // edges[p] lists the courses that p unlocks; degree[c] counts c's unmet prerequisites.
  const edges: number[][] = Array.from({ length: numCourses }, () => []);
  const degree = new Array<number>(numCourses).fill(0);
  for (const [course, prerequisite] of prerequisites) {
    edges[prerequisite].push(course);
    degree[course] += 1;
  }
  // Start with every course that has no prerequisites.
  const queue: number[] = [];
  for (let course = 0; course < numCourses; course += 1) {
    if (degree[course] === 0) {
      queue.push(course);
    }
  }
  let done = 0;
  while (queue.length > 0) {
    const course = queue.pop() as number;
    done += 1;
    for (const following of edges[course]) {
      // Taking this course satisfies one prerequisite of each course it unlocks.
      degree[following] -= 1;
      if (degree[following] === 0) {
        queue.push(following);
      }
    }
  }
  // Courses never taken are stuck in a cycle.
  return done === numCourses;
}
