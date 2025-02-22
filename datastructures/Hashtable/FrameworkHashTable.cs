using System;
using System.Collections;

namespace MyDataStructure
{
    public class FrameworkHashTable
    {
        public static void Run()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1,"One"); //adding a key/value using the Add() method
            numberNames.Add(2,"Two");
            numberNames.Add(3,"Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach(DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
                    
            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
                    
            foreach(DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

        }   
    }
}