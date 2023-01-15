using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Project1
{
    sealed class Level2 : Level, ButtonProperties
    {
        private Button enableBUTTON= new Button();
        private int haslo;
        private Label[] labels = new Label[5];
        private Label[] ex = new Label[5];
        private Random random = new Random();
        private PictureBox pictureBox = new PictureBox();
        private FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        public Level2(Label label1, Label label2, Label label3, Label label4,Label label5,PictureBox pictureBox)
        {
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            this.pictureBox = pictureBox;
        }

        public void forLevel2()
        {
            haslo = random.Next(1, 5);
            switch (haslo)
            {
                case 1:
                    labels[0].Text = "A";
                    labels[1].Text = "R";
                    labels[2].Text = "B";
                    labels[3].Text = "U";
                    labels[4].Text = "Z";
                    break;
                case 2:
                    labels[0].Text = "E";
                    labels[1].Text = "K";
                    labels[2].Text = "R";
                    labels[3].Text = "A";
                    labels[4].Text = "N";
                    break;
                case 3:
                    labels[0].Text = "L";
                    labels[1].Text = "A";
                    labels[2].Text = "M";
                    labels[3].Text = "P";
                    labels[4].Text = "A";
                    break;
                case 4:
                    labels[0].Text = "Z";
                    labels[1].Text = "E";
                    labels[2].Text = "B";
                    labels[3].Text = "R";
                    labels[4].Text = "A";
                    break;
            }
        }
        override public void startingVariableGuess()
        {
            haslo = random.Next(1, 5);
            switch (haslo)
            {
                case 1:
                    labels[0].Text = "O";
                    labels[1].Text = "C";
                    labels[2].Text = "E";
                    labels[3].Text = "N";
                    labels[4].Text = "Y";
                    break;
                case 2:
                    labels[0].Text = "M";
                    labels[1].Text = "I";
                    labels[2].Text = "S";
                    labels[3].Text = "K";
                    labels[4].Text = "A";
                    break;
                case 3:
                    labels[0].Text = "M";
                    labels[1].Text = "A";
                    labels[2].Text = "S";
                    labels[3].Text = "K";
                    labels[4].Text = "A";
                    break;
                case 4:
                    labels[0].Text = "H";
                    labels[1].Text = "I";
                    labels[2].Text = "E";
                    labels[3].Text = "N";
                    labels[4].Text = "A";
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

            }
        }

        override public void buttonClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            displayWrongButtoon(currentButton);
            for (int i = 0; i < 5; i++)
            {
                if (currentButton.Text == labels[i].Text)
                {
                    labels[i].Visible = true;
                    displayButton(currentButton);
                    HangMan.scoreIncrement();
                }
            }
            if (currentButton.Text != labels[0].Text && currentButton.Text != labels[1].Text && currentButton.Text != labels[2].Text && currentButton.Text != labels[3].Text && currentButton.Text != labels[4].Text)
            {
                HangMan.checkCounter();
                HangMan.changeImage(pictureBox);
                HangMan.counterIncrement();
                HangMan.scoreDecrement();
            }
            if (labels[0].Visible == true && labels[1].Visible == true && labels[2].Visible == true && labels[3].Visible == true && labels[4].Visible == true)
            {
                enableBUTTON.Visible = true;
                flowLayoutPanel.Controls.Clear();

            }

        }
       override public void enableButton(Button button,String text,FlowLayoutPanel flowLayoutPanel)
        {
            enableBUTTON = button;
            enableBUTTON.Text = text;
            this.flowLayoutPanel = flowLayoutPanel;
        }


        public void buttonProperties()
        {
            for(int i =0;i<labels.Length;i++)
            {
                labels [i].Visible = false;
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

