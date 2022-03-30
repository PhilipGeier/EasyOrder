using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using OrderingSystem.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OrderingSystem.Logic.Json
{
    public class JsonLogic<T>
    {
        /*private void CreateFilename(T obj)
        {
            if (obj.GetType() == typeof(Table))
                _filename = "tables.json";
            else if (obj.GetType() == typeof(Ingredient))
                _filename = "ingredients.json";
            else if (obj.GetType() == typeof(Item))
                _filename = "items.json";
            else if (obj.GetType() == typeof(Category))
                _filename = "categories.json";
            else
                _filename = "temp.json";            
        }*/
        
        public static List<T> Get(string filename)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;
            
                using (StreamReader sw = new StreamReader(filename))
                using (JsonReader reader = new JsonTextReader(sw))
                {
                    return serializer.Deserialize<List<T>>(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<T>();
            }

        }

        public static void Put(List<T> input, string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.Formatting = Formatting.Indented;

            using StreamWriter sw = new StreamWriter(filename);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, input);
                // {"ExpiryDate":new Date(1230375600000),"Price":0}
            }
        }
    }
}