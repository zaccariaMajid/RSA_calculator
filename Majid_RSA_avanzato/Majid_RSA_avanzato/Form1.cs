using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  

namespace Majid_RSA_avanzato
{
    public partial class Form1 : Form
    {


        long p = 0;
        long q = 0;
        int ee = 0;
        System.Numerics.BigInteger n = 0;
        System.Numerics.BigInteger o = 0;
        System.Numerics.BigInteger dCalc = 0;
        System.Numerics.BigInteger d = 0;
        StringBuilder crittogramma = new StringBuilder();
        StringBuilder messaggioDecifrato = new StringBuilder();
        string xor;
        string rot;
        string stringaFirma;

        string rotDec;
        string xorDec;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btn_Cif_Click(object sender, EventArgs e)
        {
            string messaggio = txt_messaggio.Text;            
            char[] ò = messaggio.ToCharArray();
            foreach (var t in ò)
            {
                int ascii = (int)t;
                System.Numerics.BigInteger lg = System.Numerics.BigInteger.ModPow(System.Numerics.BigInteger.Parse((ascii).ToString()), ee, n);
                crittogramma.Append((lg).ToString());
                crittogramma.Append('-');
            }
            
            txt_messaggioCif.Text = crittogramma.ToString();
            
        }

        private void btn_Decif_Click(object sender, EventArgs e)
        {
            
            string[] l = crittogramma.ToString().Split('-');
            string[] list = l.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            System.Numerics.BigInteger[] messages = Array.ConvertAll(list, s => System.Numerics.BigInteger.Parse(s));

            foreach (System.Numerics.BigInteger M in messages)
            {
                System.Numerics.BigInteger k = System.Numerics.BigInteger.ModPow(System.Numerics.BigInteger.Parse(M.ToString()), d, n);
                char c = (char)(k);
                messaggioDecifrato.Append(c);

            }

            txt_messaggioDecif.Text = messaggioDecifrato.ToString();

            xor = funzioni.xor(messaggioDecifrato.ToString(), d.ToString());
            txt_xor.Text = xor.ToString();
            rot = funzioni.ROT13(xor);
            
            stringaFirma = rot.ToString();
            txt_rot.Text = stringaFirma;
        }

        private void btn_svuota_Click(object sender, EventArgs e)
        {
            txt_messaggio.Clear();
            txt_messaggioCif.Clear();
            txt_messaggioDecif.Clear();
            crittogramma.Clear();
            messaggioDecifrato.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_genera_Click(object sender, EventArgs e)
        {
            StreamReader mioFile = new StreamReader("numeriPrimi20BIT.txt");

            List<int> numeri = new List<int>();
            int[] ePick = { 3, 17, 65537 };


            while (mioFile.EndOfStream == false)
            {
                int riga = int.Parse(mioFile.ReadLine());
                numeri.Add(riga);
            }
            mioFile.Close();

            var random = new Random();
            var rand = new Random();

            int index1 = random.Next(numeri.Count);
            int index2 = random.Next(numeri.Count);
            int index3 = rand.Next(ePick.Length);

            p = numeri[index1];
            q = numeri[index2];

            n = p * q;
            o = (p - 1) * (q - 1);

            ee = ePick[index3];

            dCalc = funzioni.modinv(ee, o);
            try
            {
                if (dCalc == 0)
                {
                    throw new Exception("Calcolo di D non andato a buon fine");
                }
                else
                {
                    d = dCalc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            var publicKey = Tuple.Create(n, ee);
            var privateKey = Tuple.Create(n, d);

            label1.Text = $"CHIAVE PUBBLICA: " + publicKey;
            label2.Text = $"CHIAVE PRIVATA: " + privateKey;
        }

        private void btn_hsahFirma_Click(object sender, EventArgs e)
        {
            rotDec = funzioni.ROT13(stringaFirma);
            xorDec = funzioni.xor(rotDec,d.ToString());

            txt_firmaDigDec.Text = xorDec.ToString();
        }
    }
}
