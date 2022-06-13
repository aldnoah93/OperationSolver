using OperationsSolver.Logic.IO;
using OperationsSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OperationsSolver.Test.IO
{
    public class JsonReaderTest
    {
        private const string dataJsonPath = "./data.json";


        [Fact]
        public void Read_Json_File_And_Deserialize_Not_Null()
        {
            IReader<Data> reader = new JsonReader();

            var data = reader.ReadFrom(dataJsonPath);

            Assert.NotNull(data);
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Has_Datasets()
        {
            IReader<Data> reader = new JsonReader();

            var data = reader.ReadFrom(dataJsonPath);

            Assert.All(data.Datasets, (d) => Assert.NotEmpty(d));
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Has_Generators()
        {
            IReader<Data> reader = new JsonReader();

            var data = reader.ReadFrom(dataJsonPath);

            Assert.NotEmpty(data.Generators);
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_File_Not_Found()
        {
            IReader<Data> reader = new JsonReader();

            Assert.Throws<FileNotFoundException>(() => reader.ReadFrom("./data1.json"));
        }

        [Fact]
        public void Read_Json_File_And_Deserialize_Json_Exception()
        {
            IReader<Data> reader = new JsonReader();

            Assert.Throws<JsonException>(() => reader.ReadFrom("./dataBlank.json"));
        }
    }
}
