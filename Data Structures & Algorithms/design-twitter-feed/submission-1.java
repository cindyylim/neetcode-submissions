class Twitter {
    private class Tweet {
        private int timestamp;
        private int tweetId;
        public Tweet(int timestamp, int tweetId) {
            this.timestamp = timestamp;
            this.tweetId = tweetId;
        }
    }
    private int time = 0;
    private Map<Integer, Set<Integer>> following;
    private Map<Integer, List<Tweet>> tweets;
    public Twitter() {
        tweets = new HashMap<>();
        following = new HashMap<>();
    }
    
    public void postTweet(int userId, int tweetId) {
        Tweet newTweet = new Tweet(time, tweetId);
        time ++;
        tweets.putIfAbsent(userId, new ArrayList<>());
        tweets.get(userId).add(newTweet);
    }
    
    public List<Integer> getNewsFeed(int userId) {
        PriorityQueue<Tweet> maxHeap = new PriorityQueue<>((a, b) -> Integer.compare(b.timestamp, a.timestamp));
        if (tweets.containsKey(userId)) {
            maxHeap.addAll(tweets.get(userId));
        }
        if (following.containsKey(userId)) {
            for (int followeeId: following.get(userId)) {
                if (tweets.containsKey(followeeId)) {
                    maxHeap.addAll(tweets.get(followeeId));
                }
            }
        } 
        List<Integer> result = new ArrayList<>();
        while(!maxHeap.isEmpty() && result.size() < 10) {
            result.add(maxHeap.remove().tweetId);
        }
        return result;
     }
    
    public void follow(int followerId, int followeeId) {
        following.putIfAbsent(followerId, new HashSet<>());
        following.get(followerId).add(followeeId);
    }
    
    public void unfollow(int followerId, int followeeId) {
        if (following.containsKey(followerId)) {
            following.get(followerId).remove(followeeId);
        }
    }
}
