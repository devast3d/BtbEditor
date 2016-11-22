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
        public uint UnitID { get; set; }
        public uint ScriptFunc { get; set; }

        [Flags] public enum  USAGE { CENTREDPOINT=1,
                                     ISUNIT = 2,
                                     WAYPOINT = 4,
                                     UNK8 =8, UNK16=16, UNK32=32, UNK64=64,
                                     UNK128 =128, UNK256=256, UNK512=512,
                                     UNK1024 =1024, UNK2048=2048, UNK4096=4096,
                                     UNK8192=8192, UNK16384=16384, UNK32768=32768 }
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
            this.UnitID = UUID;
            this.ScriptFunc = scriptFunc;
            this.Usage = usage;
        }
    }
}
