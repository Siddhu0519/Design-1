public class hashset
{
    private const int s = 1000;
    private List<int>[] b;
    public hashset()
    {
        b = new List<int>[size];
        for (int i = 0; i < s; i++)
        {
            b[i] = new List<int>();
        }
    }
    private int getindex(int key)
    {
        return key % s;
    }
    public void add(int key)
    {
        int index = getindex(key);
        if (!b[index].Contains(key))
        {
            b[index].add(key);
        }
    }
    public void remove(int key)
    {
        int index = getindex(key);
        if (b[index].Contains(key))
        {
            b[index].remove(key);
        }
    }
    public void contains(int key)
    {
        int index = getindex(key);
        return b[index].contains(key);
    }
}