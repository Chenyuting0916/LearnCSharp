// reference type v.s. value type

//value type

using System.Collections;

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
string string2;
string2 = "string222222222";
Console.WriteLine("string1:{0}, string2:{1}", string1, string2);


Console.WriteLine("string is primitive? {0}", typeof(string).IsPrimitive);
Console.WriteLine("IEnumerable is primitive? {0}", typeof(IEnumerable).IsPrimitive);
Console.WriteLine("int is primitive? {0}", typeof(int).IsPrimitive);