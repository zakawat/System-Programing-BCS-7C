using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessClient
{
    public partial class Form1 : Form
    {
        // © 2019 - Syed Zakawat - All Rights Reserved

        TcpClient client = new TcpClient();
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        NetworkStream networkStream;
        StreamWriter streamWriter;
        StreamReader streamReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            client.Connect(ipAddress, 10000);
            networkStream = client.GetStream();
            streamWriter = new StreamWriter(networkStream);
            streamReader = new StreamReader(networkStream);
            streamWriter.AutoFlush = true;



            var welcomeMsg = streamReader.ReadLine();
            lblServerWelcomeMessage.Text = welcomeMsg;

            getNewGuessFromServer();

        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {

            var userCommand = textBox1.Text;

            if (userCommand.Equals("newGuess"))
            {
                getNewGuessFromServer();
            }
            else if (isNumber(userCommand))
            {
                streamWriter.WriteLine($"answer_{userCommand}");

                var response = streamReader.ReadLine();
                if (response.StartsWith("correctAnswer"))
                {
                    MessageBox.Show("Huraaa \n\nYour Answer is correct");
                    getNewGuessFromServer();
                }
                else if (response.StartsWith("wrongAnswer_"))
                {
                    var data = response.Split('_')[1] ;
                    MessageBox.Show($"Sorry your answer is wrong\n\nCorrect answer is {data}");
                }
            }
            else if (userCommand.Equals("quit"))
            {
                streamWriter.WriteLine("quit");
                Close();
            }
            else if (userCommand.Equals("score"))
            {
                streamWriter.WriteLine("score");

                var score = streamReader.ReadLine();

                MessageBox.Show($"Your Score is: {score}");

            }
            else
            {
               MessageBox.Show("Invalid Command !!");
            }
        }

        private void getNewGuessFromServer()
        {
            streamWriter.WriteLine("newGuess");

            var serverResponse = streamReader.ReadLine();

            String[] data = serverResponse.Split('_');

            lblGuessQuestion.Text = $"Guess number between {data[0]} and {data[1]}";
        }

        private bool isNumber(String input)
        {
            int aa = 0;
            return int.TryParse(input, out aa);
        }

    }
}
