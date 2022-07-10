using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string get_word()
    {
        Random rnd = new Random();
        
        string[] words = {"apple", "mother", "love", "attendance", "lab"};
        int word_num = rnd.Next(5);

        string word = words[word_num];
        
        return word;
    }
}

public class Player
{
    public char get_input()
    {
        
        Console.WriteLine("Please guess a Letter: ");
        string input = Console.ReadLine();
        char input_char = Convert.ToChar(input);

        return input_char;


    }
}

public class Jumper{
        public string shoot1 = "  _____   ";
        public string shoot2 = " /     \\";
        public string shoot3 = "|       |";
        public string shoot4 = " \\     /  ";
        public string shoot5 = "  \\   /     ";
        public string head = "    0     ";
        public string fail = "    x     ";
        public string body1 = "  / | \\ ";
        public string body2 = "   / \\" ; 
        public int score =  5;

        public void display(){
            if (score == 5)
            {
                Console.WriteLine(shoot1);
            }

            if (score >= 4)
            {
                Console.WriteLine(shoot2);
            }

            if (score >= 3)
            {
                Console.WriteLine(shoot3);
            }

            if (score >= 2)
            {
                Console.WriteLine(shoot4);
            }

            if (score >= 1)
            {
                Console.WriteLine(shoot5);
            }

            if (score > 0)
            {
                Console.WriteLine(head);
                Console.WriteLine(body1);
                Console.WriteLine(body2);
            }
            
            if (score <= 0)
            {
                Console.WriteLine(fail);
                Console.WriteLine(body1);
                Console.WriteLine(body2);
            }
        }




}



public class Director
{
    public static void Main(string[] args)
    {
        
        Word new_word = new Word();
        Player player = new Player();
        Jumper jumper = new Jumper();

        string game_word = new_word.get_word();
        int word_length = game_word.Length;
        char[] letters = game_word.ToCharArray();
        char[] spaces = new char[word_length];
        int score =  4;

        for (int i = 0; i < word_length; i++) 
            {
                spaces[i] = '_';
            }

        while(jumper.score > 0 ){
             
            jumper.display();

            Console.WriteLine(string.Join(" ",spaces));
            
            if(!spaces.Contains('_'))
            {
                break;
            }

            char input = player.get_input();


            if(game_word.Contains(input))
            {
                for(int i = 0; i < word_length; i++)
                {
                    if(letters[i] == input)
                    {

                        spaces[i] = letters[i]; 
                    
                    }
                }
            }

            else
            {
                jumper.score--;
            }
        }
        
        if (jumper.score == 0)
        {
            jumper.display();
            Console.WriteLine("YOU LOSE");
        }

        else
        {
            jumper.display();
            Console.WriteLine("YOU WIN");
        }
    }
}