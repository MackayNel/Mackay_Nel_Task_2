using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mackay_Nel_Task1
{//This class holds all variables for the Factory buildings.
    [Serializable]
    class FactoryBuilding : Building //All Part of task 2
    {
        public bool IsDestroyed { get; set; }

        public override void Destroyed()
        {
            buildingSymbol = "[X]";
            IsDestroyed = true;
        }


        public int buildingX
        {
            get { return base.buildingX; }
            set { base.buildingX = value; }
        }

        public int buildingY
        {
            get { return base.buildingY; }
            set { base.buildingY = value; }
        }


        public int buildingHealth
        {
            get { return base.buildingHealth; }
            set { base.buildingHealth = value; }
        }

        public int buildingMaxH
        {
            get { return base.buildingMaxH; }
        }

        public int buildingFaction
        {
            get { return base.buildingFaction; }
        }


        public string buildingSymbol
        {
            get { return base.buildingSymbol; }
            set { base.buildingSymbol = value; }
        }

        private int unitGenerate;

        public int UnitGenerate
        {
            get { return unitGenerate; }
            set { unitGenerate = value; }
        }

        private int DeploymentSpeed;

        public int deploymentSpeed
        {
            get { return DeploymentSpeed; }
            set { DeploymentSpeed = value; }
        }

        private int buildSpawnX;

        public int BuildSpawnX   
        {
            get { return buildSpawnX; }
            set { buildSpawnX = value; }
        }

        private int buildSpawnY;

        public int BuildSpawnY  
        {
            get { return buildSpawnY; }
            set { buildSpawnY = value; }
        }

        public int ProductionSpeed { get; internal set; }

        public Unit UnitSpawn() //Detirmines what unit spawns
        {

            if (buildingFaction == 0)
            {
                Unit unit;
                if (UnitGenerate == 0)
                {
                    MeleeUnit mu = new MeleeUnit(BuildSpawnX,
                        BuildSpawnY + 1,
                        50,
                        1,
                        10,
                        0,
                        "M", "Knight");
                    unit = mu;
                }
                else
                {
                    RangedUnit ru = new RangedUnit(BuildSpawnX,
                        BuildSpawnY + 1,
                        35,
                        2,
                        5,
                        3,
                        0,
                        "R", "Wizard");
                    unit = ru;
                }
                return unit;
            }
            else
            {
                Unit unit;
                if (UnitGenerate == 0)
                {
                    MeleeUnit mu = new MeleeUnit(BuildSpawnX,
                        BuildSpawnY + 1,
                        50,
                        1,
                        10, 
                        1,
                        "m", "knight");
                    unit = mu;
                }
                else
                {
                    RangedUnit ru = new RangedUnit(BuildSpawnX,
                        BuildSpawnY + 1,
                        35,
                        2,
                        5,
                        3, 
                        1,
                        "r", "Archer");
                    unit = ru;
                }
                return unit;
            }

        }


        public override string ToString()
        {
            string temp = " ";
            temp += "Building :";
            temp += ("{" + buildingSymbol + "}");
            temp += "(" + buildingX + "," + buildingY + ")";
            temp += "Building Health" + buildingHealth;
            temp += (IsDestroyed ? "Damaged!" : "Functional!");
            return temp;
        }
        public FactoryBuilding(int bX, int bY, int bh, int bf, string bs)
        {
            buildingX = bX;
            buildingY = bY;
            buildingHealth = bh;
            base.buildingMaxH = bh;
            base.buildingFaction = bf;
            buildingSymbol = bs;
        }
    }
}

