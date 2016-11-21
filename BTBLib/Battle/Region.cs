using System;
using System.Collections.Generic;
using System.Text;

namespace BTBLib
{
    public class Region
    {
        public class LineSegment
        {
            public int StartX { get; set; }
            public int StartY { get; set; }
            public int EndX { get; set; }
            public int EndY { get; set; }

            public LineSegment(int startx, int starty, int endx, int endy)
            {
                this.StartX = startx;
                this.StartY = starty;
                this.EndX = endx;
                this.EndY = endy;
            }
        }

        public enum USAGE
		{
			SIGHT_EDGE,
			BOUNDARY,
			INV_BOUNDARY,
			PLAYER_DEPLOY,
            ENEMY_DEPLOY,
			PATH,
			BATTLE_EDGE
		}

        public bool IsClosed { get { return (Flags & 2) != 0; } }
		public bool IsOpen { get { return (Flags & 4) != 0; } }
		public bool IsBoundaryInversed { get { return (Flags & 16) != 0; } }
		public bool IsBattleBoundary { get { return (Flags & 32) != 0; } }
		public bool IsBoundary { get { return (Flags & 128) != 0; } }
		public bool IsP1DeployArea { get { return (Flags & 256) != 0; } }
		public bool IsP2DeployArea { get { return (Flags & 512) != 0; } }
		public bool IsVisibleArea { get { return (Flags & 1024) != 0; } }

		public string Name { get; set; }
        public List<LineSegment> Lines {get; private set;}
        public USAGE Usage { get; set; }
		public uint Flags;
		
        public Region(string name, uint flags)
        {
            this.Lines = new List<LineSegment>();
            this.Name = name;
			this.Flags = flags;
        }

        //public Region(int[][] pointList, string name, bool isClosed)
        //    :this(name, isClosed)
        //{
        //    int[] prev = pointList[0];
        //    for (int i = 1; i < pointList.Length; i++)
        //    {
        //        int[] cur = pointList[i];
        //        this.Lines.Add(new LineSegment(prev[0], prev[1], 
        //                                       cur[0], cur[1]));
        //        prev = cur;
        //    }
        //}
    }
}
