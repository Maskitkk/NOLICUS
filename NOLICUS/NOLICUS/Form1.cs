using System;

using System.Linq;

using System.Windows.Forms;

namespace NOLICUS
{
    public partial class NOLICUS : Form
    {
        //Задаём буул для определения был ли клик (чтобы чередовать символы)
        
        private bool buttonClicked = false;

        public NOLICUS()
        {
            InitializeComponent();
        }

        private void NOLICUS_Load(object sender, EventArgs e)
        {

        }
  




        //Задаём вывод символа для клика по кнопке
        private void buttonUpLeft_Click(object sender, EventArgs e)
        {

            if (buttonClicked)
            {
                buttonUpLeft.Text = "x";
            }
            else
            {
                buttonUpLeft.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonUpCenter_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonUpCenter.Text = "x";
            }
            else
            {
                buttonUpCenter.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonUpRight_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonUpRight.Text = "x";
            }
            else
            {
                buttonUpRight.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonMidLeft_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonMidLeft.Text = "x";
            }
            else
            {
                buttonMidLeft.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonMidCenter_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonMidCenter.Text = "x";
            }
            else
            {
                buttonMidCenter.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonMidRight_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonMidRight.Text = "x";
            }
            else
            {
                buttonMidRight.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonLowLeft_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonLowLeft.Text = "x";
            }
            else
            {
                buttonLowLeft.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonLowCenter_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonLowCenter.Text = "x";
            }
            else
            {
                buttonLowCenter.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        private void buttonLowRight_Click(object sender, EventArgs e)
        {
            if (buttonClicked)
            {
                buttonLowRight.Text = "x";
            }
            else
            {
                buttonLowRight.Text = "o";
            }
            buttonClicked = !buttonClicked;
            WinCheck();
        }

        //Проверка на победу или ничью

        private bool WinCheck()
        {
            Button[] buttonsToCheck = { buttonUpLeft, buttonUpCenter, buttonUpRight, buttonMidLeft, buttonMidCenter, buttonMidRight, buttonLowLeft, buttonLowCenter, buttonLowRight };

            //Проверка горизонталей
            for (int i = 0; i < 3; i++)
            {
                int StartIndex = i * 3;
                if (buttonsToCheck[StartIndex].Text != "" &&
                    buttonsToCheck[StartIndex].Text == buttonsToCheck[StartIndex + 1].Text &&
                    buttonsToCheck[StartIndex].Text == buttonsToCheck[StartIndex + 2].Text)
                {
                    MessageBox.Show(buttonsToCheck[StartIndex].Text + " победил");
                    Reset();
                    return true;
                }
            }

            //Проверка вертикалей
            for (int i = 0; i < 3; i++)
            {
                if (buttonsToCheck[i].Text != "" &&
                        buttonsToCheck[i].Text == buttonsToCheck[i + 3].Text &&
                        buttonsToCheck[i].Text == buttonsToCheck[i + 6].Text)
                {
                    MessageBox.Show(buttonsToCheck[i].Text + " победил");
                    Reset();
                    return true;

                }
            }

            //Проверка диагоналей

            if (buttonsToCheck[0].Text != "" &&
                buttonsToCheck[0].Text == buttonsToCheck[4].Text &&
                buttonsToCheck[0].Text == buttonsToCheck[8].Text)
            {
                MessageBox.Show(buttonsToCheck[0].Text + " победил");
                Reset();
                return true;
            }
            if (buttonsToCheck[2].Text != "" &&
               buttonsToCheck[2].Text == buttonsToCheck[4].Text &&
               buttonsToCheck[2].Text == buttonsToCheck[6].Text)
            {
                MessageBox.Show(buttonsToCheck[2].Text + " победил");
                Reset();
                return true;
            }

            //Проверка ничьей

            bool allButtonsClicked = true;
            foreach (Button button in buttonsToCheck)
            {
                if (button.Text == "")
                {
                    allButtonsClicked = false;
                    break;
                }
            }
            if (allButtonsClicked)
            {

                MessageBox.Show("Ничья");
                Reset();
                return true;
            }

            return false;

        }

        //Сброс игрового поля
        private void Reset()
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Text = "";
                button.Enabled = true;
            }
                buttonClicked = false;
        }
    

    }

 }
           
        


  

