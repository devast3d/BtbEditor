using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace BTBLib
{
    public class UnexpectedObjectFound : Exception { }
    public class UnexpectedPropertyFound : Exception { }
    public class UnexpectedPropertyLength : Exception { }

    internal class BTBReader
    {
        private BinaryReader reader;

        public BTBReader(FileStream stream)
        {
            this.reader = new BinaryReader(stream);
        }

        public int[] ReadIntTupleProperty(uint expectedTypeCode,
                                          uint arity)
        {
            ReadPropertyHeader(expectedTypeCode, arity * sizeof(int));
            int[] tuple = new int[arity];
            for (int i = 0; i < arity; i++)
                tuple[i] = reader.ReadInt32();
            return tuple;
        }

        public string ReadStringProperty(uint expectedTypeCode)
        {
            ReadPropertyHeader(expectedTypeCode, 32);
            byte[] buffer = reader.ReadBytes(32);
            string text = ASCIIEncoding.Default.GetString(buffer);
            text = text.Remove(text.IndexOf('\0'));
            return text;
        }


        public void ReadPropertyHeader(uint checkTypecode, 
                                       uint checkLength)
        {
            uint typecode = reader.ReadUInt32();
            uint length = reader.ReadUInt32();
            if (typecode != checkTypecode)
                throw new UnexpectedPropertyFound();
            if (length != (checkLength+8))
                throw new UnexpectedPropertyLength();
        }

        public uint ReadObjectHeader(uint checkTypecode)
        {
            uint typecode = reader.ReadUInt32();
            uint length = reader.ReadUInt32();
            
            if (typecode != checkTypecode)
                throw new UnexpectedObjectFound();

            return length;
        }

        public uint PeekNextTypecode()
        {
            uint typecode = reader.ReadUInt32();
            reader.BaseStream.Position -= 4;
            return typecode;
        }

    }
}
