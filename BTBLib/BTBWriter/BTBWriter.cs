using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BTBLib
{
    internal class BTBWriter
    {
        private BinaryWriter writer;
        public class StringTooLongException : Exception { }

        public BTBWriter(FileStream FS)
        {
            this.writer = new BinaryWriter(FS);
        }

        public void WriteObjectHeader(uint typecode, int length)
        {
            this.writer.Write(typecode);
            this.writer.Write(length);
        }

        public void WriteIntTupleProperty(uint typecode, params int[] values)
        {
            this.writer.Write(typecode);
            this.writer.Write(8 + values.Length * 4);
            foreach (int i in values)
                this.writer.Write(i);
        }

        public void WritePropertyHeader(uint typecode, uint size)
        {
            this.writer.Write(typecode);
            this.writer.Write(size);
        }

        public void WriteStringProperty(uint typecode, string str)
        {
            WritePropertyHeader(typecode, 32 + 8);
            byte[] buffer = new byte[32];
            byte[] strbytes = ASCIIEncoding.Default.GetBytes(str);
            if (strbytes.Length > 31) throw new StringTooLongException();
            Buffer.BlockCopy(strbytes, 0, buffer, 0, strbytes.Length);
            this.writer.Write(buffer);
        }
    }
}
