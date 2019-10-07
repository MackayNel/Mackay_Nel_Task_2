using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mackay_Nel_Task1
{//This class is used to tell all the units and buildings how to behave.
    [Serializable]
    class GameEngine 
    {
        Map map;
        private int round = 0;
        Random r = new Random();
        GroupBox grpMap;

        public int Round
        {
            get { return round; }
        }

        public GameEngine(int numUnits,int numBuildings, TextBox infoTxtBox, GroupBox gMap)
        {
            grpMap = gMap;
            map = new Map(numUnits, numBuildings,infoTxtBox);
            map.Generate();
           // map.GenerateBuilding();
            map.Display(grpMap);

            round = 1;
        }

        public void Update()
        {
            foreach(Building bs in map.Buildings)
            {
                if (bs is FactoryBuilding)
                {
                    FactoryBuilding fb = (FactoryBuilding)bs;
                    if (fb.ProductionSpeed % Round == 0)
                    {
                        map.Units.Add(fb.UnitSpawn());
                    }
                }
            }
           
            for (int i = 0; i < map.Units.Count; i++)
            {
                if (map.Units[i] is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)map.Units[i];
                    // mu.Health = 10;//HandiCap 
                    if (mu.Health <= mu.MaxHealth * 0.25)//Moves away if unit is damaged 
                    {
                        mu.Move(r.Next(0, 4));
                    }
                    else
                    {
                        int shortest = 100;
                        Unit closestM = mu;
                        foreach (Unit u in map.Units)
                        {
                            if (u is MeleeUnit)
                            {
                                MeleeUnit otherMu = (MeleeUnit)u;
                                int distance = Math.Abs(mu.XPos - otherMu.XPos)
                                    + Math.Abs(mu.YPos - otherMu.YPos);
                                if (distance < shortest)
                                {
                                    shortest = distance;
                                    closestM = otherMu;
                                }
                            }
                        }
                        //Check in Range
                        int distanceTo = 0;
                        if (distanceTo <= mu.AttackRange)
                        {
                            mu.IsAttacking = true;
                            mu.Combat(closestM);
                        }
                        else//Move to closestM enemy unit!
                        {
                            if (closestM is MeleeUnit)
                            {
                                MeleeUnit closestMMu = (MeleeUnit)closestM;
                                if (mu.XPos > closestMMu.XPos)
                                {
                                    mu.Move(0);//North
                                }
                                else if (mu.XPos < closestMMu.XPos)
                                {
                                    mu.Move(2);//South
                                }
                                else if (mu.YPos > closestMMu.XPos)
                                {
                                    mu.Move(3);//West
                                }
                                else if (mu.YPos < closestMMu.XPos)
                                {
                                    mu.Move(1);//East
                                }
                            }
                            else if (closestM is RangedUnit)
                            {
                                RangedUnit closestMMu = (RangedUnit)closestM;
                                if (mu.XPos > closestMMu.XPos)
                                {
                                    mu.Move(0);//North
                                }
                                else if (mu.XPos < closestMMu.XPos)
                                {
                                    mu.Move(2);//South
                                }
                                else if (mu.YPos > closestMMu.XPos)
                                {
                                    mu.Move(3);//West
                                }
                                else if (mu.YPos < closestMMu.XPos)
                                {
                                    mu.Move(1);//East
                                }
                            }
                        }
                    }
                }
                if (map.Units[i] is RangedUnit)
                {
                    RangedUnit ru = (RangedUnit)map.Units[i];
                    if (ru.Health <= ru.MaxHealth * 0.25)//Moves away if unit is damaged 
                    {
                        ru.Move(r.Next(0, 4));
                    }
                    else
                    {
                        int shortest = 100;
                        Unit closestR = ru;
                        foreach (Unit u in map.Units)
                        {
                            if (u is RangedUnit)
                            {
                                RangedUnit otherRu = (RangedUnit)u;
                                int distance = Math.Abs(ru.XPos - otherRu.XPos)
                                    + Math.Abs(ru.YPos - otherRu.YPos);
                                if (distance < shortest)
                                {
                                    shortest = distance;
                                    closestR = otherRu;
                                }
                            }
                        }
                        int distanceTo = 0;
                        if (distanceTo <= ru.AttackRange)
                        {
                            ru.IsAttacking = true;
                            ru.Combat(closestR);
                        }
                        else
                        {
                            if (closestR is MeleeUnit)
                            {
                                MeleeUnit closestMMu = (MeleeUnit)closestR;
                                if (ru.XPos > closestMMu.XPos)
                                {
                                    ru.Move(0);//North
                                }
                                else if (ru.XPos < closestMMu.XPos)
                                {
                                    ru.Move(2);//South
                                }
                                else if (ru.YPos > closestMMu.XPos)
                                {
                                    ru.Move(3);//West
                                }
                                else if (ru.YPos < closestMMu.XPos)
                                {
                                    ru.Move(1);//East
                                }
                            }
                            else if (closestR is RangedUnit)
                            {
                                RangedUnit closestMMu = (RangedUnit)closestR;
                                if (ru.XPos > closestMMu.XPos)
                                {
                                    ru.Move(0);//North
                                }
                                else if (ru.XPos < closestMMu.XPos)
                                {
                                    ru.Move(2);//South
                                }
                                else if (ru.YPos > closestMMu.XPos)
                                {
                                    ru.Move(3);//West
                                }
                                else if (ru.YPos < closestMMu.XPos)
                                {
                                    ru.Move(1);//East
                                }
                            }
                        }
                    }
                }
            }

            //

            map.Display(grpMap);
            round++;

        }
        public int DistanceTo(Unit a, Unit b)
        {
            int distance = 0;

            if (a is MeleeUnit && b is MeleeUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is RangedUnit && b is MeleeUnit)
            {
                RangedUnit start = (RangedUnit)a;
                MeleeUnit end = (MeleeUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is RangedUnit && b is RangedUnit)
            {
                RangedUnit start = (RangedUnit)a;
                RangedUnit end = (RangedUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            else if (a is MeleeUnit && b is RangedUnit)
            {
                MeleeUnit start = (MeleeUnit)a;
                RangedUnit end = (RangedUnit)b;
                distance = Math.Abs(start.XPos - end.XPos) + Math.Abs(start.YPos - end.YPos);
            }
            return distance;
        }
    }
}
