using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.VSC;

                    lblQuestion.Text = "Which visual control is linked to Microsoft on the list?";

                    button1.Text = "LaunchPad";
                    button2.Text = "BitBucket";
                    button3.Text = "Azure DevOps";
                    button4.Text = "GitHub";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.OS;

                    lblQuestion.Text = "Which operation System is compatable with most Smartphones?";

                    button1.Text = "Linux";
                    button2.Text = "Windows";
                    button3.Text = "Android";
                    button4.Text = "MAcOs";

                    correctAnswer = 3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.CD;

                    lblQuestion.Text = "Which computer divice most proggramers reccomend when coding?";

                    button1.Text = "Smartphone";
                    button2.Text = "Tablet";
                    button3.Text = "Desktop";
                    button4.Text = "Laptop";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.IDE;

                    lblQuestion.Text = "Which IDE is mostly used for android applications?";

                    button1.Text = "Android Studio";
                    button2.Text = "Visual Studio";
                    button3.Text = "Netbeans";
                    button4.Text = "Eclipse";

                    correctAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.PL;

                    lblQuestion.Text = "what is the best language for sofrtware development?";

                    button1.Text = "HTML 5";
                    button2.Text = "Phython";
                    button3.Text = "C++";
                    button4.Text = "C#";

                    correctAnswer = 3;

                    break;

            }



        }

    }
}
