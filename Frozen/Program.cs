using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;
            

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
               
            }

            //getters for Gift

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

            
        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSantas = new List<SecretSanta>();
            string[] secretsSantaFromFile = GetDataFromFile();

            foreach (string line in secretsSantaFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newSecretSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSantas.Add(newSecretSanta);
            }

            foreach (SecretSanta giftFromList in mySecretSantas)
            {
                Console.WriteLine($" {giftFromList.Name} wants {giftFromList.Gift}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Rauno\samples\gifts.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }

}
