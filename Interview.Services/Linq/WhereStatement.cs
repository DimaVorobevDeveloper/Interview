namespace Interview.Services.Linq;

public class WhereStatement
{
    public static List<int> GetMoreThanMin(List<int> list, int min = 10, int? take = null)
    {
        var r = list.Where(x => x >= min).Take(take ?? Int32.MaxValue).ToList();
        LogMin(min, take, r.Count);
        return r;
    }

    public static List<int> GetMoreThanMinWithConsole(List<int> list, int min = 10, int? take = null)
    {
        var r = list.Where(x => { Console.WriteLine(x); return x >= min; }).Take(take ?? Int32.MaxValue).ToList();
        LogMin(min, take, r.Count);
        return r;
    }

    public static List<int> GetLessThanMax(List<int> list, int max = 10, int? take = null)
    {
        var r = list.Where(x => x <= max).Take(take ?? Int32.MaxValue).ToList();
        LogMax(max, take, r.Count);
        return r;
    }

    public static List<int> GetLessThanMaxWithConsole(List<int> list, int max = 10, int? take = null)
    {
        var r = list.Where(x => { Console.WriteLine(x); return x <= max; }).Take(take ?? Int32.MaxValue).ToList();
        LogMax(max, take, r.Count);
        return r;
    }

    private static void LogMin(int min, int? take, int result)
    {
        Console.WriteLine($"list with min={min}, take={take ?? int.MaxValue} count = {result} элементов");
        Console.WriteLine("-");
    }

    private static void LogMax(int max, int? take, int result)
    {
        Console.WriteLine($"list with max={max}, take={take ?? int.MaxValue} count = {result} элементов");
        Console.WriteLine("-");
    }
}
