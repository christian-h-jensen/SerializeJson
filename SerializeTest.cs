using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SerializeJson.Test
{
    [TestClass]
    public class SerializeTest
    {
        [TestMethod]
        public void JsonSerialize_can_serialize_a_person()
        {
            //Arrange
            var person = new Person();

            //Act
            var res = JsonSerializer.Serialize(person);

            //Assert
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void NewtonSoft_JsonSerialize_can_serialize_a_person()
        {
            //Arrange
            var person = new Person();

            //Act
            var res = JsonConvert.SerializeObject(person);

            //Assert
            Assert.IsNotNull(res);
        }
    }

    public class Person
    {
        public DateTime BirthDay { get; }

        public Person(DateTime birthDay = default)
        {
            BirthDay = birthDay;
        }
    }
}