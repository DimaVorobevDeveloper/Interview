namespace Interview.Services.WorkWithMemory;

public class RefTypeDiffFromStruct
{
    public static (int RefVal, int ValueVal) BoxStructAndCompareWithRefType()
    {
        Class c = new Class(1);
        Struct s = new Struct(2);

        object oc = c;
        object os = s; // упаковка в ссылочный тип

        c.Id = 3;
        s.Id = 4;

        Console.WriteLine(((Class)oc).Id + " " + ((Struct)os).Id);

        return (((Class)oc).Id, ((Struct)os).Id);
    }
}

class Class
{
    public int Id { get; set; }

    public Class(int id)
    {
        Id = id;
    }
}

struct Struct
{
    public int Id { get; set; }

    public Struct(int id)
    {
        Id = id;
    }
}
