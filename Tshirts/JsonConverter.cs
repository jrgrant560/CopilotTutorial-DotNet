using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CopilotTutorial
{
    public class JsonTshirtConverter
    {
        public void Convert(string dbSource)
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
            string tShirtsJson = JsonConvert.SerializeObject(tShirts);
        }
    }

}