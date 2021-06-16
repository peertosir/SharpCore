namespace LogicLib.CoreBasicVol2
{
    public struct BoxStruct
    {
        public int width { get; set; }
        public int length { get; set; }
        public override string ToString()
        {
            return $"Box: width={this.width}; length={this.length}";
        }
    }
}