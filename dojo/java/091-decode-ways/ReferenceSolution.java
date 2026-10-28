/** O(n) time, O(1) space. Each position is reached as one digit or as a valid pair. */
class ReferenceSolution extends Solution {
    @Override
    public int numDecodings(String s) {
        int previous = 1;
        int current = s.charAt(0) == '0' ? 0 : 1;
        for (int index = 1; index < s.length(); index++) {
            int following = s.charAt(index) == '0' ? 0 : current;
            int pair = (s.charAt(index - 1) - '0') * 10 + (s.charAt(index) - '0');
            if (pair >= 10 && pair <= 26) {
                following += previous;
            }
            previous = current;
            current = following;
        }
        return current;
    }
}
