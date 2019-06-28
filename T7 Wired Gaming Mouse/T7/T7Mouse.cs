using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;
using System.Threading;
using System.IO;

namespace T7
{
    [Serializable]
    public class T7MouseException : Exception
    {
        public T7MouseException() { }
        public T7MouseException(string message) : base(message) { }
        public T7MouseException(string message, Exception inner) : base(message, inner) { }
        protected T7MouseException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public class T7Mouse
    {
        private T7Device mDevice;
        private T7Device mGeneral;

        public MouseData Data { get; set; }

        public T7Mouse()
        {
            mDevice = new T7Device(0x480);
            mGeneral = new T7Device(0x9A);

            RefreshMouseData();
        }

        public void RefreshMouseData()
        {
            Data = new MouseData(mGeneral.GetCommand());
        }
        public void Apply()
        {
            mGeneral.SendCommand(Data.GetBuffer());
        }
    }
}
