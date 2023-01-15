using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    sealed class Level3:Level,ButtonProperties
    {

        private Button enableBUTTON = new Button();
        private Label[] labels = new Label[6];
        private int guess;
        private Label[] ex = new Label[6];
        private Random random = new Random();
        private PictureBox pictureBox = new PictureBox();
        private FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        public Level3(Label label1, Label label2, Label label3, Label label4, Label label5, Label label6, PictureBox pictureBox)
        {
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            this.pictureBox = pictureBox;
        }
        override public void startingVariableGuess()
        {
             guess = random.Next(1, 15);
            switch (guess)
            {
                case 1:
                    labels[0].Text = "K";
                    labels[1].Text = "A";
                    labels[2].Text = "T";
                    labels[3].Text = "A";
                    labels[4].Text = "N";
                    labels[5].Text = "A";
                    break;
                case 2:
                    labels[0].Text = "C";
                    labels[1].Text = "E";
                    labels[2].Text = "B";
                    labels[3].Text = "U";
                    labels[4].Text = "L";
                    labels[5].Text = "A";
                    break;
                case 3:
                    labels[0].Text = "L";
                    labels[1].Text = "U";
                    labels[2].Text = "B";
                    labels[3].Text = "L";
                    labels[4].Text = "I";
                    labels[5].Text = "N";
                    break;
                case 4:
                    labels[0].Text = "W";
                    labels[1].Text = "A";
                    labels[2].Text = "L";
                    labels[3].Text = "U";
                    labels[4].Text = "T";
                    labels[5].Text = "A";
                    break;
                case 5:
                    labels[0].Text = "T";
                    labels[1].Text = "A";
                    labels[2].Text = "C";
                    labels[3].Text = "Z";
                    labels[4].Text = "K";
                    labels[5].Text = "A";
                    break;
                case 6:
                    labels[0].Text = "P";
                    labels[1].Text = "A";
                    labels[2].Text = "L";
                    labels[3].Text = "I";
                    labels[4].Text = "W";
                    labels[5].Text = "O";
                    break;
                case 7:
                    labels[0].Text = "J";
                    labels[1].Text = "A";
                    labels[2].Text = "G";
                    labels[3].Text = "U";
                    labels[4].Text = "A";
                    labels[5].Text = "R";
                    break;
                case 8:
                    labels[0].Text = "L";
                    labels[1].Text = "A";
                    labels[2].Text = "M";
                    labels[3].Text = "P";
                    labels[4].Text = "K";
                    labels[5].Text = "A";
                    break;
                case 9:
                    labels[0].Text = "A";
                    labels[1].Text = "F";
                    labels[2].Text = "R";
                    labels[3].Text = "Y";
                    labels[4].Text = "K";
                    labels[5].Text = "A";
                    break;
                case 10:
                    labels[0].Text = "D";
                    labels[1].Text = "O";
                    labels[2].Text = "L";
                    labels[3].Text = "I";
                    labels[4].Text = "N";
                    labels[5].Text = "A";
                    break;
                case 11:
                    labels[0].Text = "D";
                    labels[1].Text = "R";
                    labels[2].Text = "Z";
                    labels[3].Text = "E";
                    labels[4].Text = "W";
                    labels[5].Text = "O";
                    break;
                case 12:
                    labels[0].Text = "B";
                    labels[1].Text = "R";
                    labels[2].Text = "Z";
                    labels[3].Text = "O";
                    labels[4].Text = "Z";
                    labels[5].Text = "A";
                    break;
                case 13:
                    labels[0].Text = "L";
                    labels[1].Text = "A";
                    labels[2].Text = "P";
                    labels[3].Text = "T";
                    labels[4].Text = "O";
                    labels[5].Text = "P";
                    break;
                case 14:
                    labels[0].Text = "B";
                    labels[1].Text = "A";
                    labels[2].Text = "B";
                    labels[3].Text = "C";
                    labels[4].Text = "I";
                    labels[5].Text = "A";
                    break;
            }
        }
      
        override public void oneButtonVisible()
        {
            Random r = new Random();
            int x = r.Next(1, 5);
            switch (x)
            {
                case 1:
                    labels[0].Visible = true;
                    break;
                case 2:
                    labels[1].Visible = true;
                    break;
                case 3:
                    labels[2].Visible = true;
                    break;
                case 4:
                    labels[3].Visible = true;
                    break;
                case 5:
                    labels[4].Visible = true;
                    break;
                case 6:
                    labels[5].Visible = true;
                    break;
            }
        }

        override public void buttonClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            displayWrongButtoon(currentButton);
            for (int i = 0; i < 6; i++)
            {
                if (currentButton.Text == labels[i].Text)
                {
                    labels[i].Visible = true;
                    displayButton(currentButton);
                    HangMan.scoreIncrement();
                }
            }
            if (currentButton.Text != labels[0].Text && currentButton.Text != labels[1].Text && currentButton.Text != labels[2].Text && currentButton.Text != labels[3].Text && currentButton.Text != labels[4].Text && currentButton.Text != labels[5].Text)
            {
                HangMan.checkCounter();
                HangMan.changeImage(pictureBox);
                HangMan.counterIncrement();
                HangMan.scoreDecrement();
            }
            if (labels[0].Visible == true && labels[1].Visible == true && labels[2].Visible == true && labels[3].Visible == true && labels[4].Visible == true && labels[5].Visible == true)
            {
                enableBUTTON.Visible = true;
                flowLayoutPanel.Controls.Clear();
            }

        }
        override public void enableButton(Button button, String text,FlowLayoutPanel flowLayoutPanel)
        {
            enableBUTTON = button;
            enableBUTTON.Text = text;
            this.flowLayoutPanel = flowLayoutPanel;
        }

        public void buttonProperties()
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = false;
            }
        }
        public void removeButtonKeyboard(FlowLayoutPanel flowLayout1)
        {
            flowLayout1.Controls.Clear();
        }
        override public void labelUnderliner(Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                ex[i] = label[i];
                ex[i].Font = new Font(ex[i].Font.Name, ex[i].Font.SizeInPoints, FontStyle.Underline);
            }
        }
        public override void hintLabel(Label label)
        {

        }
            public override void hintFor2ndLevel(Label label)
        {

        }
    }
}
