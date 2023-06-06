using System.Collections;

namespace Interview.Services;

public class WorkWithCollection
{
    public delegate int OneDelegate(int b);
    // Задачка на выбор двух коллекций, из которых можно эффективно удалять данные в середине
    public int RemoveMiddleValueFromList(int a)
    {
        var l = new List<int> { 1, 2, 3, 4, 5, 6 };
        l.RemoveAt(5);

        var name = 1;

        var q = l.Where(x => x == name);

        name = 2;

        var user = q.FirstOrDefault();

        var t = RemoveMiddleValueFromArray(RemoveMiddleValueFromArray1);
        return t;

    }

    public int RemoveMiddleValueFromArray(OneDelegate d)
    {
        var l = new ArrayList(5) { 1, 2, 3, 4, 5, 6 };
        l.RemoveAt(3);

        d += i =>
        {
            var t = 10000;
            return t + i;
        };

        d += j =>
        {
            var t = 2000;
            return t + j;
        };

        d += RemoveMiddleValueFromArray1;
        // d -= RemoveMiddleValueFromArray1;
        var tt = d(77);

        return tt;
    }

    public int RemoveMiddleValueFromArray1(int a)
    {
        return a + 300;
    }
}