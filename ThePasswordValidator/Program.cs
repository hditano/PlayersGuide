// See https://aka.ms/new-console-template for more information

using System.Security;

Password myPass = new Password();
myPass.PasswordChecker("Hernancito0T");


class Password
{
    public void PasswordChecker(string password)
    {
        bool isUpper = false;
        bool isLower = false;
        bool isDigit = false;
        bool isTorAmpersand = false;
        char T = 'T';
        char Ampersand = '&';

        if(password.Length > 6 && password.Length <= 13)
        {
            foreach(char i in password)
            {
                if (char.IsDigit(i)) isDigit = true;
                if (char.IsUpper(i)) isUpper = true;
                if (char.IsLower(i)) isLower = true;
                if (i != T || i != Ampersand) isTorAmpersand = true;
            }
            Console.Write($"Upper: {isUpper} | Lower: {isLower} | Digit: {isDigit} | T or Ampersand {isTorAmpersand}");
        }
        else
        {
            Console.WriteLine("Something failed");
        }
    }
}
