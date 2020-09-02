using System;
using System.IO;
namespace AnimeShippingGen
{
    
    class Program
    {
        static void Main(string[] args)
        {
        
        //define path for input and output file
        String readFile = "input.txt";
        String writeFile = "output.txt";
        //create file if it doesn't exist
        if(!File.Exists(readFile)) {
        FileStream fs = File.Create(readFile);
        }
        //some predefined characters from My Hero Academia
        String[] preCharacters = {"Ochako, MHA", "Deku, MHA", "Bakugo, MHA", "Shoto, MHA"};
        //add precharacters if file is empty
        if(File.ReadAllLines(readFile).Length == 0) {
            System.IO.File.WriteAllLines(readFile, preCharacters);
        }
        //read all lines
        String[] lines = File.ReadAllLines(readFile);

        
       

        //format the input from the text file
        String[] characters = new String[lines.Length];
        for(int i = 0; i < lines.Length; i++) {
            String[] words = lines[i].Split(", ");
            characters[i] = $"{words[0]}({words[1]})";
        }
        
        Random rand = new Random();
        int randomNumber1 = rand.Next(lines.Length - 1);
        Random rand2 = new Random(rand.Next(110223));
        int randomNumber2 = rand2.Next(lines.Length - 1);
        while(randomNumber1 == randomNumber2) {
               randomNumber1 = rand.Next(lines.Length - 1);
               randomNumber2 = rand2.Next(lines.Length - 1);
            }
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(writeFile, true))
        {
            file.WriteLine(characters[randomNumber1] + " x " + characters[randomNumber2]);
        }



            
        }
    }
}

