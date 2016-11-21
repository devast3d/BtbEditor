using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace BTBLib
{
    public class NotABTBFileException : Exception { }
    public class UnknownNodeTypeException : Exception { }

    public class BTBLoader
    {
     
        static public Battle Load(string path)
        {
            Battle newBattle;
            using (FileStream file = File.OpenRead(path))
            {
                BTBReader reader = new BTBReader(file);

                CheckBTBFileType(reader);
                ReadMapHeaderObject(reader, out newBattle);
                ReadObjectivesObject(reader, newBattle);
                ReadObstaclesObject(reader, newBattle);
                ReadRegions(reader, newBattle);
                ReadNodes(reader, newBattle);
                CheckBTBFileType(reader);
            }
            return newBattle;
        }

        static private void CheckBTBFileType(BTBReader reader)
        {
            try
                { reader.ReadObjectHeader(0xbeafeed0); }
            catch (UnexpectedObjectFound)
                { throw new NotABTBFileException(); }
        }

        static private void ReadMapHeaderObject(BTBReader reader, out Battle battle)
        {
            reader.ReadObjectHeader(0x1);
            int width = reader.ReadIntTupleProperty(1, 1)[0];
            int height = reader.ReadIntTupleProperty(2, 1)[0];
            string player = reader.ReadStringProperty(1001);
            string enemy = reader.ReadStringProperty(1002);
            string ctl = reader.ReadStringProperty(1003);
            reader.ReadStringProperty(1004);
            reader.ReadStringProperty(1005);
            reader.ReadIntTupleProperty(9, 2);
            battle = new Battle(width, height, player, enemy, ctl);
        }

        static private void ReadObjectivesObject(BTBReader reader, Battle battle)
        {
            uint length = reader.ReadObjectHeader(0x2);
            for (int i = 0; i < length; i += 20)
            {
                int[] tuple = reader.ReadIntTupleProperty(3, 3);
                Objective newObjective = new Objective(tuple[0], tuple[1], tuple[2]);
                battle.Objectives.Add(newObjective);
            }
        }

        static private void ReadObstaclesObject(BTBReader reader, Battle battle)
        {
            uint length = reader.ReadObjectHeader(0x3);

            int unknownCount = reader.ReadIntTupleProperty(8, 1)[0];
            uint obstacleCount = (length - 12u) / 80u;
            for (int obstacleNum = 0; obstacleNum < obstacleCount; obstacleNum++)
            {
                reader.ReadPropertyHeader(501, 72);
                int flags = reader.ReadIntTupleProperty(5, 1)[0];
                int x = reader.ReadIntTupleProperty(1, 1)[0];
                int y = reader.ReadIntTupleProperty(2, 1)[0];
                int z = reader.ReadIntTupleProperty(4, 1)[0];
                int rad = reader.ReadIntTupleProperty(6, 1)[0];
                int dir = reader.ReadIntTupleProperty(7, 1)[0];
                Obstacle.PROP P = (Obstacle.PROP)flags;
                battle.Obstacles.Add(new Obstacle(P, x, y, z, (uint)rad));
            }
        }

        static private void ReadRegions(BTBReader reader, Battle battle)
        {
            while (reader.PeekNextTypecode() == 0x4)
            {
                reader.ReadObjectHeader(0x4);
                string regionName = reader.ReadStringProperty(1006);
                uint flags = (uint)reader.ReadIntTupleProperty(5, 1)[0];
                Region newRegion = new Region(regionName, flags);
                int[] pos = reader.ReadIntTupleProperty(10, 2);
                while (reader.PeekNextTypecode() == 502)
                {
                    int[] line = reader.ReadIntTupleProperty(502, 4);
                    newRegion.Lines.Add(
                            new Region.LineSegment(line[0], line[1], line[2], line[3])
                        );
                }
                battle.Regions.Add(newRegion);
            }
        }

        static private void ReadNodes(BTBReader reader, Battle battle)
        {
            reader.ReadObjectHeader(0x5);
            uint nodeCount = (uint)reader.ReadIntTupleProperty(8, 1)[0];
            for (int nodeNum = 0; nodeNum < nodeCount; nodeNum++)
            {
                reader.ReadPropertyHeader(503, 96);
                int flags = reader.ReadIntTupleProperty(5, 1)[0];
                int x = reader.ReadIntTupleProperty(1, 1)[0];
                int y = reader.ReadIntTupleProperty(2, 1)[0];
                uint rad = (uint)reader.ReadIntTupleProperty(6, 1)[0];
                uint dir = (uint)reader.ReadIntTupleProperty(7, 1)[0];
                uint nodeid = (uint)reader.ReadIntTupleProperty(11, 1)[0];
                uint uuid = (uint)reader.ReadIntTupleProperty(12, 1)[0];
                uint scriptid = (uint)reader.ReadIntTupleProperty(13, 1)[0];

                Node N;
                switch (flags)
                {
                    case 3: 
                        N = new Node(x, y, rad, dir, nodeid, uuid, scriptid, Node.USAGE.UNKNOWN2);
                        break;

                    case 5:
                        N = new Node(x, y, rad, dir, nodeid, uuid, scriptid, Node.USAGE.UNKNOWN4);
                        break;

                    case 16387:
                        N = new Node(x, y, rad, dir, nodeid, uuid, scriptid, Node.USAGE.DEPLOYMENT);
                        break;

                    case 1:
                        N = new Node(x, y, rad, dir, nodeid, uuid, scriptid, Node.USAGE.NONE);
                        break;

                    default:
                        throw new UnknownNodeTypeException();
                }
                battle.Nodes.Add(N);
            }
        }

    }
}
