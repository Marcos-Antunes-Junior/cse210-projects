using System;
//This program displays a scripture and through a loop, while the userInput == ""(enter), the program will
//hide each word of the scripture. When all words are hidden or if the userInput == "quit", the program will end.

class Program
{
    static void Main(string[] args)
    {
    Reference reference1 = new Reference("James", "1", "5", "6");
    Scripture scripture1 = new Scripture("If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and dupbraideth not; and it shall be given him.\n" +
    "But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.", reference1);
    //Each word of the scripture in a list.
    scripture1.WordList();
    string userInput;
    do{
    //Display the scripture.
    scripture1.Display();
    Console.Write("\n\nPress enter to hide a word or type 'quit' to exit: ");
    userInput = Console.ReadLine();
    //Hide each word of the scripture.
    scripture1.HideWords();
    Console.Clear();   
    //If all words are hidden, finish the program.
    if(scripture1.EverythingIsHidden() == false)
    {  
       scripture1.Display();
       break;
    }
    //Execute these commands while the user presses enter.
    }while(userInput == "");
    }
}