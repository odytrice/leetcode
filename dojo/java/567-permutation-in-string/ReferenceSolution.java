import java.util.Arrays;

/** O(len(s1) + len(s2)) time. Slides a fixed-width window and compares letter counts. */
class ReferenceSolution extends Solution {
    @Override
    public boolean checkInclusion(String s1, String s2) {
        // A longer pattern can never fit inside s2.
        if (s1.length() > s2.length()) {
            return false;
        }
        // need holds s1's letter counts; have holds the counts in the current window of s2.
        int[] need = new int[26];
        int[] have = new int[26];
        for (char letter : s1.toCharArray()) {
            need[letter - 'a'] += 1;
        }
        for (int index = 0; index < s2.length(); index += 1) {
            have[s2.charAt(index) - 'a'] += 1;
            // Drop the letter that just slid out so the window stays exactly s1.length() wide.
            if (index >= s1.length()) {
                have[s2.charAt(index - s1.length()) - 'a'] -= 1;
            }
            // Once the window is full, matching counts mean it is a permutation of s1.
            if (index >= s1.length() - 1 && Arrays.equals(have, need)) {
                return true;
            }
        }
        return false;
    }
}
