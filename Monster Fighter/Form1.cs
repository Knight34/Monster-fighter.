using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Fighter
{
    public partial class Form1 : Form
    {
        List<Player> players = new List<Player>();
        List<Monster> monsters = new List<Monster>();
        List<Weapon> weapons = new List<Weapon>();
        List<Armour> armour = new List<Armour>();

        int playerDisplayed = 0;
        int currentMonster;

        private void GenerateRandomMonsterNumber()
        {
            Random rnd = new Random();
            currentMonster = rnd.Next(0, monsters.Count());
        }

        private void DisplayCurrentMonster()
        {
            Image monsterImage = Image.FromFile("Monster Images\\" + monsters[currentMonster].Type + ".jpg");
            pictureBoxMonster.Image = monsterImage;

            textBoxMonsterNameAndType.Text = monsters[currentMonster].Name + " the " + monsters[currentMonster].Type;
            textBoxMonsterHealth.Text = Convert.ToString(monsters[currentMonster].Health);
            textBoxMonsterAttack.Text = Convert.ToString(monsters[currentMonster].Attack);
            textBoxMonsterDefence.Text = Convert.ToString(monsters[currentMonster].Defence);

        }
        private void DisplayData()
        {
            textBoxPlayerName.Text = players[playerDisplayed].Name;
            textBoxPlayerScore.Text = players[playerDisplayed].Score.ToString();
            textBoxPlayerHealth.Text = players[playerDisplayed].Health.ToString();
            textBoxPlayerLives.Text = players[playerDisplayed].Lives.ToString();

            if (players[playerDisplayed].Weapon == null)
            {
                textBoxWeaponName.Text = "None";
                textBoxWeaponType.Text = "N/A";
                textBoxWeaponAttackPower.Text = "N/A";

            }
            else
            {
                textBoxWeaponName.Text = players[playerDisplayed].Weapon.Name;
                textBoxWeaponType.Text = players[playerDisplayed].Weapon.Type;
                textBoxWeaponAttackPower.Text = players[playerDisplayed].Weapon.AttackPower.ToString();
            }
            if (players[playerDisplayed].Armour == null)
            {
                textBoxArmourName.Text = "None";
                textBoxArmourType.Text = "N/A";
                textBoxArmourDefencePower.Text = "N/A";
            }
            else
            {
                textBoxArmourName.Text = players[playerDisplayed].Armour.Name;
                textBoxArmourType.Text = players[playerDisplayed].Armour.Type;
                textBoxArmourDefencePower.Text = players[playerDisplayed].Armour.DefencePower.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            players.Add(new Player("Hellboy", 0, 100, 2));
            players.Add(new Player("Feric", 0, 100, 2));
            players.Add(new Player("Callie", 0, 100, 2));
            players.Add(new Player("Basidor", 0, 90, 3));
            players.Add(new Player("SJMD", 0, 90, 4));

            monsters.Add(new Monster("Demon", "Imp", 1500, 60, 2000));
            monsters.Add(new Monster("Skaven", "Ratling gunner", 2500, 50, 2500));
            monsters.Add(new Monster("Necrophage", "Water Hag", 2000, 65, 3000));
            monsters.Add(new Monster("Elemental", "Rock", 2500, 200, 5000));
            monsters.Add(new Monster("Beast", "Dire wolf", 2000, 40, 3500));
            monsters.Add(new Monster("Monstrosity", "Minotaur", 3000, 85, 4000));
            monsters.Add(new Monster("Dragon", "Tyrone", 3500, 100, 4500));
            monsters.Add(new Monster("Undead", "Zombie Beholder", 3750, 80, 4700));
            monsters.Add(new Monster("Gorgen", "Medusa", 4000, 30, 3000));
            monsters.Add(new Monster("Alien", "Xenomorph", 3750, 85, 3500));
            monsters.Add(new Monster("Dragon God", "Bahumet", 5000, 120, 5000));
            monsters.Add(new Monster("Demigod", "Hercules", 4500, 90, 5500));

            GenerateRandomMonsterNumber();
            DisplayCurrentMonster();

            weapons.Add(new Weapon("Sword", "Iron Sword", 2));
            weapons.Add(new Weapon("Bow", "Wooden Bow", 2));
            weapons.Add(new Weapon("Scythe", "Crescent Rose", 5));
            weapons.Add(new Weapon("Wand", "Wand of Wonder", 5));
            weapons.Add(new Weapon("Guns", "Mercy and Redemption", 10));
            weapons.Add(new Weapon("Staff", "Ruyi Jingu Bang", 10));
            weapons.Add(new Weapon("Thunder Bolt", "Vajra", 25));
            weapons.Add(new Weapon("Hammer", "Mjolnir", 25));

            armour.Add(new Armour("Helmet", "Iron Helm", 2));
            armour.Add(new Armour("Shield", "Steel Shield", 3));
            armour.Add(new Armour("Armour", "Adamantite Armour", 4));
            armour.Add(new Armour("Armour", "Nemean Pelt", 5));


            DisplayData();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            playerDisplayed++;

            if (playerDisplayed == players.Count())
            {
                playerDisplayed = 0;
            }
            DisplayData();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            playerDisplayed--;

            if (playerDisplayed == -1)
            {
                playerDisplayed = players.Count() - 1;
            }
            DisplayData();

        }

        private void buttonIncreaseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = 100;
        }

        private void buttonDecreaseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = -100;
        }

        private void buttonAddLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = 1;
        }

        private void buttonRemLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = -1;
        }

        private void buttonGenerateRandomWeapon_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomWeaponNumber = rnd.Next(0, weapons.Count());

            DialogResult result = MessageBox.Show(weapons[randomWeaponNumber].Type + " found!" +
                Environment.NewLine + "\nIt's called the " + weapons[randomWeaponNumber].Name +
                Environment.NewLine + "\nAttack power " + weapons[randomWeaponNumber].AttackPower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to Equip it?", "Weapon Found", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Weapon = weapons[randomWeaponNumber];
            }
            DisplayData();
        }

        private void textBoxWeaponName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDropWeapon_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Weapon = null;

            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerateRandomArmour_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomArmourNumber = rnd.Next(0, armour.Count());

            DialogResult result = MessageBox.Show(armour[randomArmourNumber].Type + " found!" +
                Environment.NewLine + "\nIt's called the" + armour[randomArmourNumber].Name +
                Environment.NewLine + "\nDefense Power" + armour[randomArmourNumber].DefencePower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to Equip it?", "Armour Found", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Armour = armour[randomArmourNumber];
            }
            DisplayData();

        }

        private void buttonDropArmour_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Armour = null;
            DisplayData();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet myPet = new Pet("Dave", "Generic");

            MessageBox.Show(myPet.MakeNoise() +
                "I am a " + myPet.Breed +
                " Pet and my name is " + myPet.Name);
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Bosun", "Boxer");

            MessageBox.Show(myDog.MakeNoise() +
                " I am a " + myDog.Breed +
                " Dog and my name is " + myDog.Name);
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Jess", "Bombay");

            MessageBox.Show(myCat.MakeNoise() +
                " I am a " + myCat.Breed +
                " Cat and my name is " + myCat.Name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            int hitPower = 100;

            if (players[playerDisplayed].Weapon != null)
            {
                hitPower = 100 * players[playerDisplayed].Weapon.AttackPower;
            }

            monsters[currentMonster].Health = monsters[currentMonster].Health - hitPower;

            players[playerDisplayed].ChangeScore = hitPower;

            if(monsters[currentMonster].Health <= 0)
            {
                MessageBox.Show("Congratulations! You have killed " + monsters[currentMonster].Name +
                    " the " + monsters[currentMonster].Type + " :) ");

                MessageBox.Show("Get Ready for the next Monster!");

                GenerateRandomMonsterNumber();

            }
            DisplayCurrentMonster();

            DisplayData();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int grabChance = rnd.Next(0, 4);

            if (grabChance == 3)
            {
                int healthLost = monsters[currentMonster].Attack / 200;

                if (players[playerDisplayed].Armour != null)
                {
                    healthLost = healthLost / players[playerDisplayed].Armour.DefencePower;
                }

                if (players[playerDisplayed].Health - healthLost <= 0)
                {
                    players[playerDisplayed].Health = 0;
                }
                else
                {
                    players[playerDisplayed].Health = players[playerDisplayed].Health - healthLost;
                }
                DisplayData();

                MessageBox.Show("As you were running away, the " + monsters[currentMonster].Type + " grabbed you! And you have lost " + healthLost + " health :(");

            }

            if (players[playerDisplayed].Health != 0)
            {
                GenerateRandomMonsterNumber();
                DisplayCurrentMonster();
            }

            else
            {
                MessageBox.Show("Game OVER!!!" + Environment.NewLine + Environment.NewLine +
                    "You have died, unfortunately!");
            }
        }
    }
}
