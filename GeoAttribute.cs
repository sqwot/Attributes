using System;


namespace Attributes {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    class GeoAttribute: System.Attribute {
        public int X { get; set; }
        public int Y { get; set; }
        public GeoAttribute() { }


        public GeoAttribute(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() {
            return $"X = {X}, Y = {Y}";
        }
    }
}
