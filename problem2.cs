public class MinStack
{
    private Stack<int> stak;
    private Stack<int> minstak;
    public MinStack()
    {
        stak=new Stack<int>();
        minstak=new Stack<int>();
    }
    public void Push(int val)
    {
        stak.Push(val);
        if (minstak.Count==0 || val<=minstak.Peek())
        {
            minstak.Push(val);
        }
    }
    public void Pop()
    {
        int top=stak.Pop();
        if (top==minstak.Peek())
        {
            minstak.Pop();
        }
    }
    public int Top()
    {
        return stak.Peek();
    }
    public int GetMin()
    {
        return minstak.Peek();
    }
}
