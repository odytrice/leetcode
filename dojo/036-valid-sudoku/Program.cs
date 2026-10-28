using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
char[][] Board() => Enumerable.Range(0, 9).Select(_ => new string('.', 9).ToCharArray()).ToArray();
Test("empty", () => Equal(true, s.IsValidSudoku(Board())));
Test("row duplicate", () => { var b = Board(); b[0][0] = b[0][8] = '5'; Equal(false, s.IsValidSudoku(b)); });
Test("column duplicate", () => { var b = Board(); b[0][0] = b[8][0] = '5'; Equal(false, s.IsValidSudoku(b)); });
Test("box duplicate", () => { var b = Board(); b[0][0] = b[1][1] = '5'; Equal(false, s.IsValidSudoku(b)); });
Test("separate units", () => { var b = Board(); b[0][0] = b[4][4] = '5'; Equal(true, s.IsValidSudoku(b)); });
return Finish();
