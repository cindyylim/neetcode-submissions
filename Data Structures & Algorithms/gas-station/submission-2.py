class Solution:
    def canCompleteCircuit(self, gas: List[int], cost: List[int]) -> int:
        if sum(gas) < sum(cost):
            return -1
        currGas = 0
        res = 0
        for i, g in enumerate(gas):
            currGas += g - cost[i]
            if currGas < 0:
                currGas = 0
                res = i + 1
        return res
    