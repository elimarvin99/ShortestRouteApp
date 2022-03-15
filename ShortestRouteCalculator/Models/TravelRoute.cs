﻿namespace ShortestRouteCalculator.Models
{
    public class TravelRoute
    {
        int _cost;
        List<Connection> _connections;
        string _identifier;

        public TravelRoute(string _identifier)
        {
            _cost = int.MaxValue;
            _connections = new List<Connection>();
            this._identifier = _identifier;
        }


        public List<Connection> Connections
        {
            get { return _connections; }
            set { _connections = value; }
        }
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public override string ToString()
        {
            return "Id:" + _identifier + " Cost:" + Cost;
        }
    }
}
