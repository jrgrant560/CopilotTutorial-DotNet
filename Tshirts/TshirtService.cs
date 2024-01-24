using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CopilotTutorial
{
    public class TshirtService
    {
        // this method converts the db parameter into a string, then displays it in the terminal
        public void Display(string dbSource)
        {
            // Reading the contents of the "dbTshirts.json" file into a long string variable
            string json = File.ReadAllText(dbSource);

            // Deserializing the JSON string into a list of TShirt objects
            List<TShirt> tShirts = JsonConvert.DeserializeObject<List<TShirt>>(json);

            // Printing the details of each TShirt object in the list to the console
            foreach (TShirt tShirt in tShirts)
            {
                Console.WriteLine($"Id: {tShirt.Id}, TshirtName: {tShirt.TshirtName}, Logo: {tShirt.Logo}, Size: {tShirt.Size}");
            }

            // ALTERNATIVE FORMAT: Serializing the list of TShirt objects back into a JSON-readable string
            // string tShirtsJson = JsonConvert.SerializeObject(tShirts);
        }

        // this method appends a new Tshirt object to the end of the db parameter, then returns a confirmation message
        public void Add(string dbSource, TShirt newTShirt)
        {
            // Reading the contents of the "dbTshirts.json" file into a long string variable
            string json = File.ReadAllText(dbSource);

            // Deserializing the JSON string into a list of TShirt objects
            List<TShirt> tShirts = JsonConvert.DeserializeObject<List<TShirt>>(json);

            // Finding the TShirt object with the highest ID
            TShirt lastTShirt = tShirts[tShirts.Count - 1];

            // Setting the ID of the new TShirt object to 1 higher than the highest ID in the list
            newTShirt.Id = lastTShirt.Id + 1;

            // Adding the new TShirt object to the list
            tShirts.Add(newTShirt);

            // Serializing the list of TShirt objects back into a JSON-readable string
            string tShirtsJson = JsonConvert.SerializeObject(tShirts);

            // Writing the new JSON string to the "dbTshirts.json" file
            File.WriteAllText(dbSource, tShirtsJson);

            // Printing a confirmation message to the console
            Console.WriteLine($"Added TShirt with ID {newTShirt.Id} to the database.");
        }


        // this method deletes a Tshirt object from the db parameter, then returns a confirmation message
        public void Remove(string dbSource, int tShirtId)
        {
            // Reading the contents of the "dbTshirts.json" file into a long string variable
            string json = File.ReadAllText(dbSource);

            // Deserializing the JSON string into a list of TShirt objects
            List<TShirt> tShirts = JsonConvert.DeserializeObject<List<TShirt>>(json);

            // Finding the TShirt object with the matching ID
            TShirt tShirtToRemove = tShirts.Find(tShirt => tShirt.Id == tShirtId);

            // Removing the TShirt object from the list
            tShirts.Remove(tShirtToRemove);

            // Serializing the list of TShirt objects back into a JSON-readable string
            string tShirtsJson = JsonConvert.SerializeObject(tShirts);

            // Writing the new JSON string to the "dbTshirts.json" file
            File.WriteAllText(dbSource, tShirtsJson);

            // Printing a confirmation message to the console
            Console.WriteLine($"Removed TShirt with ID {tShirtId} from the database.");
        }
    
        // this method updates a Tshirt object in the db parameter, then returns a confirmation message
        public void Update(string dbSource, int tShirtId, TShirt updatedTShirt)
        {
            // Reading the contents of the "dbTshirts.json" file into a long string variable
            string json = File.ReadAllText(dbSource);

            // Deserializing the JSON string into a list of TShirt objects
            List<TShirt> tShirts = JsonConvert.DeserializeObject<List<TShirt>>(json);

            // Finding the TShirt object with the matching ID
            TShirt tShirtToUpdate = tShirts.Find(tShirt => tShirt.Id == tShirtId);

            // Updating the TShirt object in the list
            tShirtToUpdate.TshirtName = updatedTShirt.TshirtName;
            tShirtToUpdate.Logo = updatedTShirt.Logo;
            tShirtToUpdate.Size = updatedTShirt.Size;

            // Serializing the list of TShirt objects back into a JSON-readable string
            string tShirtsJson = JsonConvert.SerializeObject(tShirts);

            // Writing the new JSON string to the "dbTshirts.json" file
            File.WriteAllText(dbSource, tShirtsJson);

            // Printing a confirmation message to the console
            Console.WriteLine($"Updated TShirt with ID {tShirtId} in the database.");
        }
    
    }

}