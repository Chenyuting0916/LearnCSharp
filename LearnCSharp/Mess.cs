using System.Collections;
using Newtonsoft.Json;

namespace LearnCSharp;

public class Mess
{
    public void MessMethod()
    {
        // reference type v.s. value type

        //value type
        var a = 10;
        var b = a;
        b++;
        Console.WriteLine("a:{0}, b:{1}", a, b);


        //reference type
        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;
        Console.WriteLine("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]);


        //try something
        var string1 = "string";
        var string2 = string1;
        string2 = "string222222222";
        string2 += "333";
        Console.WriteLine("string1:{0}, string2:{1}", string1, string2);


        Console.WriteLine("string is primitive? {0}", typeof(string).IsPrimitive);
        Console.WriteLine("IEnumerable is primitive? {0}", typeof(IEnumerable).IsPrimitive);
        Console.WriteLine("int is primitive? {0}", typeof(int).IsPrimitive);


        Console.WriteLine("contains: {0}", "123".Contains(string.Empty));


        var aa = new List<string> { "aaa07", "aaa08", "aaa09", "aaa01", "aaa02" };
        var bb = new List<string> { "aaa02", "aaa09", "aaa08", "aaa01", "aaa07" };


        var bb2 = bb.OrderBy(x => aa.IndexOf(x)).ToList();

        Console.WriteLine(JsonConvert.SerializeObject(bb2));


        var accounts = new List<Account>
        {
            new()
            {
                Id = 1,
                Name = "tim"
            },
            new()
            {
                Id = 1,
                Name = "tim"
            }
        };


        // var account1 = accounts.Single();
        var account2 = accounts.First();
    }


    private class Account
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}