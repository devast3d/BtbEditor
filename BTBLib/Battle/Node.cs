using System;
using System.Collections.Generic;
using System.Text;

namespace BTBLib
{
    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public uint Radius { get; set; }
        public uint Direction { get; set; }
        public uint NodeID { get; set; }
        public uint UUID { get; set; }
        public uint ScriptFunc { get; set; }

        public enum USAGE { UNKNOWN4, DEPLOYMENT, UNKNOWN2, NONE }
        public USAGE Usage { get; set; }

        public Node(int x, 
                    int y, 
                    uint radius, 
                    uint direction, 
                    uint nodeID, 
                    uint UUID, 
                    uint scriptFunc,
                    USAGE usage)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
            this.Direction = direction;
            this.NodeID = nodeID;
            this.UUID = UUID;
            this.ScriptFunc = scriptFunc;
            this.Usage = usage;
        }
    }
}
