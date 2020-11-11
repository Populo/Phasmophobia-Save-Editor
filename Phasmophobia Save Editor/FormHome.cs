using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phasmophobia_Save_Editor
{
    public partial class Form1 : Form
    {
        private readonly string ENC_KEY = "CHANGE ME TO YOUR OWN RANDOM STRING";

        private string SaveFileLocation { get; set; }
        private List<SaveValue> DataMap { get; set; }
        private JObject SaveData { get; set; }

        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;

            SaveFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Low\Kinetic Games\Phasmophobia\saveData.txt";
        }

        private void LoadFile()
        {
            string save_enc;
            try
            {
                save_enc = File.ReadAllText(SaveFileLocation);
            } 
            catch
            {
                save_enc = "";
            }
            
            if (string.IsNullOrEmpty(save_enc) || !SaveFileLocation.EndsWith("saveData.txt"))
            {
                MessageBox.Show(@"Could not load save file. Please select the save file and click load again. Default location is 'AppData\LocalLow\Kinetic Games\Phasmophobia'");
                SelectSaveFile();
            }

            if (!string.IsNullOrEmpty(save_enc) && SaveFileLocation.EndsWith("saveData.txt"))
            {
                string save_dec = Crypt(save_enc, ENC_KEY);

                DataMap = new List<SaveValue>();
                BuildDataMap(save_dec);

                PopulateForm();

                buttonSave.Enabled = true;
                buttonGhost.Enabled = true;
            }
        }

        private void PopulateForm()
        {
            numericUpDownXP.Value = int.Parse(DataMap.Where(x => x.Key == "myTotalExp").First().Value) / 100;
            numericUpDownMoney.Value = int.Parse(DataMap.Where(x => x.Key == "PlayersMoney").First().Value);

            numericUpDownEMF.Value = int.Parse(DataMap.Where(x => x.Key == "EMFReaderInventory").First().Value);
            numericUpDownFlashlight.Value = int.Parse(DataMap.Where(x => x.Key == "FlashlightInventory").First().Value);
            numericUpDownCamera.Value = int.Parse(DataMap.Where(x => x.Key == "CameraInventory").First().Value);
            numericUpDownLighter.Value = int.Parse(DataMap.Where(x => x.Key == "LighterInventory").First().Value);
            numericUpDownCandle.Value = int.Parse(DataMap.Where(x => x.Key == "CandleInventory").First().Value);
            numericUpDownUV.Value = int.Parse(DataMap.Where(x => x.Key == "UVFlashlightInventory").First().Value);
            numericUpDownCrucifix.Value = int.Parse(DataMap.Where(x => x.Key == "CrucifixInventory").First().Value);
            numericUpDownVideoCamera.Value = int.Parse(DataMap.Where(x => x.Key == "DSLRCameraInventory").First().Value);
            numericUpDownSpiritBox.Value = int.Parse(DataMap.Where(x => x.Key == "EVPRecorderInventory").First().Value);
            numericUpDownSalt.Value = int.Parse(DataMap.Where(x => x.Key == "SaltInventory").First().Value);
            numericUpDownSage.Value = int.Parse(DataMap.Where(x => x.Key == "SageInventory").First().Value);
            numericUpDownTripod.Value = int.Parse(DataMap.Where(x => x.Key == "TripodInventory").First().Value);
            numericUpDownStrongFlashlight.Value = int.Parse(DataMap.Where(x => x.Key == "StrongFlashlightInventory").First().Value);
            numericUpDownMotionSensor.Value = int.Parse(DataMap.Where(x => x.Key == "MotionSensorInventory").First().Value);
            numericUpDownSoundSensor.Value = int.Parse(DataMap.Where(x => x.Key == "SoundSensorInventory").First().Value);
            numericUpDownSanity.Value = int.Parse(DataMap.Where(x => x.Key == "SanityPillsInventory").First().Value);
            numericUpDownThermometer.Value = int.Parse(DataMap.Where(x => x.Key == "ThermometerInventory").First().Value);
            numericUpDownBook.Value = int.Parse(DataMap.Where(x => x.Key == "GhostWritingBookInventory").First().Value);
            numericUpDownIR.Value = int.Parse(DataMap.Where(x => x.Key == "IRLightSensorInventory").First().Value);
            numericUpDownParabolic.Value = int.Parse(DataMap.Where(x => x.Key == "ParabolicMicrophoneInventory").First().Value);
            numericUpDownGlowStick.Value = int.Parse(DataMap.Where(x => x.Key == "GlowstickInventory").First().Value);
            numericUpDownHeadCam.Value = int.Parse(DataMap.Where(x => x.Key == "HeadMountedCameraInventory").First().Value);
        }

        private void BuildDataMap(string save_dec)
        {
            var data = JObject.Parse(save_dec);
            SaveData = data;
            string[] categories = new[] { "IntData", "StringData", "FloatData", "BoolData" };

            foreach (var s  in categories)
            {
                PopulateMap(data[s], s);
            }
        }

        private void PopulateMap(JToken jToken, string category)
        {
            foreach (var j in jToken)
            {
                DataMap.Add(new SaveValue() {
                    Key = j["Key"].ToString(),
                    Value = j["Value"].ToString(),
                    Category = category
                });
            }
        }

        private void SelectSaveFile()
        {
            using (OpenFileDialog f = new OpenFileDialog())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    SaveFileLocation = f.FileName;
                }
            }
        }

        private string Crypt(string input, string key)
        {
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; ++i)
            {
                uint character = (uint)input[i];
                int keyPos = i % key.Length;
                uint keyChar = (uint)key[keyPos];
                char crypted = (char)(character ^ keyChar);

                result.Append(crypted);
            }

            return result.ToString();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateMap();
            UpdateJson();

            string save_dec = SaveData.ToString();
            save_dec = save_dec.Replace(" ", "").Replace("\n", "").Replace("\t", "").Replace("\r", "");

            string save_enc = Crypt(save_dec, ENC_KEY);

            File.WriteAllText(SaveFileLocation, save_enc);
        }

        private void UpdateMap()
        {
            DataMap.Where(x => x.Key == "myTotalExp").First().Value = (numericUpDownXP.Value*100).ToString();
            DataMap.Where(x => x.Key == "PlayersMoney").First().Value = numericUpDownMoney.Value.ToString();

            DataMap.Where(x => x.Key == "EMFReaderInventory").First().Value = numericUpDownEMF.Value.ToString();
            DataMap.Where(x => x.Key == "FlashlightInventory").First().Value = numericUpDownFlashlight.Value.ToString();
            DataMap.Where(x => x.Key == "CameraInventory").First().Value = numericUpDownCamera.Value.ToString();
            DataMap.Where(x => x.Key == "LighterInventory").First().Value = numericUpDownLighter.Value.ToString();
            DataMap.Where(x => x.Key == "CandleInventory").First().Value = numericUpDownCandle.Value.ToString();
            DataMap.Where(x => x.Key == "UVFlashlightInventory").First().Value = numericUpDownUV.Value.ToString();
            DataMap.Where(x => x.Key == "CrucifixInventory").First().Value = numericUpDownCrucifix.Value.ToString();
            DataMap.Where(x => x.Key == "DSLRCameraInventory").First().Value = numericUpDownVideoCamera.Value.ToString();
            DataMap.Where(x => x.Key == "EVPRecorderInventory").First().Value = numericUpDownSpiritBox.Value.ToString();
            DataMap.Where(x => x.Key == "SaltInventory").First().Value = numericUpDownSalt.Value.ToString();
            DataMap.Where(x => x.Key == "SageInventory").First().Value = numericUpDownSage.Value.ToString();
            DataMap.Where(x => x.Key == "TripodInventory").First().Value = numericUpDownTripod.Value.ToString();
            DataMap.Where(x => x.Key == "StrongFlashlightInventory").First().Value = numericUpDownStrongFlashlight.Value.ToString();
            DataMap.Where(x => x.Key == "MotionSensorInventory").First().Value = numericUpDownMotionSensor.Value.ToString();
            DataMap.Where(x => x.Key == "SoundSensorInventory").First().Value = numericUpDownSoundSensor.Value.ToString();
            DataMap.Where(x => x.Key == "SanityPillsInventory").First().Value = numericUpDownSanity.Value.ToString();
            DataMap.Where(x => x.Key == "ThermometerInventory").First().Value = numericUpDownThermometer.Value.ToString();
            DataMap.Where(x => x.Key == "GhostWritingBookInventory").First().Value = numericUpDownBook.Value.ToString();
            DataMap.Where(x => x.Key == "IRLightSensorInventory").First().Value = numericUpDownIR.Value.ToString();
            DataMap.Where(x => x.Key == "ParabolicMicrophoneInventory").First().Value = numericUpDownParabolic.Value.ToString();
            DataMap.Where(x => x.Key == "GlowstickInventory").First().Value = numericUpDownGlowStick.Value.ToString();
            DataMap.Where(x => x.Key == "HeadMountedCameraInventory").First().Value = numericUpDownHeadCam.Value.ToString();
        }

        private void UpdateJson()
        {
            foreach(var d in DataMap)
            {
                if (d.Category == "IntData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.Where(x => x["Key"].ToString() == d.Key).First();
                    node["Value"] = int.Parse(d.Value);
                }
                else if (d.Category == "FloatData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.Where(x => x["Key"].ToString() == d.Key).First();
                    node["Value"] = float.Parse(d.Value);
                }
                else if (d.Category == "BoolData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.Where(x => x["Key"].ToString() == d.Key).First();
                    node["Value"] = bool.Parse(d.Value);
                }
                else if (d.Category == "StringData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.Where(x => x["Key"].ToString() == d.Key).First();
                    node["Value"] = d.Value;
                }
            }
        }

        private void buttonGhost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGhost.Text)) textBoxGhost.Text = DataMap.Where(d => d.Key == "GhostType").FirstOrDefault().Value;
            else textBoxGhost.Text = "";
        }
    }
}
