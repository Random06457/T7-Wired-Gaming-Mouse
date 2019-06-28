using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;
using System.Threading;

namespace T7
{
    public class T7Device
    {
        private short mFeatureLen;
        private HidDevice mDevice;

        public T7Device(short featureLen)
        {
            mFeatureLen = featureLen;
            mDevice = HidDevices.Enumerate(0x258A, 0x1007).ToList().Find((f) =>
            {
                return (ushort)f.Capabilities.UsagePage == 0xff00 && f.Capabilities.Usage == 1 && f.Capabilities.FeatureReportByteLength == featureLen;
            });
        }
        public byte[] GetCommand()
        {
            byte[] data = new byte[mFeatureLen];
            bool success = false;
            for (int i = 0; i < 3 && !success; i++)
            {
                success = mDevice.ReadFeatureData(out data, 4);
                Thread.Sleep(200);
            }

            if (!success)
                throw new T7MouseException($"{nameof(GetCommand)} Failed");

            return data.Skip(1).Take(mFeatureLen-1).ToArray();
        }

        public void SendCommand(byte[] data)
        {
            if (data.Length != mFeatureLen - 1)
                throw new T7MouseException("Invalid Buffer Size");

            byte[] buff = new byte[mFeatureLen];
            Buffer.BlockCopy(data, 0, buff, 1, data.Length);
            buff[0] = 4;

            bool success = false;
            for (int i = 0; i < 3 && !success; i++)
            {
                success = mDevice.WriteFeatureData(buff);
                Thread.Sleep(200);
            }

            if (!success)
                throw new T7MouseException($"{nameof(SendCommand)} Failed");
        }

        public short GetFeatureSize() => mFeatureLen;
    }
}
