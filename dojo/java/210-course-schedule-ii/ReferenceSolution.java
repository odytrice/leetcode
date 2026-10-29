import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(courses + prerequisites) time. Kahn's algorithm emits one valid order. */
class ReferenceSolution extends Solution {
    @Override
    public int[] findOrder(int numCourses, int[][] prerequisites) {
        // edges[c] lists the courses that unlock after c; degree[c] counts c's unmet prerequisites.
        List<List<Integer>> edges = new ArrayList<>();
        for (int course = 0; course < numCourses; course += 1) {
            edges.add(new ArrayList<>());
        }
        int[] degree = new int[numCourses];
        // Each pair is {course, prerequisite}, so the edge runs from pair[1] to pair[0].
        for (int[] pair : prerequisites) {
            edges.get(pair[1]).add(pair[0]);
            degree[pair[0]] += 1;
        }
        // Courses with no prerequisites can be taken first.
        Deque<Integer> queue = new ArrayDeque<>();
        for (int course = 0; course < numCourses; course += 1) {
            if (degree[course] == 0) {
                queue.add(course);
            }
        }
        // Courses leave the queue in a valid order, so record them as they come out.
        int[] order = new int[numCourses];
        int count = 0;
        while (!queue.isEmpty()) {
            int course = queue.poll();
            order[count] = course;
            count += 1;
            for (int following : edges.get(course)) {
                degree[following] -= 1;
                if (degree[following] == 0) {
                    queue.add(following);
                }
            }
        }
        // A cycle leaves some courses unplaced, and then no order exists.
        return count == numCourses ? order : new int[] {};
    }
}
