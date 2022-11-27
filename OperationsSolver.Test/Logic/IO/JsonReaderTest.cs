using OperationsSolver.Infrastructure.IO;
using OperationsSolver.Models;
using System.Text.Json;

namespace OperationsSolver.Test.Logic.IO
{
    public class JsonReaderTest
    {
        private const string dataJsonPath = "./data.json";

        [Fact]
        public void Read_Json_File_And_Deserialize_Not_Null()
        {
            JsonReader<Data> reader = new();

            var data = reader.ReadFrom(dataJsonPath);

            Assert.NotNull(data);
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Has_Datasets()
        {
            JsonReader<Data> reader = new();

            var data = reader.ReadFrom(dataJsonPath);

            Assert.All(data.Datasets, (d) => Assert.NotEmpty(d));
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Has_Generators()
        {
            JsonReader<Data> reader = new();

            var data = reader.ReadFrom(dataJsonPath);

            Assert.NotEmpty(data.Generators);
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_File_Not_Found()
        {
            JsonReader<Data> reader = new();

            Assert.Throws<FileNotFoundException>(() => reader.ReadFrom("./data1.json"));
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Json_Exception()
        {
            JsonReader<Data> reader = new();

            Assert.Throws<JsonException>(() => reader.ReadFrom("./dataBlank.json"));
        }
    }
}
