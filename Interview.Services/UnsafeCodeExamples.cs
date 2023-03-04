namespace Interview.Services;

public class UnsafeCodeExamples
{
    public static unsafe string ChangeFirstCharAddressInMemory(string value, char target = '0')
    {
        var dublicate = (string)value.Clone();

        fixed (char* PIPtr = value)
        {
            PIPtr[0] = target;
        }

        return dublicate;
    }
}
