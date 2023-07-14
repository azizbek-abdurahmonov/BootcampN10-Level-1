go:
var fio = Console.ReadLine();
var fio2 = fio.Split();

foreach (var f in fio2)
{

    var changed = Convert.ToString(f[0]);
    //Console.WriteLine($"Changed: {changed}");

    for (int i = 1; i < f.Length; i++)
    {
        if (f[i] >= 'A' && f[i] <= 'Z')
        {
            changed += Convert.ToChar(Convert.ToInt32(f[i]) + 32);
        }
        else
        {
            changed += f[i];
        }
    }

    Console.Write(changed + " ");

}
Console.WriteLine();
goto go;