using System;

public class Scale<T>
    where T : IComparable<T>
{
    private readonly T left;
    private readonly T right;

    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    public T GetHeavier()
    {
        int comparator = this.left.CompareTo(this.right);

        if (comparator == 0)
        {
            return default(T);
        }

        return comparator > 0 ? this.left : this.right;
    }
}
