class ReferenceSolution:
    # O(n) time, O(1) space. Move the shorter wall inward; it can only improve.
    def max_area(self, height: list[int]) -> int:
        left, right = 0, len(height) - 1
        best = 0
        while left < right:
            best = max(best, (right - left) * min(height[left], height[right]))
            if height[left] <= height[right]:
                left += 1
            else:
                right -= 1
        return best
