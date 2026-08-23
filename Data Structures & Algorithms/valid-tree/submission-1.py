from collections import deque, defaultdict
class Solution:
    def validTree(self, n: int, edges: List[List[int]]) -> bool:
        if len(edges) != n-1:
            return False
        visited = set()
        graph = defaultdict(list)
        for edge in edges:
            src = edge[0]
            dest = edge[1]
            graph[src].append(dest)
            graph[dest].append(src)
        queue = deque([0])
        while queue:
            node = queue.popleft()
            if node in visited:
                continue
            visited.add(node)
            for neighbor in graph[node]:
                if neighbor not in visited:
                    queue.append(neighbor)
        return len(visited) == n