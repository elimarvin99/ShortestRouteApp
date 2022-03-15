namespace ShortestRouteCalculator.Models
{
    public class ITrackable
    {
        string _identifier { get; set; }
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }
        public override string ToString()
        {
            return _identifier;
        }
        Point Location { get; set; }
    }
}
