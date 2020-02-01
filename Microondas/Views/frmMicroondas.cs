/*
 ------------------------------------------------------------------------------------------------
                                 BENNER
 ------------------------------------------------------------------------------------------------
 Projeto(s).......: Avaliação - BENNER
 Sistema(s).......: Microondas Digital
 Cliente(s).......: BENNER
 Requisitante(s)..: 
 Gestor(es).......: 
 Desenvolvedor(es): Sergio Jr
 Descrição........: FormMicroondas contendo as regras
 Data.............: 29,30 e 31/01/2020
 Parametrô(s).....: N/A
 -------------------------------------------------------------------------------------------------
 Manutenção.......:
 Requisitante(s)..: 
 Desenvolvedor(es): 
 Descrição........: 
 Data.............: 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microondas.Models;

namespace Microondas
{
    public partial class frmMicroondas : Form
    {
        #region Variaveis
        int segundos = 0, potencia = 0;
        string charAtual = ".";
        bool pausado = true;
        string strMsg = "";
        int intTempo = 0;
        bool arq = false;
        string folder = @"C:\Temp";
        string Caminho = "";

        Thread trdValida;

        List<Programa> listPrograma = new List<Programa>(); 
        #endregion

        #region Construtor
        public frmMicroondas()
        {
            InitializeComponent();

            trdValida = new Thread(new ThreadStart(atualizaInfo));

            listaDados();

            // Carrega lista
            cbbProgramas.DataSource = listPrograma;
            cbbProgramas.DisplayMember = "Nome";
            cbbProgramas.SelectedIndex = -1;

            cbbPotenciaPrograma.Text = "10";
            lblPotLeng.Visible = true;
            lblPotLeng.Text = cbbPotenciaPrograma.Text;

            // Inicia campos bloqueados
            desabCamposCad();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
        } 
        #endregion

        #region Eventos
        // Ações rápidas
        private void btnFrango_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (cbbProgramas.SelectedIndex == -1)
                {
                    lblTimer.Text = "02:00";
                    lblPotLeng.Text = "7";
                    lblCaracter.Text = "F";
                    lblPotLeng.Visible = true;
                    lblCaracter.Visible = true;

                    Thread.Sleep(300);
                    segundos = textoValido(lblTimer.Text);
                    potencia = Convert.ToInt32(lblPotLeng.Text);
                    pausado = false;
                    trdValida.Start();
                }
                else
                {
                    MessageBox.Show("Alimento incompatível com o programa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnSopa_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (cbbProgramas.SelectedIndex == -1)
                {
                    lblTimer.Text = "01:30";
                    lblPotLeng.Text = "6";
                    lblCaracter.Text = "S";
                    lblPotLeng.Visible = true;
                    lblCaracter.Visible = true;

                    Thread.Sleep(300);
                    segundos = textoValido(lblTimer.Text);
                    potencia = Convert.ToInt32(lblPotLeng.Text);
                    pausado = false;
                    trdValida.Start();
                }
                else
                {
                    MessageBox.Show("Alimento incompatível com o programa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnArroz_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (cbbProgramas.SelectedIndex == -1)
                {
                    lblTimer.Text = "01:20";
                    lblPotLeng.Text = "5";
                    lblCaracter.Text = "A";
                    lblPotLeng.Visible = true;
                    lblCaracter.Visible = true;

                    Thread.Sleep(300);
                    segundos = textoValido(lblTimer.Text);
                    potencia = Convert.ToInt32(lblPotLeng.Text);
                    pausado = false;
                    trdValida.Start();
                }
                else
                {
                    MessageBox.Show("Alimento incompatível com o programa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (cbbProgramas.SelectedIndex == -1)
                {
                    lblTimer.Text = "01:10";
                    lblPotLeng.Text = "4";
                    lblCaracter.Text = "C";
                    lblPotLeng.Visible = true;
                    lblCaracter.Visible = true;

                    Thread.Sleep(300);
                    segundos = textoValido(lblTimer.Text);
                    potencia = Convert.ToInt32(lblPotLeng.Text);
                    pausado = false;
                    trdValida.Start();
                }
                else
                {
                    MessageBox.Show("Alimento incompatível com o programa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (cbbProgramas.SelectedIndex == -1)
                    {
                        lblTimer.Text = "01:00";
                        lblPotLeng.Text = "4";
                        lblCaracter.Text = "F";
                        lblPotLeng.Visible = true;
                        lblCaracter.Visible = true;

                        Thread.Sleep(300);
                        segundos = textoValido(lblTimer.Text);
                        potencia = Convert.ToInt32(lblPotLeng.Text);
                        pausado = false;
                        trdValida.Start();
                    }
                    else
                    {
                        MessageBox.Show("Alimento incompatível com o programa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }


        private void btnMaisTrintaSeg_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (!trdValida.IsAlive)
                {
                    lblTimer.Text = "00:30";
                    lblPotLeng.Text = "8";
                    Thread.Sleep(300);
                    segundos = textoValido(lblTimer.Text);
                    potencia = Convert.ToInt32(lblPotLeng.Text);
                    pausado = false;
                    trdValida.Start();
                }
                else
                    pausado = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            try
            {
                trdValida.Abort();
                trdValida = new Thread(new ThreadStart(atualizaInfo));

                if (!trdValida.IsAlive)
                {
                    if(cbbProgramas.SelectedIndex < 0)
                    {
                        string[] tempo = mskTempoPrograma.Text.Split(':');

                        if (string.IsNullOrWhiteSpace(tempo[0]) && string.IsNullOrWhiteSpace(tempo[1]))
                            strMsg += "Informe o Tempo!\n";
                        if (string.IsNullOrWhiteSpace(cbbPotenciaPrograma.SelectedItem.ToString()))
                            strMsg += "Informe a potência!";
                        if (string.IsNullOrEmpty(strMsg))
                        {                            
                            lblPotLeng.Visible = true;
                            lblPotLeng.Text = cbbPotenciaPrograma.Text;
                            aquecimento(mskTempoPrograma.Text, Convert.ToInt32(cbbPotenciaPrograma.Text), ".");
                        }
                        else
                        {
                            MessageBox.Show(strMsg + "" , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (cbbProgramas.SelectedIndex > 0)
                        {
                            lblCaracter.Visible = true;

                            aquecimento(lblTimer.Text, Convert.ToInt32(lblPotLeng.Text), listPrograma.ElementAt(cbbProgramas.SelectedIndex).Carcter.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Alimento incompatível com o programa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                        }
                    }
                    
                }
                else
                    pausado = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ttbNome.Enabled = true;
            ttbInstrucao.Enabled = true;
            ttbInstrucao.Text = "";
            mskTempoCadastro.Enabled = true;
            cbbPotenciaCadastro.Enabled = true;
            ttbCaracterCadastro.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tempo = mskTempoCadastro.Text.Split(':');

                if (string.IsNullOrWhiteSpace(ttbNome.Text))
                    strMsg += "Informe o Nome!\n";
                if (string.IsNullOrWhiteSpace(ttbInstrucao.Text))
                    strMsg += "Informe as Instruções!\n";
                if (string.IsNullOrWhiteSpace(tempo[0]) && string.IsNullOrWhiteSpace(tempo[1]))
                    strMsg += "Informe o Tempo!\n";
                if (string.IsNullOrWhiteSpace(cbbPotenciaCadastro.SelectedItem.ToString()))
                    strMsg += "Informe a Potência!\n";
                if (string.IsNullOrWhiteSpace(ttbCaracterCadastro.Text) && ttbCaracterCadastro.Text.Length != 1)
                    strMsg += "Informe o Caracter!\n";

                if (string.IsNullOrEmpty(strMsg))
                {
                    intTempo = Convert.ToInt32(tempo[1]) + (Convert.ToInt32(tempo[0]) * 60);
                    listPrograma.Add(new Programa(ttbNome.Text, ttbInstrucao.Text, intTempo, Convert.ToInt32(cbbPotenciaCadastro.SelectedItem), Convert.ToChar(ttbCaracterCadastro.Text)));

                    // Salva dados em arquivo novo
                    criarArquivo();
                                        
                    MessageBox.Show("Cadastro salvo com sucesso! \n" + Caminho, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparCamposCad();
                    desabCamposCad();

                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;

                    cbbProgramas.DataSource = new List<Programa>();
                    cbbProgramas.DataSource = listPrograma;
                    cbbProgramas.DisplayMember = "Nome";
                }
                else
                {
                    MessageBox.Show(strMsg + "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void cbbProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbProgramas.SelectedIndex > 0)
                {
                    lblPotLeng.Visible = true;
                    lblCaracter.Visible = true;

                    lblTimer.Text = transfSegHora(listPrograma.ElementAt(cbbProgramas.SelectedIndex).Tempo);
                    lblPotLeng.Text
                        = listPrograma.ElementAt(cbbProgramas.SelectedIndex).Potencia.ToString();

                    lblCaracter.Text = listPrograma.ElementAt(cbbProgramas.SelectedIndex).Carcter.ToString();

                    consultarProgramas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            pausado = !pausado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            trdValida.Abort();
            
            lblTimer.Text = "00:00";
            lblPotLeng.Text = string.Empty;
            ttbInfAquecimento.Text = string.Empty;
            mskTempoPrograma.Text = string.Empty;
            cbbProgramas.SelectedIndex = -1;
            lblCaracter.Visible = false;

            limparCamposCad();
            desabCamposCad();
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            trdValida.Abort();
            trdValida = new Thread(new ThreadStart(atualizaInfo));

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = folder;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    arq = true;

                    var fileString = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileString))
                    {
                        txtArquivo.Text = openFileDialog.FileName;

                        var text = reader.ReadToEnd();

                        string[] verifica = text.Split(' ');

                        lblTimer.Text = transfSegHora(Convert.ToInt32(verifica[0]));
                        lblPotLeng.Text = verifica[1];

                        maskTxtArq.Text = lblTimer.Text;
                        txtPotArq.Text = lblPotLeng.Text;

                        Thread.Sleep(300);
                        segundos = textoValido(lblTimer.Text);
                        potencia = Convert.ToInt32(lblPotLeng.Text);
                        pausado = false;
                        trdValida.Start();
                    }
                }   
            }
        }
        #endregion

        #region Metodos
        // Atualiza tela de tempo
        public void atualizaInfo()
        {
            MethodInvoker update = new MethodInvoker(atualiza);

            while (segundos > 0)
            {
                if (!pausado)
                {
                    Thread.Sleep(1000);
                    segundos--;
                    Invoke(update);
                }
            }
            MessageBox.Show("aquecida!", "Microondas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            trdValida.Abort();
        }

        public void atualiza()
        {
            lblTimer.Text = transfSegHora(segundos);

            for (int i = 0; i < potencia; i++)
                ttbInfAquecimento.Text += charAtual;
        }

        // Lista de programas pré-definidos
        public void listaDados()
        {
            listPrograma.Add(new Programa("", "", 0, 10, '#'));
            listPrograma.Add(new Programa("FRANGO", "Esquente o frango por 2 minutos", 120, 7, 'F'));
            listPrograma.Add(new Programa("SOPA", "Esquente a sopa por 1 minuto e meio", 90, 6, 'S'));
            listPrograma.Add(new Programa("ARROZ", "Esquente o arroz por 1 minuto e vinte", 80, 5, 'A'));
            listPrograma.Add(new Programa("CARNE", "Esquente a carne por 1 minuto e dez", 70, 4, 'C'));
            listPrograma.Add(new Programa("PIPOCA", "Esquente a pipoca por 1 minuto", 60, 10, 'P'));
        }

        public void consultarProgramas()
        {
            ttbNome.Text = listPrograma.ElementAt(cbbProgramas.SelectedIndex).Nome.ToString();
            ttbInstrucao.Text = listPrograma.ElementAt(cbbProgramas.SelectedIndex).Instrucoes.ToString();
            mskTempoCadastro.Text = transfSegHora(listPrograma.ElementAt(cbbProgramas.SelectedIndex).Tempo);
            cbbPotenciaCadastro.Text = listPrograma.ElementAt(cbbProgramas.SelectedIndex).Potencia.ToString();
        }

        public void limparCamposCad()
        {
            ttbNome.Text = string.Empty;
            ttbInstrucao.Text = string.Empty;
            mskTempoCadastro.Text = string.Empty;
            cbbPotenciaCadastro.SelectedIndex = - 1;
            ttbCaracterCadastro.Text = string.Empty;

            txtArquivo.Text = string.Empty;
            maskTxtArq.Text = string.Empty;
            txtPotArq.Text = string.Empty;
        }

        public void desabCamposCad()
        {
            ttbNome.Enabled = false;
            ttbInstrucao.Enabled = false;
            mskTempoCadastro.Enabled = false;
            cbbPotenciaCadastro.Enabled = false;
            ttbCaracterCadastro.Enabled = false;
        }

        private void aquecimento(string tempo, int pot, string strchar)
        {
            segundos = textoValido(tempo);
            if (segundos > 0)
            {
                if (validaTempo(segundos))
                {
                    charAtual = strchar.Replace(strchar,".");
                    potencia = pot;
                    pausado = false;
                    trdValida.Start();
                }
                else
                    btnCancelar.PerformClick();
            }
            else
            {
                MessageBox.Show("Tempo inválido!", "Microondas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnCancelar.PerformClick();
            }
        }

        public int textoValido(string texto)
        {
            try
            {
                // verifica se todos os campos do tempo foram preenchidos
                if (texto.Length > 5)
                    return -1;
                // verifica se está no formato de hora
                if (!texto.Contains(":"))
                    return -2;

                string strMinutos = texto.Substring(0, texto.IndexOf(":"));
                string strSegundos = texto.Substring(texto.IndexOf(":") + 1, texto.Length - (texto.IndexOf(":") + 1));

                if (strMinutos == "" || strSegundos == "")
                    return -3;
                else
                    return Convert.ToInt32(strMinutos) * 60 + Convert.ToInt32(strSegundos);
            }
            catch (Exception)
            {
                return -5;
            }
        }

        private bool validaTempo(int seg)
        {
            if (seg < 1)
            {
                MessageBox.Show("Tempo menor do que o mínimo(1 segundo)!", "Microondas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (seg > 120)
            {
                MessageBox.Show("Tempo maior do que o máximo(2 minutos)!", "Microondas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }       

        // Transforma segundos em horas
        public String transfSegHora(int segundos)
        {
            int horas, minutos;

            String min = "", seg = "";
            horas = segundos / 3600;
            segundos %= 3600;
            minutos = segundos / 60;

            if (minutos < 10)
                min = "0";

            min += minutos.ToString();
            segundos %= 60;

            if (segundos < 10)
                seg = "0";
            seg += segundos.ToString();

            return min + ":" + seg;
        }

        public void criarArquivo()
        {
            // Salva arquivo
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Formata da Data para compor o nome do arquivo
            var dt = DateTime.Now;

            Caminho = folder + "\\" + ttbNome.Text + dt.ToString("_ddMMyyyy_HHmmss") + ".txt";

            // Arquivo novo
            if (!File.Exists(Caminho))
            {
                // Cria Arquivo novo
                StreamWriter sr = File.CreateText(Caminho);
                sr.Close();
            }

            // Abre o arquivo para inserir dados
            using (StreamWriter sw = new StreamWriter(Caminho, true))
            {
                sw.WriteLine(intTempo + " " + cbbPotenciaCadastro.SelectedItem);
                //sw.Close();
            }
        }
        #endregion

    }
}
