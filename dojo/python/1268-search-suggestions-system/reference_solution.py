from bisect import bisect_left


class ReferenceSolution:
    # O(sorted products + prefix searches). Sort once, then read three matches per prefix.
    def suggested_products(self, products: list[str], search_word: str) -> list[list[str]]:
        ordered = sorted(products)
        result: list[list[str]] = []
        for length in range(1, len(search_word) + 1):
            prefix = search_word[:length]
            start = bisect_left(ordered, prefix)
            suggestions: list[str] = []
            index = start
            while index < len(ordered) and len(suggestions) < 3 and ordered[index].startswith(prefix):
                suggestions.append(ordered[index])
                index += 1
            result.append(suggestions)
        return result
