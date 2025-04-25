using System;

class Program
{
    static void Main() {
        string input = "22 1 22#";
        string output = oldPhonePad(input);
        Console.WriteLine("Output "+ output);
        input = "00122#";
        output = oldPhonePad(input);
        Console.WriteLine("Output "+ output);
        input = "22022#";
        output = oldPhonePad(input);
        Console.WriteLine("Output "+ output);
        input = "9911*1166 6622#";
        output = oldPhonePad(input);
        Console.WriteLine("Output "+ output);
        input = "033*77#";
        output = oldPhonePad(input);
        Console.WriteLine("Output "+ output);
    }
    
    public static String oldPhonePad(string input){
        Stack<char> letterStack = new Stack<char>();
        String output = "";
        foreach(char letter in input){
            
            if (letter == '#'){
                output += clearTheStack(letterStack);
                break;
            }
            else if(letter == '0'){
                output += clearTheStack(letterStack);
                output += ' ';
            }
            else if(Char.IsNumber(letter)){
                if(letterStack.Count == 0 || letterStack.Peek() == letter){
                    letterStack.Push(letter);
                }
                else if(letterStack.Peek() != letter){
                    output += clearTheStack(letterStack);
                }
            }
            else if( letter == ' '){
                output += clearTheStack(letterStack);
            }
            else if(letter =='*'){
                if(letterStack.Count == 0){continue;}
                letterStack.Clear();
            }

        }
        return output;
    }
    
    public static string clearTheStack(Stack<char> letterStack){
        string number = "";
        string output = "";
        while(letterStack.Count != 0){
            number += letterStack.Pop().ToString();
        }
        output += getLetter(number);
        return output;
    }
    
    public static char? getLetter(string number){
        switch(number){
            case "1": return '&';
            case "11": return '\'';
            case "111": return '(';
            case "2": return 'A';
            case "22": return 'B';
            case "222": return 'C';
            case "3": return 'D';
            case "33": return 'E';
            case "333": return 'F';
            case "4": return 'G';
            case "44": return 'H';
            case "444": return 'I';
            case "5": return 'J';
            case "55": return 'K';
            case "555": return 'L';
            case "6": return 'M';
            case "66": return 'N';
            case "666": return 'O';
            case "7": return 'P';
            case "77": return 'Q';
            case "777": return 'R';
            case "7777": return 'S';
            case "8": return 'T';
            case "88": return 'U';
            case "888": return 'V';
            case "9": return 'W';
            case "99": return 'X';
            case "999": return 'Y';
            case "9999": return 'Z';
        }
        return null;
    }
}
