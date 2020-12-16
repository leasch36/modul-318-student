namespace SwissTransport.Core
{
    using System.Threading.Tasks;

    using SwissTransport.Models;
    using System;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id, DateTime time, int ende);

        Connections GetConnections(string fromStation, string toStation, DateTime time, DateTime ende);
    }
}