using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mackay_Nel_Task1
{
    [Serializable]
   public class RangedUnit : Unit
    {
        //IsDead field used for Death Method.

        public bool IsDead { get; set; }

        public int XPos
        {
            get { return base.xPos; }
            set { base.xPos = value; }
        }

        public int YPos
        {
            get { return base.yPos; }
            set { base.yPos = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        public int MaxHealth
        {
            get { return base.maxHealth; }
        }

        public int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }

        public int AttackRange
        {
            get { return base.attackRange; }
            set { base.attackRange = value; }
        }

        public int Speed
        {
            get { return base.speed; }
            set { base.speed = value; }
        }

        public int Faction
        {
            get { return base.faction; }
        }

        public string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }

        public bool IsAttacking
        {
            get { return base.isAttacking; }
            set { base.isAttacking = value; }
        }

        public new string unit_types//Task 2 Q)2.3 added unit types
        {
            get { return base.unit_types; }
            set => base.unit_types = value;
        }


        public RangedUnit(int x, int y, int h, int s, int a, int ar, int f, string sy, string ur)//Task 2 Q)2.3 added unit types
        {
            XPos = x;
            YPos = y;
            Health = h;
            base.maxHealth = h;
            Speed = s;
            Attack = a;
            AttackRange = ar;
            base.faction = f;
            Symbol = sy;
            IsAttacking = false;
            IsDead = false;
            unit_types = ur;

        }

        public override void Death()
        {
            symbol = "x";
            IsDead = true;
        }

        public override void Combat(Unit attacker)
        {
            if (attacker is MeleeUnit)
            {
                Health = Health - ((MeleeUnit)attacker).Attack;
            }
            else if (attacker is RangedUnit)
            {
                RangedUnit ru = (RangedUnit)attacker;
                Health = Health - (ru.Attack - ru.AttackRange);
            }
            if (Health <= 0)
            {
                Death(); //Unit Died. 
            }
        }

        public static explicit operator RangedUnit(MeleeUnit v)
        {
            throw new NotImplementedException();
        }

        public override bool InRange(Unit other)
        {
            int distance = 0;
            int otherX = 0;
            int otherY = 0;
            if (other is MeleeUnit)
            {
                otherX = ((MeleeUnit)other).XPos;
                otherY = ((MeleeUnit)other).YPos;
            }
            else if (other is RangedUnit)
            {
                otherX = ((RangedUnit)other).XPos;
                otherY = ((RangedUnit)other).YPos;
            }

            distance = Math.Abs(XPos - otherX) + Math.Abs(YPos - otherY);
            if (distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Move(int dir)
        {
            switch (dir)
            {
                case 0: YPos--; break; //N
                case 1: XPos++; break; //E
                case 2: YPos++; break; //S
                case 3: XPos--; break; //W
                default: break;
            }
        }

        public override string ToString()
        {
            string temp = "";
            temp +=  "Ranged:";
            temp += ("{" + Symbol + "}");
            temp += "(" + XPos + "," + YPos + ")";
            temp += Health + ", " + Attack + ", " + AttackRange + ", " + Speed;
            temp += (IsDead ? "DEAD!" : "ALIVE!");
            temp += "Unit_Type: " + unit_types;//Task 2 Q)2.3 added unit types
            return temp;
        }
    }
}

