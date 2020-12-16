namespace SwissTransport
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using SwissTransport.Core;

    /// <summary>
    /// The Swiss Transport API tests.
    /// </summary>
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = this.testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            DateTime time = DateTime.Now;
            var stationBoard = this.testee.GetStationBoard("Sursee", "8502007", time, 6);

            Assert.IsNotNull(stationBoard);
        }

        /*
        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            DateTime time = DateTime.Now;
            DateTime date = 
            var connections = this.testee.GetConnections("Sursee", "Luzern", date , time);

            Assert.IsNotNull(connections);
        }*/
    }
}
