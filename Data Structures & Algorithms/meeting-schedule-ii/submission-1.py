"""
Definition of Interval:
class Interval(object):
    def __init__(self, start, end):
        self.start = start
        self.end = end
"""

class Solution:
    def minMeetingRooms(self, intervals: List[Interval]) -> int:
        start_times = sorted([i.start for i in intervals])
        end_times = sorted([i.end for i in intervals])
        res, count = 0, 0
        start, end = 0, 0
        while start < len(intervals):
            if start_times[start] < end_times[end]:
                start += 1
                count += 1
            else:
                end += 1
                count -= 1
            res = max(res, count)
        return res
