class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        rows = [set() for _ in range(9)]
        cols = [set() for _ in range(9)]
        boxes = [set() for _ in range(9)]

        for i in range(len(board)):
            for j in range(len(board[0])):
                if board[i][j] == '.':
                    continue
                box = (i // 3) * 3 + (j // 3)
                num = board[i][j]
                if num in rows[i] or num in cols[j] or num in boxes[box]:
                    return False
                rows[i].add(num)
                cols[j].add(num)
                boxes[box].add(num)
        return True