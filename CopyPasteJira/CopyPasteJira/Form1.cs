using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPasteJira
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxUserStoryFull_TextChanged(object sender, EventArgs e)
        {
            ParseJiraStories();
        }

        private void ParseJiraStories()
        {
            String txtOrigem;
            String txtDestino;
            String prefixo;
            int lenPrefixo;
            int found;
            String toFind;

            prefixo = comboBoxPrefixo.Text;
            lenPrefixo = prefixo.Length;

            txtOrigem = textBoxUserStoryFull.Text;

            string[] subs = txtOrigem.Split('\n');

            txtDestino = "";
            Boolean addDescricao = checkBoxDescricao.Checked;
            Boolean gravarDescricao = false;
            String txtToReplace;

            txtToReplace = "~TEXTO_PARA_TROCAR~";

            foreach (var sub in subs)
            {
                toFind = prefixo;
                found = sub.IndexOf(toFind);

                //Console.WriteLine("{0}\n {1} {2}", sub, toFind, found);

                if (gravarDescricao)
                {
                    txtDestino = txtDestino.Replace(txtToReplace , " - " + sub);
                    gravarDescricao = false;
                }

                if (found >= 0)
                {
                    txtDestino += sub;

                    if (addDescricao)
                    {
                        txtDestino += txtToReplace;
                    }

                    txtDestino += '\n';

                    gravarDescricao = true;
                }
            }

            if (gravarDescricao)
            {
                txtDestino = txtDestino.Replace(txtToReplace, "");
            }

            textBoxUserStoryCode.Text = txtDestino;

            if (txtDestino != "")
            {
                //Clipboard.SetText(textBoxUserStoryCode.Text);
                SetAtivarCopy();
                buttonCopy.Focus();
            }
            else
            {
                SetDesativarCopy();
            }

        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            textBoxUserStoryFull.Text = "";
            textBoxUserStoryFull.Text = Clipboard.GetText();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxUserStoryCode.Text);
        }

        private void SetAtivarCopy()
        {
            buttonCopy.BackColor = Color.LightGreen;
            //textBoxUserStoryCode.BackColor = SystemColors.Window;
            textBoxUserStoryCode.ForeColor = SystemColors.WindowText;
        }

        private void SetDesativarCopy()
        {
            buttonCopy.BackColor = SystemColors.Control;
            //textBoxUserStoryCode.BackColor = SystemColors.Control;
            textBoxUserStoryCode.ForeColor = SystemColors.ControlDarkDark;
            textBoxUserStoryCode.Text = "Nenhuma story com o prefixo [" + comboBoxPrefixo.Text + "] encontrada no texto ao lado.";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CarregarDimensoesDoForm();
            CarregarPrefixos();
            SetDesativarCopy();
        }

        private void CarregarDimensoesDoForm()
        {
            this.Width = Properties.Settings.Default.UltimaLargura;
            this.Height = Properties.Settings.Default.UltimaAltura;
        }

        private void SalvarDimensoesDoForm()
        {
            Properties.Settings.Default.UltimaLargura = this.Width;
            Properties.Settings.Default.UltimaAltura = this.Height;
            Properties.Settings.Default.Save();
        }


        private void CarregarPrefixos()
        {
            String todosPrefixos;

            comboBoxPrefixo.Text = Properties.Settings.Default.PrefixoAtual;

            todosPrefixos = Properties.Settings.Default.Prefixos;

            string[] subs = todosPrefixos.Split('|');

            comboBoxPrefixo.Items.Clear();
            foreach (var sub in subs)
            {
                comboBoxPrefixo.Items.Add(sub);
            }
        }

        private void comboBoxPrefixo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrefixoAtual = comboBoxPrefixo.Text;
            Properties.Settings.Default.Save();

            ParseJiraStories();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarDimensoesDoForm();
        }

        private void checkBoxDescricao_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IncluirDescricao = checkBoxDescricao.Checked;
            Properties.Settings.Default.Save();

            ParseJiraStories();
        }

    }
}
