using lab5_WPF.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab5_WPF.Serialization
{
    public class DataSerializer
    {
        public static void Serialize(string fileName, DataModel data)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static DataModel Deserialize(string fileName)
        {
            var stream = new FileStream(fileName, FileMode.Open);
            var formatter = new BinaryFormatter();
            return (DataModel)formatter.Deserialize(stream);
        }
    }
}
