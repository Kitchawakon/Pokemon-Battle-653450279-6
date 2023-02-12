namespace Pokemon_Battle_653450279_6
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Nihilego());
            pokemons.Add(new Zygarde());
            pokemons.Add(new Groudon());
            pokemons.Add(new Kyogre()); 

            this.monster = new Ho_oh();
            this.pictureBox2.Image = this.monster.getImage();
            this.Bossname.Text = this.monster.getName();
            this.BossHP.Text = this.monster.getHP().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.tbName.Text = "*Fainted*";
                this.tbHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.tbName.Text = "*Fainted*";
                this.tbHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.tbName.Text = "*Fainted*";
                this.tbHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.tbName.Text = selectedPokemon.getName();
            this.tbHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.tbName.Text = "*Fainted*";
                this.tbHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.selectedPokemon.getAttack() - this.monster.getDefense();
            int reflectDamage = this.monster.getAttack() - this.selectedPokemon.getDefense();
            if (damage >= 0 && reflectDamage >= 0)
            {
                this.tbHP.Text = this.selectedPokemon.takeDamage(damage).ToString();
                this.BossHP.Text = this.monster.takeDamage(damage).ToString();
            }
            if (this.monster.getHP() <= 0)
            {
                this.LBR.Text = "Yon Won!";
                this.pictureBox2.Image = null;
                this.BossHP.Text = "0";
            }
            else if (this.selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.tbName.Text = "*Fainted*";
                this.tbHP.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BossHP_TextChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.selectedPokemon.getHP() > 0)
            {
                int getHeal = this.selectedPokemon.getHP() + 50;
                this.tbHP.Text = getHeal.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int getDefense = this.selectedPokemon.getDefense() + 50;
        }
    }
}