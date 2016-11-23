using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BTBLib
{
    public class BTBSaver
    {
        static public void Save(Battle btl, string path)
        {
            using (FileStream FS = new FileStream(path, FileMode.Create))
            {
                BTBWriter BTBW = new BTBWriter(FS);

                BTBW.WriteObjectHeader(0xBEAFEED0, 0); // Identifies as a BTB file
                WriteMapHeaderObject(btl, BTBW);
                WriteObjectivesObject(btl, BTBW);
                WriteObstaclesObject(btl, BTBW);
                WriteRegionObjects(btl, BTBW);
                WriteNodesObject(btl, BTBW);
                BTBW.WriteObjectHeader(0xBEAFEED0, 0); // Identifies as a BTB file
            }
        }

        private static void WriteNodesObject(Battle btl, BTBWriter BTBW)
        {
            BTBW.WriteObjectHeader(5, 12 + 104 * btl.Nodes.Count);
            BTBW.WriteIntTupleProperty(8, btl.Nodes.Count);
            foreach (Node node in btl.Nodes)
            {
                BTBW.WritePropertyHeader(503, 104);
                BTBW.WriteIntTupleProperty(5, (int)node.Usage);
                BTBW.WriteIntTupleProperty(1, node.X);
                BTBW.WriteIntTupleProperty(2, node.Y);
                BTBW.WriteIntTupleProperty(6, (int)node.Radius);
                BTBW.WriteIntTupleProperty(7, node.Direction);
                BTBW.WriteIntTupleProperty(11, (int)node.NodeID);
                BTBW.WriteIntTupleProperty(12, (int)node.UnitID);
                BTBW.WriteIntTupleProperty(13, (int)node.ScriptFunc);
            }
        }

        private static void WriteRegionObjects(Battle btl, BTBWriter BTBW)
        {
            foreach (Region region in btl.Regions)
            {
                BTBW.WriteObjectHeader(4, 68 + region.Lines.Count * 24);
                BTBW.WriteStringProperty(1006, region.Name);
                BTBW.WriteIntTupleProperty(5, (int)region.Flags);
                if (region.Lines.Count == 0)
                {
                    BTBW.WriteIntTupleProperty(0x10, 0, 0);
                    continue;
                }
                BTBW.WriteIntTupleProperty(10, region.Lines[0].StartX, region.Lines[0].StartY);
                foreach (Region.LineSegment LS in region.Lines)
                    BTBW.WriteIntTupleProperty(502, LS.StartX, LS.StartY, LS.EndX, LS.EndY);
            }
        }

        private static void WriteObstaclesObject(Battle btl, BTBWriter BTBW)
        {
            BTBW.WriteObjectHeader(3, 12 + 80 * btl.Obstacles.Count);
            BTBW.WriteIntTupleProperty(8, 100); // we don't know what this value is, but larger numbers work better!
            foreach (Obstacle obs in btl.Obstacles)
            {
                BTBW.WritePropertyHeader(501, 80);
                BTBW.WriteIntTupleProperty(5, (int)obs.Properties);
                BTBW.WriteIntTupleProperty(1, obs.X);
                BTBW.WriteIntTupleProperty(2, obs.Y);
                BTBW.WriteIntTupleProperty(4, obs.Z);
                BTBW.WriteIntTupleProperty(6, (int)obs.Radius);
                BTBW.WriteIntTupleProperty(7, obs.Dir);
            }
        }

        private static void WriteObjectivesObject(Battle btl, BTBWriter BTBW)
        {
            BTBW.WriteObjectHeader(2, btl.Objectives.Count * 20);
            foreach (Objective obj in btl.Objectives)
                BTBW.WriteIntTupleProperty(3, obj.TypeCode, obj.Val1, obj.Val2);
        }

        private static void WriteMapHeaderObject(Battle btl, BTBWriter BTBW)
        {
            BTBW.WriteObjectHeader(1, 240);
            BTBW.WriteIntTupleProperty(1, btl.Width);
            BTBW.WriteIntTupleProperty(2, btl.Height);
            BTBW.WriteStringProperty(1001, btl.PlayerArmy);
            BTBW.WriteStringProperty(1002, btl.EnemyArmy);
            BTBW.WriteStringProperty(1003, btl.CTL);
            BTBW.WriteStringProperty(1004, "/0");
            BTBW.WriteStringProperty(1005, "/0");
            int SegmentCount = 0;
            foreach (var region in btl.Regions)
                SegmentCount += region.Lines.Count;
            BTBW.WriteIntTupleProperty(9, btl.Regions.Count, SegmentCount);
        }
    }
}
