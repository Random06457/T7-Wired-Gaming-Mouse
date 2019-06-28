using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace T7
{
    public abstract class DataContainer
    {
        public DataContainer(byte[] data)
        {
            if (data.Length != BufferSize)
                throw new Exception("Invalid Data Size");

            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryReader br = new BinaryReader(ms);
                Parse(br);
            }
        }
        public byte[] GetBuffer()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryWriter bw = new BinaryWriter(ms);
                Write(bw);
                return ms.ToArray().Take((int)ms.Length).ToArray();
            }
        }

        protected abstract void Parse(BinaryReader br);
        protected abstract void Write(BinaryWriter bw);

        public abstract int BufferSize { get; }
    }

    public class LedData
    {
        private LedTransition mTransition;
        private LedEffect mEffect;
        private byte mSteadyBrightness;
        private byte mBreathSpeed;
        private float mNeonSpeed;
        private float mSteadyTime;
        private byte mBlinkFrequency;
        private byte mBlinkTimes;

        public LedTransition Transition {
            get => mTransition;
            set => mTransition = ((int)value >=0 && (int)value < 3) ? value : LedTransition.None;
        }
        public LedEffect Effect
        {
            get => mEffect;
            set => mEffect = ((int)value >= 0 && (int)value < 3) ? value : LedEffect.Breath;
        }
        public byte SteadyBrightness
        {
            get => mSteadyBrightness;
            set => mSteadyBrightness = (value >= 0 && value <= 10) ? value : (byte)10;
        }
        public byte BreathSpeed
        {
            get => mBreathSpeed;
            set => mBreathSpeed = (value >= 4 && value <= 8) ? value : (byte)4;
        }
        public float NeonSpeed
        {
            get => mNeonSpeed;
            set => mNeonSpeed = (value >= 0.5f && value <= 7.5f) ? value : 2.0f;
        }
        public float SteadyTime
        {
            get => mSteadyTime;
            set => mSteadyTime = (value >= 0.5f && value <= 5.0f) ? value : 1.0f;
        }
        public byte BlinkFrequency
        {
            get => mBlinkFrequency;
            set => mBlinkFrequency = (value >= 1 && value <= 10) ? value : (byte)1;
        }
        public byte BlinkTimes
        {
            get => mBlinkTimes;
            set => mBlinkTimes = (value >= 1 && value <= 10) ? value : (byte)3;
        }

        public LedData(BinaryReader br)
        {
            //0x00
            byte b = br.ReadByte();
            mTransition = (LedTransition)(FirstBitSet((byte)(b >> 4)) - 1);
            mEffect = (LedEffect)(FirstBitSet((byte)(b & 0xF)) - 1);

            //0x01
            mBlinkFrequency = 1;
            mSteadyTime = 0.5f;
            b = br.ReadByte();
            switch (mTransition)
            {
                case LedTransition.Blink:
                    mBlinkFrequency = b;
                    break;
                case LedTransition.Steady:
                    mSteadyTime = (float)(b * 0.5);
                    break;
            }

            //0x02
            mBlinkTimes = br.ReadByte();

            //0x03
            mBreathSpeed = 4;
            mNeonSpeed = 2.0f;
            mSteadyBrightness = 10;

            b = br.ReadByte();
            switch (mEffect)
            {
                case LedEffect.Breath:
                    mBreathSpeed = (byte)((b >> 4) + 3);
                    break;
                case LedEffect.Neon:
                    mNeonSpeed = (float)((byte)(b >> 4) * 0.5);
                    break;
                case LedEffect.Steady:
                    mSteadyBrightness = (byte)(b >> 4); ;
                    break;
            }

            //0x04
            br.ReadBytes(3);
        }
        public void Write(BinaryWriter bw)
        {
            //0x00
            byte nibble1 = (byte)(1 << ((byte)mTransition + 1));
            byte nibble2 = (byte)((1 << ((byte)mEffect + 1)) & 0xF);
            bw.Write((byte)((nibble1 << 4) | nibble2));

            //0x01
            switch (mTransition)
            {
                case LedTransition.Blink:
                    bw.Write(mBlinkFrequency);
                    break;
                case LedTransition.Steady:
                    bw.Write((byte)(mSteadyTime / 0.5));
                    break;
                default:
                    bw.Write(new byte[1]);
                    break;
            }

            //0x02
            bw.Write(mBlinkTimes);

            //0x03
            nibble1 = 0;
            nibble2 = 2;
            switch (mEffect)
            {
                case LedEffect.Breath:
                    nibble1 = (byte)(mBreathSpeed - 3);
                    break;
                case LedEffect.Neon:
                    nibble1 = (byte)(mNeonSpeed / 0.5);
                    break;
                case LedEffect.Steady:
                    nibble1 = mSteadyBrightness;
                    break;
            }
            bw.Write((byte)((nibble1 << 4) | nibble2));

            //0x04
            bw.Write(new byte[] { 4, 0, 0}); //?
        }
        private static int FirstBitSet(byte b)
        {
            for (int i = 0; i < 8; i++)
            {
                if ((b & (1 << i)) != 0)
                    return i;
            }
            return -1;
        }
    }
    public class DpiData
    {
        private byte[] unk1;
        private byte[] unk2;
        public DpiEntry[] Entries { get; private set; }

        public DpiData(BinaryReader br)
        {
            Entries = new DpiEntry[5];
            unk1 = br.ReadBytes(3);
            for (int i = 0; i < Entries.Length; i++)
            {
                byte b = br.ReadByte();
                Entries[i] = new DpiEntry()
                {
                    Enabled = (b & 0x80) == 0,
                    DpiIndex = b & 0x7F,
                };
            }
            unk2 = br.ReadBytes(0xE);
        }
        public void Write(BinaryWriter bw)
        {
            bw.Write(unk1);
            foreach (var entry in Entries)
                bw.Write((byte)((entry.Enabled ? 0 : 1 << 7) | entry.DpiIndex));
            bw.Write(unk2);
        }
    }

    public struct DpiEntry
    {
        private static readonly int[] DPI_VALUES = {
            0,
            500,
            750,
            1000,
            1200,
            1600,
            2000,
            2400,
            3000,
            3200,
            3500,
            4000,
            4500,
            5000,
            5500,
            6000,
            7200,
        };
        private int mDpiIndex;

        public bool Enabled;
        public Color EntryColor;
        public int DpiValue { get => GetDpiFromIndex(mDpiIndex); set => mDpiIndex = GetIndexFromDpi(value); }
        public int DpiIndex { get => mDpiIndex; set => mDpiIndex = (value > 0 && value < DPI_VALUES.Length) ? value : 1; }

        public static int GetDpiFromIndex(int index)
        {
            return DPI_VALUES[index];
        }
        public static int GetIndexFromDpi(int dpi)
        {
            for (int i = 0; i < DPI_VALUES.Length; i++)
                if (dpi == DPI_VALUES[i])
                    return i;
            return 1;
        }

    }

    public class MouseData : DataContainer
    {
        public override int BufferSize => 0x99;

        private byte[] Unk1;
        public int PollingRate;
        public string Brand;
        public string Product;
        public DpiData DPI;
        public LedData LED;
        private byte[] Unk2;

        public MouseData(byte[] data) : base(data)
        {
        }

        private string ReadString(BinaryReader br)
        {
            byte[] buff = br.ReadBytes(0x1F);
            return Encoding.ASCII.GetString(buff.Skip(1).Take(buff[0]).ToArray());
        }
        private void WriteString(BinaryWriter bw, string s)
        {
            byte[] buff = new byte[0x1F];
            byte[] data = Encoding.ASCII.GetBytes(s);
            buff[0] = (byte)data.Length;
            Buffer.BlockCopy(data, 0, buff, 1, data.Length);

            bw.Write(buff);
        }

        protected override void Parse(BinaryReader br)
        {
            Unk1 = br.ReadBytes(7);

            byte b = br.ReadByte();
            PollingRate = (int)(125 * Math.Pow(2, b >> 4));
            Brand = ReadString(br);
            Product = ReadString(br);

            DPI = new DpiData(br);
            LED = new LedData(br);
            for (int i = 0; i < DPI.Entries.Length; i++)
                DPI.Entries[i].EntryColor = Color.FromArgb(br.ReadByte(), br.ReadByte(), br.ReadByte());

            Unk2 = br.ReadBytes(0x27);
        }

        protected override void Write(BinaryWriter bw)
        {
            bw.Write(Unk1);
            byte nibble = (byte)(Math.Log(PollingRate / 125, 2));
            bw.Write((byte)((nibble << 4) | 0xC));
            WriteString(bw, Brand);
            WriteString(bw, Product);
            DPI.Write(bw);
            LED.Write(bw);
            foreach (var entry in DPI.Entries)
            {
                bw.Write(entry.EntryColor.R);
                bw.Write(entry.EntryColor.G);
                bw.Write(entry.EntryColor.B);
            }
            bw.Write(Unk2);
        }
    }
    public enum LedEffect
    {
        Breath,
        Neon,
        Steady,
    }
    public enum LedTransition
    {
        None,
        Blink,
        Steady,
    }
}
