using System;

public class Word
{
    public void get_word(){
        string word = "AHHHH";

        Console.WriteLine($"The new word is {word}");
    }
    

}


public class Director
{   
    public static void Main(string[] args){
        
        Word new_word = new Word();
        new_word.get_word();
    }

}
