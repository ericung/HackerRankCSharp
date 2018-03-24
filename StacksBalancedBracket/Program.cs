using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Solution
{
    public Boolean IsOpener (char open)
    {
        if ((open == '{')||(open == '[')||(open == '('))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Boolean IsMatch (char matching,char close)
    {
        if ((matching == '{') && (close == '}'))
        {
            return true;
        }
        else if ((matching == '(') && (close == ')'))
        {
            return true;
        }
        else if ((matching == '[') && (close == ']'))
        {
            return true;
        }

        return false;
    }

    public Boolean ValidateExpression(string expression)
    {
        Stack<char> characterStack = new Stack<char>();
        characterStack.Push(expression[0]);

        for(int index = 1; index < expression.Length; index++)
        {
            if ((characterStack.Count != 0)&&(IsMatch(characterStack.Peek(),expression[index])))
            {
                characterStack.Pop();
            }
            else if (IsOpener(expression[index]))
            {
                characterStack.Push(expression[index]);
            }
            else
            {
                return false;
            }
        }

        if (characterStack.Count == 0)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        string[] expression = new string[t];
        Solution solution = new Solution();

        for (int a0 = 0; a0 < t; a0++)
        {
            expression[a0] = Console.ReadLine();
        }

        foreach(string s in expression)
        {
            if (solution.ValidateExpression(s))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
