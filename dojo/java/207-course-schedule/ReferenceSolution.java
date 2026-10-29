import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(courses + prerequisites) time. Kahn's algorithm: peel off courses with no unmet prerequisite. */
class ReferenceSolution extends Solution {
    @Override
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        List<List<Integer>> edges = new ArrayList<>();
        for (int course = 0; course < numCourses; course += 1) {
            edges.add(new ArrayList<>());
        }
        int[] degree = new int[numCourses];
        for (int[] pair : prerequisites) {
            edges.get(pair[1]).add(pair[0]);
            degree[pair[0]] += 1;
        }
        Deque<Integer> queue = new ArrayDeque<>();
        for (int course = 0; course < numCourses; course += 1) {
            if (degree[course] == 0) {
                queue.add(course);
            }
        }
        int done = 0;
        while (!queue.isEmpty()) {
            int course = queue.poll();
            done += 1;
            for (int following : edges.get(course)) {
                degree[following] -= 1;
                if (degree[following] == 0) {
                    queue.add(following);
                }
            }
        }
        return done == numCourses;
    }
}
