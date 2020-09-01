using System;
using System.IO;
namespace AnimeShippingGen
{
    class AnimeCharakter{
        public String name;
        public String animeTitel;
        
        public AnimeCharakter(String name2, String animeTitel2) {
            this.name = name2;
            this.animeTitel = animeTitel2; 
        }
        public String toString() {
            return $"{name}({animeTitel})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String path = "textfile.txt";
            string[] lines = File.ReadAllLines(path);  
            int linesCount = lines.Length;  
            AnimeCharakter[] charaktere = new AnimeCharakter[linesCount];
            for(int i = 0; i < linesCount; i++) {
                String words = lines[i];
                String[] splitWords = words.Split(", ");
                AnimeCharakter a = new AnimeCharakter(splitWords[0], splitWords[1]);
                charaktere[i] = a;
            }
            var rand = new Random();
            var rand2 = new Random(rand.Next(232323));
            var randomNumber1 = rand.Next(linesCount);
            var randomNumber2 = rand2.Next(linesCount);
            while(randomNumber1 == randomNumber2) {
                randomNumber1 = rand.Next(linesCount);
                randomNumber2 = rand2.Next(linesCount);
            }
            
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"output.txt", true))
        {
            file.WriteLine(charaktere[randomNumber1].toString() + " x " + charaktere[randomNumber2].toString());
        }

    }


            
            
        }
    }

