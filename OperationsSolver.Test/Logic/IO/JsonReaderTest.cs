using OperationsSolver.Logic.IO;
using OperationsSolver.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OperationsSolver.Test.Logic.IO
{
    public class JsonReaderTest
    {
        private const string dataJsonPath = "./data.json";
        private readonly JsonSerializerOptions _options;

        public JsonReaderTest()
        {
           this._options = new JsonSerializerOptions();
            this._options.Converters.Add(new JsonStringEnumConverter());
        }


        [Fact]
        public void Read_Json_File_And_Deserialize_Not_Null()
        {
            IReader<Data> reader = new JsonReader<Data>();

            var data = reader.ReadFrom(dataJsonPath, this._options);

            Assert.NotNull(data);
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Has_Datasets()
        {
            IReader<Data> reader = new JsonReader<Data>();

            var data = reader.ReadFrom(dataJsonPath, this._options);

            Assert.All(data.Datasets, (d) => Assert.NotEmpty(d));
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Has_Generators()
        {
            IReader<Data> reader = new JsonReader<Data>();

            var data = reader.ReadFrom(dataJsonPath, this._options);

            Assert.NotEmpty(data.Generators);
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_File_Not_Found()
        {
            IReader<Data> reader = new JsonReader<Data>();

            Assert.Throws<FileNotFoundException>(() => reader.ReadFrom("./data1.json", this._options));
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Json_Exception()
        {
            IReader<Data> reader = new JsonReader<Data>();

            Assert.Throws<JsonException>(() => reader.ReadFrom("./dataBlank.json", this._options));
        }
    }
}
