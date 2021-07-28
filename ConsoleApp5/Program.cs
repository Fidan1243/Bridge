using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface Device
    {
        int Channel { get; set; }
        int Percent { get; set; }
        bool EnDisable { get; set; }
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int Channel);
    }
    class Radio : Device
    {
        public bool EnDisable { get; set; } = true;
        public int Channel { get; set; } = 1;
        public int Percent { get; set; } = 0;

        public void Disable()
        {
            EnDisable = false;
        }

        public void Enable()
        {
            EnDisable = true;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public int GetVolume()
        {
            return Percent;
        }

        public bool IsEnabled()
        {
            return EnDisable;
        }

        public void SetChannel(int channel)
        {
            if (channel >= 1 && channel <= 10)
            {
                Channel = channel;

            }
        }

        public void SetVolume(int volume)
        {
            if (Percent >= 0 && Percent <= 100)
            {
                Percent = volume;

            }
        }
    }
    class TV : Device
    {
        public bool EnDisable { get; set; } = true;
        public int Channel { get; set; } = 1;
        public int Percent { get; set; } = 0;

        public void Disable()
        {
            EnDisable = false;
        }

        public void Enable()
        {
            EnDisable = true;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public int GetVolume()
        {
            return Percent;
        }

        public bool IsEnabled()
        {
            return EnDisable;
        }

        public void SetChannel(int channel)
        {
            if (channel >= 1 && channel <= 500)
            {
                Channel = channel;

            }
        }

        public void SetVolume(int volume)
        {
            if (Percent >= 0 && Percent <= 100)
            {
                Percent = volume;

            }
        }
    }
    class Remote
    {
        public Device Device { get; set; }
        public void TogglePower()
        {
            if (Device.IsEnabled())
            {
                Device.Disable();
            }
            else
            {
                Device.Enable();
            }
        }
        public void VolumeUp()
        {
            Device.SetVolume(Device.GetVolume() + 1);
        }
        public void VolumeDown()
        {
            Device.SetVolume(Device.GetVolume() - 1);
        }
        public void ChannelUp()
        {
            Device.SetChannel(Device.GetChannel() + 1);
        }
        public void ChannelDown()
        {
            Device.SetChannel(Device.GetChannel() - 1);
        }
    }
    class AdvancedRemote:Remote
    {
        public void Mute()
        {
            Device.SetVolume(0);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}