public static class Myfunctions
{
    //append an array with an array
    // larger array with the contents of both in order
    public static T[] ArrAppend<T>(T[] lhs, T[] rhs)
    {
        T[] temp = new T[lhs.Length + rhs.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            if (i < lhs.Length)
            {
                temp[i] = lhs[i];
            }
            else
            {
                temp[i] = rhs[i - lhs.Length];
            }
        }
        return temp;
    }


}
