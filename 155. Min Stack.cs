public class MinStack {
    Stack<int> stack { get; set; }
    Stack<int> minStack { get; set; }

    /** initialize your data structure here. */
    public MinStack() {
        this.stack = new Stack<int>();
        this.minStack = new Stack<int>();
    }

    public void Push(int x) {
        this.stack.Push(x);
        if(this.minStack.Count == 0){
            this.minStack.Push(x);
        }
        else{
            this.minStack.Push(Math.Min(x, this.minStack.Peek()));
        }
    }

    public void Pop() {
        this.minStack.Pop();
        this.stack.Pop();
    }

    public int Top() {
        return this.stack.Peek();
    }

    public int GetMin() {
        return this.minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
