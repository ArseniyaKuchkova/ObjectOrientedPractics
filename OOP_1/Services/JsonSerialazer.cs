using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_1.Services
{
    internal class JsonSerialazer<T> where T : class
    {
        private readonly string path;
        public JsonSerialazer(string path)         
        {
            this.path = path;
        }
        public void serialize(List<T> obj)
        {
            FileStream outputStream = File.OpenWrite(path);
            var ser = new DataContractJsonSerializer(typeof(List<T>));
            ser.WriteObject(outputStream, obj);
            outputStream.Close();
        }

        public List<T> deserialize()
        {
            List<T> list = new List<T>();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<T>));
            using (MemoryStream  Stream = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText(path))))
            {
                list = json.ReadObject(Stream) as List<T>;
            }

            return list;
        }
        public void clear()
        {
            File.WriteAllText(path, "[]");
        }
        
    }
}
