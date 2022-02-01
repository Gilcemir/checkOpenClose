using System;
using System.Collections;

public class CheckOpenClose
{
    public static bool check(string str)
    {
        Stack myStack = new Stack();
        foreach (char c in str)
        {
            char x;
            switch (c)
            {
                case '(':
                case '{':
                case '[':
                    myStack.Push (c);
                    break;
                case ')':
                    if(myStack.Count == 0) return false;
                    x = Convert.ToChar(myStack.Pop());
                    if (x != '(') return false;
                    break;
                case '}':
                if(myStack.Count == 0) return false;
                    x = Convert.ToChar(myStack.Pop());
                    if (x != '{') return false;
                    break;
                case ']':
                    if(myStack.Count == 0) return false;
                    x = Convert.ToChar(myStack.Pop());
                    if (x != '[') return false;
                    break;
                default:
                    break;
            }
        }
        if (myStack.Count == 0) return true;
        return false;
    }

    public static void Main()
    {
        List<string> listaTeste = new List<string>();
        listaTeste.Add("()(){}[]");
        listaTeste.Add("[)");
        listaTeste.Add("[((()))]");
        listaTeste.Add("[}[");
        listaTeste.Add("");
        listaTeste.Add("([]())");
        listaTeste.Add("(a)(b)(c)");
        listaTeste.Add("))");

        foreach(string s in listaTeste)
        {
            Console.WriteLine($"string = {s} => {check(s)}");
        }
        Console.ReadLine();
    }
}
