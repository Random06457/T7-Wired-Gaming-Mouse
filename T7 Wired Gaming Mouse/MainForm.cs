using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T7;

namespace T7_Wired_Gaming_Mouse
{
    public partial class MainForm : Form
    {
        T7Mouse mMouse;
        public MainForm()
        {
            InitializeComponent();

            mMouse = new T7Mouse();
            UpdateControl();
        }

        private void UpdateControl()
        {
            value_effect.SelectedIndex = (int)mMouse.Data.LED.Effect;
            value_transition.SelectedIndex = (int)mMouse.Data.LED.Transition;

            switch (mMouse.Data.LED.Effect)
            {
                case LedEffect.Breath:
                    value_breathSpeed.Value = mMouse.Data.LED.BreathSpeed;
                    break;
                case LedEffect.Neon:
                    value_neonSpeed.Value = (decimal)mMouse.Data.LED.NeonSpeed;
                    break;
                case LedEffect.Steady:
                    value_steadyBrightness.Value = mMouse.Data.LED.SteadyBrightness;
                    break;
            }
            switch (mMouse.Data.LED.Transition)
            {
                case LedTransition.Blink:
                    value_blinkFrequency.Value = mMouse.Data.LED.BlinkFrequency;
                    value_blinkTimes.Value = mMouse.Data.LED.BlinkTimes;
                    break;
                case LedTransition.Steady:
                    value_steadyTime.Value = (decimal)mMouse.Data.LED.SteadyTime;
                    break;
            }

            for (int i = 1; i < 6; i++)
            {
                ((TrackBar)groupBox_dpi.Controls[$"value_dpi{i}"]).Value = mMouse.Data.DPI.Entries[i-1].DpiIndex;
                ((PictureBox)groupBox_dpi.Controls[$"value_dpiColor{i}"]).BackColor = mMouse.Data.DPI.Entries[i-1].EntryColor;
                ((CheckBox)groupBox_dpi.Controls[$"check_dpiEnable{i}"]).Checked = mMouse.Data.DPI.Entries[i-1].Enabled;
            }
            Value_dpi_Scroll(null, null);
        }
        private void ApplyValues()
        {
            mMouse.Data.LED.Effect = (LedEffect)value_effect.SelectedIndex;
            mMouse.Data.LED.Transition = (LedTransition)value_transition.SelectedIndex;

            switch (mMouse.Data.LED.Effect)
            {
                case LedEffect.Breath:
                    mMouse.Data.LED.BreathSpeed = (byte)value_breathSpeed.Value;
                    break;
                case LedEffect.Neon:
                    mMouse.Data.LED.NeonSpeed = (float)value_neonSpeed.Value;
                    break;
                case LedEffect.Steady:
                    mMouse.Data.LED.SteadyBrightness = (byte)value_steadyBrightness.Value;
                    break;
            }
            switch (mMouse.Data.LED.Transition)
            {
                case LedTransition.Blink:
                    mMouse.Data.LED.BlinkFrequency = (byte)value_blinkFrequency.Value;
                    mMouse.Data.LED.BlinkTimes = (byte)value_blinkTimes.Value;
                    break;
                case LedTransition.Steady:
                    mMouse.Data.LED.SteadyTime = (float)value_steadyTime.Value;
                    break;
            }

            for (int i = 1; i < 6; i++)
            {
                mMouse.Data.DPI.Entries[i - 1].DpiIndex = ((TrackBar)groupBox_dpi.Controls[$"value_dpi{i}"]).Value;
                mMouse.Data.DPI.Entries[i - 1].EntryColor = ((PictureBox)groupBox_dpi.Controls[$"value_dpiColor{i}"]).BackColor;
                mMouse.Data.DPI.Entries[i - 1].Enabled = ((CheckBox)groupBox_dpi.Controls[$"check_dpiEnable{i}"]).Checked;
            }
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            ApplyValues();
            mMouse.Apply();
        }

        private void Value_effect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = value_effect.SelectedIndex;
            if (index != -1)
                tab_effect.SelectedIndex = index;
        }

        private void Value_transition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = value_transition.SelectedIndex;
            if (index != -1)
                tab_transition.SelectedIndex = index;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //hackjob
            tab_effect.Location = new Point(tab_effect.Location.X, tab_effect.Location.Y + tab_effect.ItemSize.Height);
            tab_effect.Size = new Size(tab_effect.Size.Width, tab_effect.Size.Height - tab_effect.ItemSize.Height);
            tab_effect.ItemSize = new Size(0, 1);
            tab_effect.SizeMode = TabSizeMode.Fixed;
            tab_effect.Appearance = TabAppearance.FlatButtons;
            tab_transition.Location = new Point(tab_transition.Location.X, tab_transition.Location.Y + tab_transition.ItemSize.Height);
            tab_transition.Size = new Size(tab_transition.Size.Width, tab_transition.Size.Height - tab_transition.ItemSize.Height);
            tab_transition.ItemSize = new Size(0, 1);
            tab_transition.SizeMode = TabSizeMode.Fixed;
            tab_transition.Appearance = TabAppearance.FlatButtons;
        }

        private void Value_dpi_Scroll(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
                groupBox_dpi.Controls[$"label_dpi{i}"].Text = $"{DpiEntry.GetDpiFromIndex(((TrackBar)groupBox_dpi.Controls[$"value_dpi{i}"]).Value)} DPI";
        }

        private void Value_dpiColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = ((PictureBox)sender).BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((PictureBox)sender).BackColor = colorDialog1.Color;
            }
        }
    }
}
