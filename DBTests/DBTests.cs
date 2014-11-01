using System;
using DB;
using NUnit.Framework;

namespace DBTests
{
    
    public class DBTests
    {
        [Test]
        public void ShouldConnectToDB()
        {
            //given
            DBConnector connector; 
            //when
            connector = new DBConnector();
            //then
            Assert.Pass();
        }
        [Test]
        public void ShouldOpenConnection()
        {
            //given
            DBConnector connector = new DBConnector();
            //when
            connector.Open();
            //then
            Assert.Pass();
        }
    }
}
