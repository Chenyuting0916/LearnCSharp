namespace LeetCode;

public class AddBinary
{
    public string Add_Binary(string a, string b) {
        var a1 = Convert.ToInt64(a, 2);
        var b1 = Convert.ToInt64(b, 2);
        var value = a1 + b1;
        return Convert.ToString(value, 2);
        
        //大數不行
    }
    
    public string Add_Binary2(string a, string b) {
        var sum = new List<int>();
        for (int i = a.Length - 1, j = b.Length - 1, carry = 0; i >= 0 || j >= 0 || carry > 0; i--, j--)
        {
            // a[i] - '0' means char a[i] => integer
            var firstDigit = i >= 0 ? a[i] - '0' : 0;
            var secondDigit = j >= 0 ? b[j] - '0' : 0;
            var sumDigit = firstDigit + secondDigit + carry;
            carry = sumDigit / 2;
            sum.Add(sumDigit % 2);
        }
        sum.Reverse();
        return String.Concat(sum);
    }
}