public class RecentCounter {

    int counter;
    Queue<int> q = new Queue<int>();

    public RecentCounter() {
        counter = 0;
    }
    
    public int Ping(int t) {
        q.Enqueue(t);
        counter += 1;
        while (q.Count > 0 && (q.Peek() > t || q.Peek() < (t - 3000)))
        {
            q.Dequeue();
            counter -= 1;
        }

        return counter;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
