using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string get_word(){
        Random rnd = new Random();
        
        string[] words = {"apple", "mother", "love", "attendance", "lab"};
        int word_num = rnd.Next(5);

        string word = words[word_num + 1];
        
        return word;
    }

    public void show_spaces(int word_legth){
        List<string> spaces = new List<string>();
        int length = word_legth;
        for (int i = 0; i < length; i++) 
            {
                spaces.Add("_");
            }

            Console.WriteLine(string.Join(" ",spaces));
    }       
}


public class Director
{   
    public static void Main(string[] args){
        
        Word new_word = new Word();

        string game_word = new_word.get_word();
        int word_length = game_word.Length;
        new_word.show_spaces(word_length);
        

    }
}
