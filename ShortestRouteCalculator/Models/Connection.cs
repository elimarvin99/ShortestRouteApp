namespace ShortestRouteCalculator.Models
{
    public class Connection
    {
        ITrackable _a, _b;
        int _weight;
        bool selected = false;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public Connection(ITrackable a, ITrackable b, int weight)
        {
            this._a = a;
            this._b = b;
            this._weight = weight;
        }
        public ITrackable B
        {
            get { return _b; }
            set { _b = value; }
        }

        public ITrackable A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
