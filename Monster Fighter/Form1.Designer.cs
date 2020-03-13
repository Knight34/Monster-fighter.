namespace Monster_Fighter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPlayerHealth = new System.Windows.Forms.TextBox();
            this.textBoxPlayerScore = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDecreaseScore = new System.Windows.Forms.Button();
            this.buttonIncreaseScore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlayerLives = new System.Windows.Forms.TextBox();
            this.buttonAddLives = new System.Windows.Forms.Button();
            this.buttonRemLives = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon = new System.Windows.Forms.GroupBox();
            this.buttonGenerateRandomWeapon = new System.Windows.Forms.Button();
            this.buttonDropWeapon = new System.Windows.Forms.Button();
            this.textBoxWeaponAttackPower = new System.Windows.Forms.TextBox();
            this.textBoxWeaponType = new System.Windows.Forms.TextBox();
            this.textBoxWeaponName = new System.Windows.Forms.TextBox();
            this.textBoxArmourDefencePower = new System.Windows.Forms.TextBox();
            this.textBoxArmourType = new System.Windows.Forms.TextBox();
            this.textBoxArmourName = new System.Windows.Forms.TextBox();
            this.buttonGenerateRandomArmour = new System.Windows.Forms.Button();
            this.buttonDropArmour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxCurrentArmour = new System.Windows.Forms.GroupBox();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonDog = new System.Windows.Forms.Button();
            this.buttonCat = new System.Windows.Forms.Button();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.textBoxMonsterNameAndType = new System.Windows.Forms.TextBox();
            this.textBoxMonsterAttack = new System.Windows.Forms.TextBox();
            this.textBoxMonsterHealth = new System.Windows.Forms.TextBox();
            this.textBoxMonsterDefence = new System.Windows.Forms.TextBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon.SuspendLayout();
            this.groupBoxCurrentArmour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlayerHealth
            // 
            this.textBoxPlayerHealth.Location = new System.Drawing.Point(206, 162);
            this.textBoxPlayerHealth.Name = "textBoxPlayerHealth";
            this.textBoxPlayerHealth.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerHealth.TabIndex = 1;
            // 
            // textBoxPlayerScore
            // 
            this.textBoxPlayerScore.Location = new System.Drawing.Point(206, 136);
            this.textBoxPlayerScore.Name = "textBoxPlayerScore";
            this.textBoxPlayerScore.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerScore.TabIndex = 3;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(206, 110);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(156, 214);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 9;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(237, 214);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonDecreaseScore
            // 
            this.buttonDecreaseScore.Location = new System.Drawing.Point(313, 136);
            this.buttonDecreaseScore.Name = "buttonDecreaseScore";
            this.buttonDecreaseScore.Size = new System.Drawing.Size(92, 22);
            this.buttonDecreaseScore.TabIndex = 12;
            this.buttonDecreaseScore.Text = "Decrease Score";
            this.buttonDecreaseScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonDecreaseScore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDecreaseScore.UseVisualStyleBackColor = true;
            this.buttonDecreaseScore.Click += new System.EventHandler(this.buttonDecreaseScore_Click);
            // 
            // buttonIncreaseScore
            // 
            this.buttonIncreaseScore.Location = new System.Drawing.Point(313, 108);
            this.buttonIncreaseScore.Name = "buttonIncreaseScore";
            this.buttonIncreaseScore.Size = new System.Drawing.Size(92, 22);
            this.buttonIncreaseScore.TabIndex = 13;
            this.buttonIncreaseScore.Text = "Increase Score";
            this.buttonIncreaseScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonIncreaseScore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonIncreaseScore.UseVisualStyleBackColor = true;
            this.buttonIncreaseScore.Click += new System.EventHandler(this.buttonIncreaseScore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lives";
            // 
            // textBoxPlayerLives
            // 
            this.textBoxPlayerLives.Location = new System.Drawing.Point(206, 188);
            this.textBoxPlayerLives.Name = "textBoxPlayerLives";
            this.textBoxPlayerLives.Size = new System.Drawing.Size(101, 20);
            this.textBoxPlayerLives.TabIndex = 14;
            // 
            // buttonAddLives
            // 
            this.buttonAddLives.Location = new System.Drawing.Point(313, 165);
            this.buttonAddLives.Name = "buttonAddLives";
            this.buttonAddLives.Size = new System.Drawing.Size(92, 21);
            this.buttonAddLives.TabIndex = 16;
            this.buttonAddLives.Text = "Add Lives";
            this.buttonAddLives.UseVisualStyleBackColor = true;
            this.buttonAddLives.Click += new System.EventHandler(this.buttonAddLives_Click);
            // 
            // buttonRemLives
            // 
            this.buttonRemLives.Location = new System.Drawing.Point(313, 192);
            this.buttonRemLives.Name = "buttonRemLives";
            this.buttonRemLives.Size = new System.Drawing.Size(92, 21);
            this.buttonRemLives.TabIndex = 17;
            this.buttonRemLives.Text = "Subtract Lives";
            this.buttonRemLives.UseVisualStyleBackColor = true;
            this.buttonRemLives.Click += new System.EventHandler(this.buttonRemLives_Click);
            // 
            // groupBoxCurrentWeapon
            // 
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonGenerateRandomWeapon);
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonDropWeapon);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponAttackPower);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponType);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponName);
            this.groupBoxCurrentWeapon.Location = new System.Drawing.Point(451, 62);
            this.groupBoxCurrentWeapon.Name = "groupBoxCurrentWeapon";
            this.groupBoxCurrentWeapon.Size = new System.Drawing.Size(291, 146);
            this.groupBoxCurrentWeapon.TabIndex = 18;
            this.groupBoxCurrentWeapon.TabStop = false;
            this.groupBoxCurrentWeapon.Text = "Current Weapon";
            // 
            // buttonGenerateRandomWeapon
            // 
            this.buttonGenerateRandomWeapon.Location = new System.Drawing.Point(17, 100);
            this.buttonGenerateRandomWeapon.Name = "buttonGenerateRandomWeapon";
            this.buttonGenerateRandomWeapon.Size = new System.Drawing.Size(120, 40);
            this.buttonGenerateRandomWeapon.TabIndex = 4;
            this.buttonGenerateRandomWeapon.Text = "Generate Random Weapon";
            this.buttonGenerateRandomWeapon.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomWeapon.Click += new System.EventHandler(this.buttonGenerateRandomWeapon_Click);
            // 
            // buttonDropWeapon
            // 
            this.buttonDropWeapon.Location = new System.Drawing.Point(154, 100);
            this.buttonDropWeapon.Name = "buttonDropWeapon";
            this.buttonDropWeapon.Size = new System.Drawing.Size(115, 40);
            this.buttonDropWeapon.TabIndex = 3;
            this.buttonDropWeapon.Text = "Drop Weapon";
            this.buttonDropWeapon.UseVisualStyleBackColor = true;
            this.buttonDropWeapon.Click += new System.EventHandler(this.buttonDropWeapon_Click);
            // 
            // textBoxWeaponAttackPower
            // 
            this.textBoxWeaponAttackPower.Location = new System.Drawing.Point(119, 74);
            this.textBoxWeaponAttackPower.Name = "textBoxWeaponAttackPower";
            this.textBoxWeaponAttackPower.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponAttackPower.TabIndex = 2;
            // 
            // textBoxWeaponType
            // 
            this.textBoxWeaponType.Location = new System.Drawing.Point(119, 48);
            this.textBoxWeaponType.Name = "textBoxWeaponType";
            this.textBoxWeaponType.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponType.TabIndex = 1;
            // 
            // textBoxWeaponName
            // 
            this.textBoxWeaponName.Location = new System.Drawing.Point(119, 19);
            this.textBoxWeaponName.Name = "textBoxWeaponName";
            this.textBoxWeaponName.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponName.TabIndex = 0;
            this.textBoxWeaponName.TextChanged += new System.EventHandler(this.textBoxWeaponName_TextChanged);
            // 
            // textBoxArmourDefencePower
            // 
            this.textBoxArmourDefencePower.Location = new System.Drawing.Point(150, 126);
            this.textBoxArmourDefencePower.Name = "textBoxArmourDefencePower";
            this.textBoxArmourDefencePower.Size = new System.Drawing.Size(163, 20);
            this.textBoxArmourDefencePower.TabIndex = 19;
            // 
            // textBoxArmourType
            // 
            this.textBoxArmourType.Location = new System.Drawing.Point(150, 100);
            this.textBoxArmourType.Name = "textBoxArmourType";
            this.textBoxArmourType.Size = new System.Drawing.Size(163, 20);
            this.textBoxArmourType.TabIndex = 20;
            // 
            // textBoxArmourName
            // 
            this.textBoxArmourName.Location = new System.Drawing.Point(150, 74);
            this.textBoxArmourName.Name = "textBoxArmourName";
            this.textBoxArmourName.Size = new System.Drawing.Size(163, 20);
            this.textBoxArmourName.TabIndex = 22;
            // 
            // buttonGenerateRandomArmour
            // 
            this.buttonGenerateRandomArmour.Location = new System.Drawing.Point(6, 152);
            this.buttonGenerateRandomArmour.Name = "buttonGenerateRandomArmour";
            this.buttonGenerateRandomArmour.Size = new System.Drawing.Size(145, 37);
            this.buttonGenerateRandomArmour.TabIndex = 24;
            this.buttonGenerateRandomArmour.Text = "Generate Random Armour";
            this.buttonGenerateRandomArmour.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomArmour.Click += new System.EventHandler(this.buttonGenerateRandomArmour_Click);
            // 
            // buttonDropArmour
            // 
            this.buttonDropArmour.Location = new System.Drawing.Point(168, 152);
            this.buttonDropArmour.Name = "buttonDropArmour";
            this.buttonDropArmour.Size = new System.Drawing.Size(145, 37);
            this.buttonDropArmour.TabIndex = 25;
            this.buttonDropArmour.Text = "Drop Armour";
            this.buttonDropArmour.UseVisualStyleBackColor = true;
            this.buttonDropArmour.Click += new System.EventHandler(this.buttonDropArmour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Current Armour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Defence Power:";
            // 
            // groupBoxCurrentArmour
            // 
            this.groupBoxCurrentArmour.Controls.Add(this.buttonGenerateRandomArmour);
            this.groupBoxCurrentArmour.Controls.Add(this.label5);
            this.groupBoxCurrentArmour.Controls.Add(this.label6);
            this.groupBoxCurrentArmour.Controls.Add(this.label7);
            this.groupBoxCurrentArmour.Controls.Add(this.label8);
            this.groupBoxCurrentArmour.Controls.Add(this.buttonDropArmour);
            this.groupBoxCurrentArmour.Controls.Add(this.textBoxArmourDefencePower);
            this.groupBoxCurrentArmour.Controls.Add(this.textBoxArmourType);
            this.groupBoxCurrentArmour.Controls.Add(this.textBoxArmourName);
            this.groupBoxCurrentArmour.Location = new System.Drawing.Point(437, 236);
            this.groupBoxCurrentArmour.Name = "groupBoxCurrentArmour";
            this.groupBoxCurrentArmour.Size = new System.Drawing.Size(319, 202);
            this.groupBoxCurrentArmour.TabIndex = 30;
            this.groupBoxCurrentArmour.TabStop = false;
            this.groupBoxCurrentArmour.Text = "Current Armour";
            // 
            // buttonPet
            // 
            this.buttonPet.Location = new System.Drawing.Point(156, 265);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(75, 63);
            this.buttonPet.TabIndex = 30;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // buttonDog
            // 
            this.buttonDog.Location = new System.Drawing.Point(237, 265);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(75, 63);
            this.buttonDog.TabIndex = 31;
            this.buttonDog.Text = "Dog";
            this.buttonDog.UseVisualStyleBackColor = true;
            this.buttonDog.Click += new System.EventHandler(this.buttonDog_Click);
            // 
            // buttonCat
            // 
            this.buttonCat.Location = new System.Drawing.Point(156, 334);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(75, 63);
            this.buttonCat.TabIndex = 32;
            this.buttonCat.Text = "Cat";
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMonster.Location = new System.Drawing.Point(846, 1);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonster.TabIndex = 33;
            this.pictureBoxMonster.TabStop = false;
            // 
            // textBoxMonsterNameAndType
            // 
            this.textBoxMonsterNameAndType.Location = new System.Drawing.Point(816, 307);
            this.textBoxMonsterNameAndType.Name = "textBoxMonsterNameAndType";
            this.textBoxMonsterNameAndType.Size = new System.Drawing.Size(365, 20);
            this.textBoxMonsterNameAndType.TabIndex = 34;
            this.textBoxMonsterNameAndType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMonsterAttack
            // 
            this.textBoxMonsterAttack.Location = new System.Drawing.Point(901, 372);
            this.textBoxMonsterAttack.Name = "textBoxMonsterAttack";
            this.textBoxMonsterAttack.Size = new System.Drawing.Size(171, 20);
            this.textBoxMonsterAttack.TabIndex = 35;
            // 
            // textBoxMonsterHealth
            // 
            this.textBoxMonsterHealth.Location = new System.Drawing.Point(901, 346);
            this.textBoxMonsterHealth.Name = "textBoxMonsterHealth";
            this.textBoxMonsterHealth.Size = new System.Drawing.Size(171, 20);
            this.textBoxMonsterHealth.TabIndex = 36;
            // 
            // textBoxMonsterDefence
            // 
            this.textBoxMonsterDefence.Location = new System.Drawing.Point(901, 398);
            this.textBoxMonsterDefence.Name = "textBoxMonsterDefence";
            this.textBoxMonsterDefence.Size = new System.Drawing.Size(171, 20);
            this.textBoxMonsterDefence.TabIndex = 37;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(816, 424);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(132, 79);
            this.buttonAttack.TabIndex = 39;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(853, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Health:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(853, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Attack:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(843, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Defence:";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(1049, 424);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(132, 79);
            this.buttonRun.TabIndex = 43;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 550);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.textBoxMonsterDefence);
            this.Controls.Add(this.textBoxMonsterHealth);
            this.Controls.Add(this.textBoxMonsterAttack);
            this.Controls.Add(this.textBoxMonsterNameAndType);
            this.Controls.Add(this.pictureBoxMonster);
            this.Controls.Add(this.buttonCat);
            this.Controls.Add(this.buttonDog);
            this.Controls.Add(this.buttonPet);
            this.Controls.Add(this.groupBoxCurrentArmour);
            this.Controls.Add(this.groupBoxCurrentWeapon);
            this.Controls.Add(this.buttonRemLives);
            this.Controls.Add(this.buttonAddLives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlayerLives);
            this.Controls.Add(this.buttonIncreaseScore);
            this.Controls.Add(this.buttonDecreaseScore);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.textBoxPlayerScore);
            this.Controls.Add(this.textBoxPlayerHealth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCurrentWeapon.ResumeLayout(false);
            this.groupBoxCurrentWeapon.PerformLayout();
            this.groupBoxCurrentArmour.ResumeLayout(false);
            this.groupBoxCurrentArmour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPlayerHealth;
        private System.Windows.Forms.TextBox textBoxPlayerScore;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDecreaseScore;
        private System.Windows.Forms.Button buttonIncreaseScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlayerLives;
        private System.Windows.Forms.Button buttonAddLives;
        private System.Windows.Forms.Button buttonRemLives;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeapon;
        private System.Windows.Forms.Button buttonGenerateRandomWeapon;
        private System.Windows.Forms.Button buttonDropWeapon;
        private System.Windows.Forms.TextBox textBoxWeaponAttackPower;
        private System.Windows.Forms.TextBox textBoxWeaponType;
        private System.Windows.Forms.TextBox textBoxWeaponName;
        private System.Windows.Forms.TextBox textBoxArmourDefencePower;
        private System.Windows.Forms.TextBox textBoxArmourType;
        private System.Windows.Forms.TextBox textBoxArmourName;
        private System.Windows.Forms.Button buttonGenerateRandomArmour;
        private System.Windows.Forms.Button buttonDropArmour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxCurrentArmour;
        private System.Windows.Forms.Button buttonPet;
        private System.Windows.Forms.Button buttonDog;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.TextBox textBoxMonsterNameAndType;
        private System.Windows.Forms.TextBox textBoxMonsterAttack;
        private System.Windows.Forms.TextBox textBoxMonsterHealth;
        private System.Windows.Forms.TextBox textBoxMonsterDefence;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRun;
    }
}

