using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knihovna;   

namespace XP_TDD
{
    public partial class Form1 : Form
    {
        HerniPostava postava;
        Hrac hrac;
        NPC npc;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length <= 10)
            {
                postava = new HerniPostava(textBox1.Text);

                try
                {
                    object vybranaPolozka = comboBox4.SelectedItem;
                    string specializaceText = vybranaPolozka.ToString();
                    Specializace specializace = (Specializace)Enum.Parse(typeof(Specializace), specializaceText);

                    vybranaPolozka = comboBox1.SelectedItem;
                    string oblicejText = vybranaPolozka.ToString();
                    Oblicej oblicej = (Oblicej)Enum.Parse(typeof(Oblicej), oblicejText);

                    vybranaPolozka = comboBox2.SelectedItem;
                    string vlasyText = vybranaPolozka.ToString();
                    Vlasy vlasy = (Vlasy)Enum.Parse(typeof(Vlasy), vlasyText);

                    vybranaPolozka = comboBox3.SelectedItem;
                    string barvaVlasuText = vybranaPolozka.ToString();
                    BarvaVlasu barvaVlasu = (BarvaVlasu)Enum.Parse(typeof(BarvaVlasu), barvaVlasuText);

                    hrac = new Hrac(textBox1.Text, specializace, oblicej, vlasy, barvaVlasu);

                    MessageBox.Show("Hráč byl úspěšně vytvořen!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo k chybě při vytváření hráče: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Jméno je příliš dlouhé!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hrac != null && postava != null && npc != null)
            {
                int hodnota = (int)numericUpDown1.Value;
                if (hodnota > 0)
                {
                    hrac.PridejXP(hodnota);
                    MessageBox.Show("XP byly úspěšně přidány!");
                }
                else
                {
                    MessageBox.Show("XP nebyly přidány, musíš zadat hodnotu větší než 0!");
                }
            }
            else
            {
                MessageBox.Show("Nejprve vytvořte postavu hráče, a NPC.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hrac != null && postava != null && npc != null)
            {
                label8.Text = hrac.ToString();
                label9.Text = npc.ToString();
            }
            else
            {
                MessageBox.Show("Nejprve vytvořte postavu hráče, a NPC.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (hrac != null && postava != null && npc != null)
            {
                int NovaX = (int)numericUpDown2.Value;
                int NovaY = (int)numericUpDown3.Value;
                hrac.ZmenaPozice(NovaX, NovaY);
                MessageBox.Show("Pozice byla změněna!");
            }
            else
            {
                MessageBox.Show("Nejprve vytvořte postavu hráče, a NPC.");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length <= 10)
            {
                try
                {
                    string jmeno = textBox2.Text;

                    object vybranaPolozka = comboBox5.SelectedItem;
                    string praceText = vybranaPolozka.ToString();
                    Prace prace = (Prace)Enum.Parse(typeof(Prace), praceText);
                    bool JeBoss = true;

                    if (radioButton1.Checked)
                    {
                        JeBoss = true;
                    }
                    else if (radioButton2.Checked)
                    {
                        JeBoss = false;
                    }

                    npc = new NPC(jmeno, prace, JeBoss);
                    npc.ZmenaPozice(8, 4);

                    MessageBox.Show("NPC bylo vytvořeno!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo k chybě při vytváření hráče: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Jméno je příliš dlouhé!");
            }
                
        }
    }
}
