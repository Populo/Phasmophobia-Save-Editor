using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phasmophobia_Save_Editor
{
    public partial class FormHome : Form
    {
        private readonly string _encKey = "CHANGE ME TO YOUR OWN RANDOM STRING";

        private string SaveFileLocation { get; set; }
        private List<SaveValue> DataMap { get; set; }
        private Dictionary<string, NumericUpDown> ControlMap { get; set; }
        private JObject SaveData { get; set; }

        public FormHome()
        {
            InitializeComponent();
            MaximizeBox = false;
            BuildControlMap();
            SaveFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Low\Kinetic Games\Phasmophobia\saveData.txt";
        }

        private void BuildControlMap()
        {
            ControlMap = new Dictionary<string, NumericUpDown>()
            {
                {"myTotalExp", numericUpDownXP},
                {"PlayersMoney", numericUpDownMoney},
                {"EMFReaderInventory", numericUpDownEMF},
                {"FlashlightInventory", numericUpDownFlashlight},
                {"CameraInventory", numericUpDownCamera},
                {"LighterInventory", numericUpDownLighter},
                {"CandleInventory", numericUpDownCandle},
                {"UVFlashlightInventory", numericUpDownUV},
                {"CrucifixInventory", numericUpDownCrucifix},
                {"DSLRCameraInventory", numericUpDownVideoCamera},
                {"EVPRecorderInventory", numericUpDownSpiritBox},
                {"SaltInventory", numericUpDownSalt},
                {"SageInventory", numericUpDownSage},
                {"TripodInventory", numericUpDownTripod},
                {"StrongFlashlightInventory", numericUpDownStrongFlashlight},
                {"MotionSensorInventory", numericUpDownMotionSensor},
                {"SoundSensorInventory", numericUpDownSoundSensor},
                {"SanityPillsInventory", numericUpDownSanity},
                {"ThermometerInventory", numericUpDownThermometer},
                {"GhostWritingBookInventory", numericUpDownBook},
                {"IRLightSensorInventory", numericUpDownIR},
                {"ParabolicMicrophoneInventory", numericUpDownParabolic},
                {"GlowstickInventory", numericUpDownGlowStick},
                {"HeadMountedCameraInventory", numericUpDownHeadCam}
            };
        }

        private void LoadFile()
        {
            string saveEnc;
            try
            {
                saveEnc = File.ReadAllText(SaveFileLocation);
            } 
            catch
            {
                saveEnc = "";
            }
            
            if (string.IsNullOrEmpty(saveEnc) || !SaveFileLocation.EndsWith("saveData.txt"))
            {
                MessageBox.Show(@"Could not load save file. Please select the save file and click load again. Default location is 'AppData\LocalLow\Kinetic Games\Phasmophobia'");
                SelectSaveFile();
            }

            if (string.IsNullOrEmpty(saveEnc) || !SaveFileLocation.EndsWith("saveData.txt")) return;
            
            var saveDec = Crypt(saveEnc, _encKey);

            DataMap = new List<SaveValue>();
            BuildDataMap(saveDec);

            PopulateForm();

            buttonSave.Enabled = true;
            buttonGhost.Enabled = true;
        }

        private void PopulateForm()
        {
            var intData = DataMap.Where(d => d.Category == "IntData" && d.NumberBox != null);
            foreach (var v in intData)
            {
                if (v.Key.Contains("xp")) v.GetValue(100);
                else v.GetValue();
            }
        }

        private void BuildDataMap(string saveDec)
        {
            var data = JObject.Parse(saveDec);
            SaveData = data;
            string[] categories = { "IntData", "StringData", "FloatData", "BoolData" };

            foreach (var s  in categories)
            {
                PopulateMap(data[s], s);
            }
        }

        private void PopulateMap(JToken jToken, string category)
        {
            foreach (var j in jToken)
            {
                var key = j["Key"]?.ToString();
                try
                {
                    DataMap.Add(new SaveValue()
                    {
                        Key = key,
                        Value = j["Value"]?.ToString(),
                        Category = category,
                        NumberBox = ControlMap[key]
                    });

                }
                catch
                {
                    DataMap.Add(new SaveValue()
                    {
                        Key = key,
                        Value = j["Value"]?.ToString(),
                        Category = category
                    });
                }
               
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

            string saveDec = SaveData.ToString();
            saveDec = saveDec.Replace(" ", "").Replace("\n", "").Replace("\t", "").Replace("\r", "");

            string saveEnc = Crypt(saveDec, _encKey);

            File.WriteAllText(SaveFileLocation, saveEnc);
        }

        private void UpdateMap()
        {
            var intData = DataMap.Where(d => d.Category == "IntData" && d.NumberBox != null);
            foreach (var v in intData)
            {
                v.SetValue();
            }
        }

        private void UpdateJson()
        {
            foreach(var d in DataMap)
            {
                if (d.Category == "IntData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.First(x => x["Key"]?.ToString() == d.Key);
                    node["Value"] = int.Parse(d.Value);
                }
                else if (d.Category == "FloatData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.First(x => x["Key"]?.ToString() == d.Key);
                    node["Value"] = float.Parse(d.Value);
                }
                else if (d.Category == "BoolData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.First(x => x["Key"]?.ToString() == d.Key);
                    node["Value"] = bool.Parse(d.Value);
                }
                else if (d.Category == "StringData")
                {
                    var cat = SaveData[d.Category];
                    var node = cat.First(x => x["Key"]?.ToString() == d.Key);
                    node["Value"] = d.Value;
                }
            }
        }

        private void buttonGhost_Click(object sender, EventArgs e)
        {
            textBoxGhost.Text = string.IsNullOrEmpty(textBoxGhost.Text) ? DataMap.FirstOrDefault(d => d.Key == "GhostType")?.Value : "";
        }
    }
}
