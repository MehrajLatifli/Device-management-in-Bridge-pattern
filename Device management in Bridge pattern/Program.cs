using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_management_in_Bridge_pattern
{
    interface IDevice
    {
        void IsEnabled(bool isenable);
        void Enable();
        void Disable();
        void GetVolume();
        void SetVolume(double percent);
        void GetChannel();
        void SetChannel(double channel);

    }

    class Radio : IDevice
    {


        public void IsEnabled(bool IsEnable)
        {
            if (IsEnable == true)
            {
                Enable();
            }

            else
            {
                Disable();
            }


        }
        public void Disable()
        {
            Console.WriteLine($"\n The radio is Disabled");
        }

        public void Enable()
        {
            Console.WriteLine($"\n The radio is Enabled");
        }

        public void GetChannel()
        {
            double channel = 10;

            Console.WriteLine($"\n The Channel of radio is {channel}");
        }

        public void SetChannel(double channel)
        {
            Console.WriteLine($"\n The Channel of radio is {channel}");
        }

        public void GetVolume()
        {
            double percent = 10;

            Console.WriteLine($"\n The Volume of radio is {percent}");
        }


        public void SetVolume(double percent)
        {
            Console.WriteLine($"\n The Volume of radio is {percent}");
        }
    }

    class TV : IDevice
    {

        public void IsEnabled(bool IsEnable)
        {
            if (IsEnable == true)
            {
                Enable();
            }

            else
            {
                Disable();
            }

        }
        public void Disable()
        {
            Console.WriteLine($"\n The television is Disabled");
        }

        public void Enable()
        {
            Console.WriteLine($"\n The television is Enabled");
        }

        public void GetChannel()
        {
            double channel = 10;

            Console.WriteLine($"\n The Channel of television is {channel}");
        }

        public void SetChannel(double channel)
        {
            Console.WriteLine($"\n The Channel of television is {channel}");
        }

        public void GetVolume()
        {
            double percent = 10;

            Console.WriteLine($"\n The Volume of television is {percent}");
        }


        public void SetVolume(double percent)
        {
            Console.WriteLine($"\n The Volume of television is {percent}");
        }
    }


    interface IRemote
    {
        void TogglePower(bool IsEnable);

        void VolumeDown();

        void VolumeUP();

        void ChannelDown();

        void ChannelUp();

        void Mute(bool IsMute);
    }

    class RadioRemote : IRemote
    {
        public IDevice Device { get; set; }

        double percent = 100;
        double channel = 10;
        public RadioRemote(IDevice _device)
        {
            Device = _device;
        }

        public void TogglePower(bool IsEnable)
        {
            Device.IsEnabled(IsEnable);
        }

        public void VolumeDown()
        {
            percent--;
            Device.SetVolume(percent);
        }

        public void VolumeUP()
        {
            percent++;
            Device.SetVolume(percent);
        }

        public void ChannelDown()
        {
            channel--;
            Device.SetVolume(channel);
        }

        public void ChannelUp()
        {
            channel++;
            Device.SetVolume(channel);
        }

        public void Mute(bool IsMute)
        {

            Console.WriteLine($"\n The  Mute of Radio is {IsMute}");

        }
    }

    class TVRemote : IRemote
    {
        public IDevice Device { get; set; }

        double percent = 100;
        double channel = 10;
        public TVRemote(IDevice _device)
        {
            Device = _device;
        }

        public void TogglePower(bool IsEnable)
        {

            Device.IsEnabled(IsEnable);
        }

        public void VolumeDown()
        {
            percent--;
            Device.SetVolume(percent);
        }

        public void VolumeUP()
        {
            percent++;
            Device.SetVolume(percent);
        }

        public void ChannelDown()
        {
            channel--;
            Device.SetVolume(channel);
        }

        public void ChannelUp()
        {
            channel++;
            Device.SetVolume(channel);
        }

        public void Mute(bool IsMute)
        {
            Console.WriteLine($"\n The Mute of television is {IsMute}");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IRemote remote = new RadioRemote(new Radio());

            bool isEnabled = true;

            bool isMute = false;

            remote.TogglePower(isEnabled);
            remote.Mute(isMute);
            remote.VolumeDown();
            remote.VolumeUP();
            remote.ChannelDown();
            remote.ChannelUp();

            Console.WriteLine("\n");

            IRemote remote2 = new TVRemote(new TV());

            bool isEnabled2 = true;
            bool isMute2 = false;

            remote2.TogglePower(isEnabled2);
            remote2.Mute(isMute2);
            remote2.VolumeDown();
            remote2.VolumeUP();
            remote2.ChannelDown();
            remote2.ChannelUp();


            Console.ReadKey();
        }
    }
}
