// O(courses + prerequisites) time. Kahn's algorithm emits one valid order.
export function findOrder(numCourses: number, prerequisites: number[][]): number[] {
  const edges: number[][] = Array.from({ length: numCourses }, () => []);
  const degree = new Array<number>(numCourses).fill(0);
  for (const [course, prerequisite] of prerequisites) {
    edges[prerequisite].push(course);
    degree[course] += 1;
  }
  const queue: number[] = [];
  for (let course = 0; course < numCourses; course += 1) {
    if (degree[course] === 0) {
      queue.push(course);
    }
  }
  const order: number[] = [];
  while (queue.length > 0) {
    const course = queue.pop() as number;
    order.push(course);
    for (const following of edges[course]) {
      degree[following] -= 1;
      if (degree[following] === 0) {
        queue.push(following);
      }
    }
  }
  return order.length === numCourses ? order : [];
}
