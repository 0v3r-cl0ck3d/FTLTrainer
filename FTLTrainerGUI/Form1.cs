using MemoryTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTLTrainerGUI
{
    public partial class Form1 : Form
    {
        //Global vars
        MemoryReader mreader = new MemoryReader();
        uint PointerAdress = 0x53B38C;
        uint ShipPointerAdress = 0x5428A0;
        int PointerOffset = 0x0;
        uint Offset = 0x0;
        uint ShipOffset = 0x0;


        Process process = Process.GetProcessesByName("FTLGame").ToList().FirstOrDefault();


        int bytesout = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("FTL Trainer by cl0ck.");
            Console.WriteLine("Printing info about MemoryTools.dll");
            mreader.AboutMemoryTools();
            if (process != null)
            {
                mreader.ReadProcess = process;
                mreader.Openprocess();

                Offset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(PointerAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesout), 0);
                if (PointerOffset < 0)
                {
                    Offset -= (uint)PointerOffset;
                }
                else
                {
                    Offset += (uint)PointerOffset;
                }

                ShipOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(ShipPointerAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesout), 0);
                if (ShipOffset < 0)
                {
                    Offset -= (uint)PointerOffset;
                }
                else
                {
                    Offset += (uint)PointerOffset;
                }
            }
            else
            {
                MessageBox.Show("Error. Please make sure FTL is running before starting the trainer!","Could not find FTL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            this.Text = ("FTL Trainer by cl0ck | Version " + ProductVersion + " | reading PID " + process.Id.ToString());
            string ttt = (int.Parse(process.Modules[0].BaseAddress.ToString(), System.Globalization.NumberStyles.Integer)).ToString("X");
            Console.WriteLine("Trainner attached to FTL @ PID " + process.Id.ToString() + " using the base memory adress 0x" + (int.Parse(process.Modules[0].BaseAddress.ToString(), System.Globalization.NumberStyles.Integer)).ToString("X") + " ( " + process.Modules[0].BaseAddress.ToString() + " in deciaml)");
            Console.WriteLine("Printing game details to console...");
            Console.WriteLine(process.Modules[0].FileVersionInfo);
            Console.WriteLine("Updating values in trainer to match game...");
            UpdatePosTimer.Enabled = true;
            Console.Title = this.Text;
            this.Text = "FTL Trainer by cl0ck";

            //Code to set values

            ReloadOnError:
            bool ErrorReadingValues = false;
            if (ErrorReadingValues = true)
            {
                Console.WriteLine("Attempting to recalculate memory pointers and offsets!");
                Offset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(PointerAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesout), 0);
                if (PointerOffset < 0)
                {
                    Offset -= (uint)PointerOffset;
                }
                else
                {
                    Offset += (uint)PointerOffset;
                }

                ShipOffset = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(ShipPointerAdress + (uint)process.Modules[0].BaseAddress), 4, out bytesout), 0);
                if (ShipOffset < 0)
                {
                    Offset -= (uint)PointerOffset;
                }
                else
                {
                    Offset += (uint)PointerOffset;
                }
            }

            try
            {
                //Sets scrap value
                ScrapValueNumericUpDown.Value = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)Offset + 0x4D4, 4, out bytesout), 0);
                Console.WriteLine("Set trainer scrap value to " + ScrapValueNumericUpDown.Value);
            }
            catch (Exception)
            {
                //Sets scrap value
                ScrapValueNumericUpDown.Value = 999999999;
                Console.WriteLine("Set trainer scrap value to " + ScrapValueNumericUpDown.Value);
            }

            try
            {
                //Sets Reactor value
                ReactorLevelUpDown.Value = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)ShipOffset + 0x04, 4, out bytesout), 0);
                Console.WriteLine("Set trainer reactor level value to " + ReactorLevelUpDown.Value);
            }
            catch (Exception)
            {
                //Sets Reactor value
                ReactorLevelUpDown.Value = 60;
                Console.WriteLine("Set trainer reactor level value to " + ReactorLevelUpDown.Value);
            }


            try
            {
                //Sets fuel value
                NumericFuel.Value = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)Offset + 0x494, 4, out bytesout), 0);
                Console.WriteLine("Set trainer fuel value to " + NumericFuel.Value);
            }
            catch (Exception)
            {
                //Sets fuel value
                NumericFuel.Value = 999999999;
                Console.WriteLine("Set trainer fuel value to " + NumericFuel.Value);
            }

            try
            {
                //Sets drone parts value
                NumericDroneParts.Value = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)Offset + 0x800, 4, out bytesout), 0);
                Console.WriteLine("Set trainer drone parts value to " + NumericDroneParts.Value);
            }
            catch (Exception)
            {
                //Sets drone parts value
                NumericDroneParts.Value = 999999999;
                Console.WriteLine("Set trainer drone parts value to " + NumericDroneParts.Value);
            }

            try
            {
                //Sets hull hp value
                NumeriHullHP.Value = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)Offset + 0xcc, 4, out bytesout), 0);
                Console.WriteLine("Set hull HP value to " + NumeriHullHP.Value);
            }
            catch (Exception)
            {
                //Sets hull hp value
                NumeriHullHP.Value = 999999999;
                Console.WriteLine("Set hull HP value to " + NumeriHullHP.Value);
            }

            try
            {
                //Sets Max HUll HP
                NumericMaxHull.Value = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)Offset + 0xd0, 4, out bytesout), 0);
                Console.WriteLine("Set trainer max hull HP value to " + NumericMaxHull.Value);
            }
            catch (Exception)
            {
                //Sets Max HUll HP
                NumericMaxHull.Value = 999999999;
                Console.WriteLine("Set trainer max hull HP value to " + NumericMaxHull.Value);
            }


            Console.WriteLine("Done!");
            if (NumeriHullHP.Value == 0)
            {
                MessageBox.Show("Due to how FTL handles it's memory pointers the trainer cannot calculate the offsets until you have started the main game. Please select a ship and start before you continue", "PLEASE READ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //goto ReloadOnError;
            }
        }

        //Set Scrap Button
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + ScrapValueNumericUpDown.Value + " scrap to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 1236).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x4D4, BitConverter.GetBytes(Convert.ToInt32(ScrapValueNumericUpDown.Value)), out bytesout);
        }

        //Set Reactor Button
        private void SetReactorButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + ReactorLevelUpDown.Value + " as reactor level to ram @ hex adress 0x" + (int.Parse(ShipOffset.ToString(), System.Globalization.NumberStyles.Integer) + 4 ).ToString("X"));
            mreader.WriteMemory((IntPtr)ShipOffset + 0x04, BitConverter.GetBytes(Convert.ToInt32(ReactorLevelUpDown.Value)), out bytesout);
        }

        //Set Fuel Button
        private void SetFuelButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + NumericFuel.Value + " as fuel level to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 1172).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x494, BitConverter.GetBytes(Convert.ToInt32(NumericFuel.Value)), out bytesout);
        }

        //Sets Drone Parts Button
        private void SetDronePartsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + NumericDroneParts.Value + " as drone parts to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 2048).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x800, BitConverter.GetBytes(Convert.ToInt32(NumericDroneParts.Value)), out bytesout);
        }

        //Set Hull HP button
        private void SetHpButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + NumeriHullHP.Value + " as hull HP to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 204).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0xcc, BitConverter.GetBytes(Convert.ToInt32(NumeriHullHP.Value)), out bytesout);
        }

        //Set Hull Max HP Button
        private void SetMaxHullButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing " + NumericMaxHull.Value + " as max hull HP to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 208).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0xd0, BitConverter.GetBytes(Convert.ToInt32(NumericMaxHull.Value)), out bytesout);
        }

        //Insta charge FTL Button
        private void InstaChargeFTLButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing 1118437376 as FTL stage to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 1164).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x48c, BitConverter.GetBytes(1118437376), out bytesout);
        }

        //Max everything button
        private void MaxEverythingButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Writing 999999999 scrap to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 1236).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x4D4, BitConverter.GetBytes(999999999), out bytesout);
            Console.WriteLine("Writing 60 as reactor level to ram @ hex adress 0x" + (int.Parse(ShipOffset.ToString(), System.Globalization.NumberStyles.Integer) + 4).ToString("X"));
            mreader.WriteMemory((IntPtr)ShipOffset + 0x04, BitConverter.GetBytes(60), out bytesout);
            Console.WriteLine("Writing 999999999 as fuel to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 1172).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x494, BitConverter.GetBytes(999999999), out bytesout);
            Console.WriteLine("Writing 999999999 drone parts to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 2048).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0x800, BitConverter.GetBytes(999999999), out bytesout);
            Console.WriteLine("Writing 999999999 Missiles to ram @ hex adress 0x" );
            mreader.WriteMemory((IntPtr)ShipOffset + 0x1c0, BitConverter.GetBytes(999999999), out bytesout);

            //Ship hp
            int MaxHullHPValueWhenMaxing = BitConverter.ToInt32(mreader.ReadMemory((IntPtr)Offset + 0xd0, 4, out bytesout), 0);
            Console.WriteLine("Writing " + MaxHullHPValueWhenMaxing + " as hull HP to ram @ hex adress 0x" + (int.Parse(Offset.ToString(), System.Globalization.NumberStyles.Integer) + 0xcc).ToString("X"));
            mreader.WriteMemory((IntPtr)Offset + 0xcc, BitConverter.GetBytes(MaxHullHPValueWhenMaxing), out bytesout);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.Show();
        }



        //Dock code
        bool DockedToGame = false;
        private void DockPannel_DoubleClick(object sender, EventArgs e)
        {
            if (DockedToGame.Equals(true))
            {
                DockedToGame = false;
            }
            else
            {
                DockedToGame = true;
            }
            Console.WriteLine("The game docking feature is not yet implemented!");
        }

        private void DockPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatePosTimer_Tick(object sender, EventArgs e)
        {
            mreader.RenameWindow(process, "FTL | Cl0ck's trainer attached | PID " + process.Id.ToString() + " | Using " + process.Modules.Count + " modules in " + process.PagedMemorySize + " bytes of paged ram");
            if (DockedToGame.Equals(true))
            {
                this.Location.X.Equals(0);
                Console.WriteLine();

            }
        }
    }
}
