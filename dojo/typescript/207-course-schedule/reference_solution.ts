// O(courses + prerequisites) time. Kahn's algorithm: peel off courses with no unmet prerequisite.
export function canFinish(numCourses: number, prerequisites: number[][]): boolean {
  const edges: number[][] = Array.from({ length: numCourses }, () => []);
  const degree = new Array<number>(numCourses).fill(0);
  for (const [course, prerequisite] of prerequisites) {
    edges[prerequisite].push(course);
    degree[course]++;
  }
  const queue: number[] = [];
  for (let course = 0; course < numCourses; course++) if (degree[course] === 0) queue.push(course);
  let done = 0;
  while (queue.length > 0) {
    const course = queue.pop() as number;
    done++;
    for (const following of edges[course]) {
      if (--degree[following] === 0) queue.push(following);
    }
  }
  return done === numCourses;
}
