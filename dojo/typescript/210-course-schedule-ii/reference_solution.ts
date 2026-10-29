// O(courses + prerequisites) time. Kahn's algorithm emits one valid order.
export function findOrder(numCourses: number, prerequisites: number[][]): number[] {
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
  const order: number[] = [];
  while (queue.length > 0) {
    const course = queue.pop() as number;
    // A course is ready only after all its prerequisites were added to the order.
    order.push(course);
    for (const following of edges[course]) {
      degree[following] -= 1;
      if (degree[following] === 0) {
        queue.push(following);
      }
    }
  }
  // A short order means some courses are in a cycle, so no order exists.
  return order.length === numCourses ? order : [];
}
