tring CustomJoin(string[] arr, string sep)
{
    string a = "";
    for (int i = 0; i < arr.Length; i++)
    {


        if (i == arr.Length - 1)
        {
            a += arr[i];

        }
        else
        {
            a += arr[i] + sep;
        }



    }
    return a;

}
Console.WriteLine(CustomJoin(new string[] { "1", "2", "3" }, "-"));

