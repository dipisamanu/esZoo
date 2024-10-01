using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_DiPisa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pinguino> pinguini = new List<Pinguino>();
        List<Rinoceronte> rinoceronti = new List<Rinoceronte>();
        List<Giraffa> giraffe = new List<Giraffa>();
        List<Scimmia> scimmie = new List<Scimmia>();
        List<Serpente> serpenti = new List<Serpente>();
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.SelectedIndex);
            int selected = comboBox1.SelectedIndex;
            switch (selected)
            {
                case 1:
                    label4.Text = "Età";
                    label5.Text = "Colore";
                    label6.Text = "Peso";
                    break;
                case 2:
                    label4.Text = "Età";
                    label5.Text = "Corni";
                    label6.Text = "Peso";
                    break;
                case 3:
                    label4.Text = "Età";
                    label5.Text = "Altezza";
                    label6.Text = "Temperamento";
                    break;
                case 4:
                    label4.Text = "Età";
                    label5.Text = "Temperamento";
                    label6.Text = "Velocità di Corsa";
                    break;
                case 5:
                    label4.Text = "Età";
                    label5.Text = "Lunghezza";
                    label6.Text = "Colore";
                    break;
            }
        }

        public void TextboxClear()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Inserisci dati validi! ");
                return;
            }
            int selected = comboBox1.SelectedIndex;
            switch (selected)
            {
                case 1:
                    Pinguino pinguino = new Pinguino(textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
                    pinguini.Add(pinguino);
                    TextboxClear();
                    break;
                case 2:
                    Rinoceronte rinoceronte = new Rinoceronte(textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                    rinoceronti.Add(rinoceronte);
                    TextboxClear();
                    break;
                case 3:
                    Giraffa giraffa = new Giraffa(textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text);
                    giraffe.Add(giraffa);
                    TextboxClear();
                    break;
                case 4:
                    Scimmia scimmia = new Scimmia(textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
                    scimmie.Add(scimmia);
                    TextboxClear();
                    break;
                case 5:
                    Serpente serpente = new Serpente(textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text);
                    serpenti.Add(serpente);
                    TextboxClear();
                    break;
                default:
                    MessageBox.Show("Selezione non valida");
                    break;
            }

        }

        private void PopolaDataGridView<T>(List<T> animali)
        {
            dataGridView1.DataSource = animali;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            switch (selected)
            {
                case 1:
                    PopolaDataGridView(pinguini);
                    break;
                case 2:
                    PopolaDataGridView(rinoceronti);
                    break;
                case 3:
                    PopolaDataGridView(giraffe);
                    break;
                case 4:
                    PopolaDataGridView(scimmie);
                    break;
                case 5:
                    PopolaDataGridView(serpenti);
                    break;
            }
        }

        public class Pinguino
        {
            public string Nome { get; set; }
            public DateTime UltimoPasto { get; set; }
            public int Età { get; set; }
            public string Colore { get; set; }
            public int Peso { get; set; }

            public Pinguino(string nome, DateTime ultimoPasto, int età, string colore, int peso)
            {
                Nome = nome;
                UltimoPasto = ultimoPasto;
                Età = età;
                Colore = colore;
                Peso = peso;
            }
        }
        public class Rinoceronte
        {
            string Nome { get; set; }
            DateTime UltimoPasto { get; set; }
            int Età { get; set; }
            int Corni { get; set; }
            int Peso { get; set; }

            public Rinoceronte(string nome, DateTime ultimoPasto, int età, int corni, int peso)
            {
                Nome = nome;
                UltimoPasto = ultimoPasto;
                Età = età;
                Corni = corni;
                Peso = peso;
            }
        }
        public class Giraffa
        {
            string Nome { get; set; }
            DateTime UltimoPasto { get; set; }
            int Età { get; set; }
            int Altezza { get; set; }
            string Temperamento { get; set; }

            public Giraffa(string nome, DateTime ultimoPasto, int età, int altezza, string temperamento)
            {
                Nome = nome;
                UltimoPasto = ultimoPasto;
                Età = età;
                Altezza = altezza;
                Temperamento = temperamento;
            }
        }
        public class Scimmia
        {
            string Nome { get; set; }
            DateTime UltimoPasto { get; set; }
            int Età { get; set; }
            string Temperamento { get; set; }
            int VelocitàCorsa { get; set; }

            public Scimmia(string nome, DateTime ultimoPasto, int età, string temperamento, int velocitàCorsa)
            {
                Nome = nome;
                UltimoPasto = ultimoPasto;
                Età = età;
                Temperamento = temperamento;
                VelocitàCorsa = velocitàCorsa;
            }
        }
        public class Serpente
        {
            string Nome { get; set; }
            DateTime UltimoPasto { get; set; }
            int Età { get; set; }
            int Lunghezza { get; set; }
            string Colore { get; set; }

            public Serpente(string nome, DateTime ultimoPasto, int età, int lunghezza, string colore)
            {
                Nome = nome;
                UltimoPasto = ultimoPasto;
                Età = età;
                Lunghezza = lunghezza;
                Colore = colore;
            }
        }
    }
}
