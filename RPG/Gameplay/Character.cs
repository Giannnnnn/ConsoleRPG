using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Gameplay
{
    class Character
    {

        //core
        private String name = "";
        private int level = 0;
        private int exp = 3;
        private int attributePoints = 3;
        private int expMax = 100;
        
        //attributes
        private int vitality = 1;
        private int strenght = 1;
        private int dexterity = 1;
        private int agility = 1;
        private int intelligenge = 1;
        //stats
        private int hp = 0;
        private int hpMax = 10;
        private int damage = 1;
        private int damageMax = 0;
        private int accuracy = 0;
        private int defence = 0;
        //general
        private int gold = 100;

        private void CalculateStats()
        {
            this.hp = this.vitality * 10;
            this.damageMax = this.strenght * 2;
            this.damage = this.strenght;
            this.accuracy = this.dexterity * 2;
            this.defence = this.agility * 2;
        }
        private void CalculateExp()
        {
            this.expMax = this.level * 100;
        }

        public Character(String name)
        {
            this.CalculateStats();
            this.name = name;
        }
        public override String ToString()
        {
            return this.name;
        }

    }
}
