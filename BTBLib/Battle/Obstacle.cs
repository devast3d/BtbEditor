using System;
using System.Collections.Generic;
using System.Text;

namespace BTBLib
{
    public class Obstacle
    {
        [Flags] public enum PROP { ENABLED=1, MOVE_BLOCK=2, PROJ_BLOCK=4 };

        public PROP Properties { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public uint Radius { get; set; }
        public int Dir { get; set; }

		public bool IsMoveBlock { get { return (Properties & PROP.MOVE_BLOCK) == PROP.MOVE_BLOCK; } }
		public bool IsProjBlock { get { return (Properties & PROP.PROJ_BLOCK) == PROP.PROJ_BLOCK; } }

		public Obstacle(PROP properties, int x, int y, int z, uint radius, int dir)
        {
            this.Properties = properties;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Radius = radius;
            this.Dir = dir;
        }
    }
}
