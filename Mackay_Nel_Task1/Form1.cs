using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;




namespace Mackay_Nel_Task1
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        BinaryFormatter bf = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void startbttn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void puasebttn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine(20, 4, infoTxtBox, grpMap);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            roundLbl.Text = "Round: " + engine.Round.ToString();
            engine.Update();
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            int n = 40;
            int bu = 4;
            Map map = new Map( n, bu , infoTxtBox);
            
            

            FileStream fs = new FileStream("SaveGame.bat", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fs)
                    bf.Serialize(fs,map.Units);
                    bf.Serialize(fs,map.Buildings);
            }
            catch (Exception r)
            {
                MessageBox.Show ("The game has been saved");
            }

        }

        private void loadBttn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("SaveGame.bat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                Building b = (Building)bf.Deserialize(fs);
                Unit u = (Unit)bf.Deserialize(fs);
            }
            catch (Exception r)
            {
                MessageBox.Show("The game has been loaded");
            }


        }
    }
}
