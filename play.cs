using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeAStar
{
    public partial class play : UserControl
    {
        public play()
        {
            InitializeComponent();
            initgame();
        }
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        
        private double money = 0;
        private double money2 = 0;
        private int dice_out_sum = 0;
        private int dice_out_sum2 = 0;
        private Boolean pturn = true;
        private int countingr = 1;
        private double per = 0;
        private int verif = 1;
        private void moneyperfive()
        {
            per = per + 0.05;
            double v = money - (money * per);
            money = v;
            money = Math.Round(money);
            money = money - money % 10;
            per = 0;
        }
        private void moneyperten()
        {
            per = per + 0.1;
            double v = money - (money * per);
            money = v;
            money = Math.Round(money);
            money = money - money % 10;
            per = 0;
        }
        private void moneypertwenty()
        {
            per = per + 0.2;
            double v = money - (money * per);
            money = v;
            money = Math.Round(money);
            money = money - money % 10;
            per = 0;
        }
        private void moneyperforty()
        {
            per = per + 0.4;
            double v = money - (money * per);
            money = v;
            money = Math.Round(money);
            money = money - money % 10;
            per = 0;
        }
        private void moneyperfifty()
        {
            per = per + 0.5;
            double v = money - (money * per);
            money = v;
            money = Math.Round(money);
            money = money - money % 10;
            per = 0;
        }
        private void moneyperseventy()
        {
            per = per + 0.7;
            double v = money - (money * per);
            money = v;
            money = Math.Round(money);
            money = money - money % 10;
            per = 0;
        }

        private void visibility()
        {
            p1.Hide();
            p2.Hide();
            p3.Hide();
            p3vg5.Hide();
            p4.Hide();
            p5.Hide();
            p6.Hide();
            p7.Hide();
            p8.Hide();
            p9.Hide();
            p10.Hide();
            p11.Hide();
            p12.Hide();
            p13.Hide();
            p14.Hide();
            p15.Hide();
            p16.Hide();
            p17.Hide();
            p18.Hide();
        }
        private void visibilitytwo()
        {
            b1.Hide();
            b2.Hide();
            b3.Hide();
            b3vg5.Hide();
            b4.Hide();
            b5.Hide();
            b6.Hide();
            b7.Hide();
            b8.Hide();
            b9.Hide();
            b10.Hide();
            b11.Hide();
            b12.Hide();
            b13.Hide();
            b14.Hide();
            b15.Hide();
            b16.Hide();
            b17.Hide();
            b18.Hide();
        }
        private void rdver()
        {
            if (verif == 1)
                label4.Text = "Round 1";
            if (verif == 2)
                label4.Text = "Round 2";
            if (verif == 3)
                label4.Text = "Round 3";
            if (verif == 4)
            {
                label4.Text = "Game Over";
                if (money > money2)
                {
                    MessageBox.Show("Game over. Player 1 won by earning " + money + " dollars.");
                    MessageBox.Show("A new game is starting.");
                } else if (money2 > money)
                {
                    MessageBox.Show("Game over. Player 2 won by earning " + money2 + " dollars.");
                    MessageBox.Show("A new game is starting.");
                } else if (money == money2)
                {
                    MessageBox.Show("Game over. Tie.");
                    MessageBox.Show("A new game is starting.");
                }
                verif = 1;
                initgame();
            }
        }
        private void initgame()
        {
            visibility();
            visibilitytwo();
            p1.Show();
            b1.Show();
            money = 0;
            money2 = 0;
            label1.Text = "Dice: ";
            label2.Text = "Player 1's Money: " + money;
            label3.Text = "Player 2's Money: " + money2;
            label4.Text = "Round 1";
            label5.Text = "Your Turn: Player 1";
            dice_out_sum = 0;
            dice_out_sum2 = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int dice_out = RandomNumber(1, 6);
            int caseSwitch;
            label1.Text = "Dice: " + dice_out;
            if (pturn == true)
            {
                dice_out_sum = dice_out_sum + dice_out;
                if (dice_out_sum > 30)
                {
                    dice_out_sum = dice_out_sum % 10;
                    verif++;
                }
            }
            else
            {
                dice_out_sum2 = dice_out_sum2 + dice_out;
                if (dice_out_sum2 > 30)
                {
                    dice_out_sum2 = dice_out_sum2 % 10;
                    verif++;
                }
            }
            if (pturn == true)
                caseSwitch = dice_out_sum;
            else caseSwitch = dice_out_sum2;

            switch (caseSwitch)
            {
                case 1:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p3.Show();
                        moneypertwenty();
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 3;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b3.Show();
                        moneypertwenty();
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 3;
                        pturn = true;
                    }
                    break;
                case 2:
                    if (pturn = true)
                    {
                        rdver();
                        visibility();
                        p2.Show();
                        money = money + 50;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b2.Show();
                        money2 = money2 + 50;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 3:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p3.Show();
                        dice_out_sum = dice_out_sum + 4;
                        dice_out_sum = dice_out_sum - 3;
                        moneypertwenty();
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b3.Show();
                        dice_out_sum2 = dice_out_sum2 + 4;
                        dice_out_sum2 = dice_out_sum2 - 3;
                        moneypertwenty();
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 4:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p3.Show();
                        moneypertwenty();
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 3;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b3.Show();
                        moneypertwenty();
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 3;
                        pturn = true;
                    }
                    break;
                case 5:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p3vg5.Show();
                        money = money + 100;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b3vg5.Show();
                        money2 = money2 + 100;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 6:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p4.Show();
                        if (money > 10)
                        {
                            money = money - 10;
                            label2.Text = "Player 1's Money: " + money;
                        }
                        else money = 0;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b4.Show();
                        if (money2 > 10)
                        {
                            money2 = money2 - 10;
                            label3.Text = "Player 2's Money: " + money2;
                        }
                        else money2 = 0;
                        pturn = true;
                    }
                        break;
                case 7:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p3.Show();
                        moneypertwenty();
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum - 3;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b3.Show();
                        moneypertwenty();
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 - 3;
                        pturn = true;
                    }
                    break;
                case 8:
                    if (pturn == true)
                    {
                        visibility();
                        p5.Show();
                        moneyperten();
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b5.Show();
                        moneyperten();
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 9:
                    if (pturn == true)
                    {
                        visibility();
                        p8.Show();
                        moneyperforty();
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 4;
                        dice_out_sum = dice_out_sum + 1;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b8.Show();
                        moneyperforty();
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 4;
                        dice_out_sum2 = dice_out_sum2 + 1;
                        pturn = true;
                    }
                    break;
                case 10:
                    if (pturn == true)
                    {
                        visibility();
                        p6.Show();
                        money = money + 10;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b6.Show();
                        money2 = money2 + 10;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 11:
                    if (pturn == true)
                    {
                        visibility();
                        p7.Show();
                        money = money + 1000;
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 1;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b7.Show();
                        money2 = money2 + 1000;
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 1;
                        pturn = true;
                    }
                    break;
                case 12:
                    if (pturn == true)
                    {
                        visibility();
                        p7.Show();
                        money = money + 1000;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b7.Show();
                        money2 = money2 + 1000;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 13:
                    if (pturn == true)
                    {
                        visibility();
                        p8.Show();
                        moneyperforty();
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 1;
                        pturn = false;
                    } else if (pturn == false)
                    {
                        visibilitytwo();
                        b8.Show();
                        moneyperforty();
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 1;
                        pturn = true;
                    }
                    break;
                case 14:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p8.Show();
                        moneyperforty();
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b8.Show();
                        moneyperforty();
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 15:
                    // surprise cards
                    if (pturn == true)
                    {
                        cards();
                        pturn = false;
                    }
                    else if (pturn == false)
                    {
                        cards();
                        pturn = true;
                    }
                        break;
                case 16:
                    // surprise cards
                    if (pturn == true)
                    {
                        cards();
                        dice_out_sum = dice_out_sum - 1;
                        pturn = false;
                    }
                    else if (pturn == false)
                    {
                        cards();
                        dice_out_sum2 = dice_out_sum2 - 1;
                        pturn = true;
                    }
                    break;
                case 17:
                    if (pturn == true)
                    {
                        visibility();
                        p10.Show();
                        money = money + 50;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if (pturn == false)
                    {
                        visibilitytwo();
                        b10.Show();
                        money2 = money2 + 50;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 18:
                    if (pturn == true)
                    {
                        visibility();
                        p11.Show();
                        money = money + 50;
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 1;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b11.Show();
                        money2 = money2 + 50;
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 1;
                        pturn = true;
                    }
                    break;
                case 19:
                    if (pturn == true)
                    {
                        visibility();
                        p11.Show();
                        money = money + 50;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b11.Show();
                        money2 = money2 + 50;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                    break;
                case 20:
                    if (pturn == true)
                    {
                        visibility();
                        p12.Show();
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibility();
                        b12.Show();
                        pturn = true;
                    }
                        break;
                case 21:
                    if (pturn == true)
                    {
                        visibility();
                        p13.Show();
                        money = money + 10;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b13.Show();
                        money2 = money2 + 10;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 22:
                    if (pturn == true)
                    {
                        visibility();
                        p17.Show();
                        moneyperfifty();
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 5;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b17.Show();
                        moneyperfifty();
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 5;
                        pturn = true;
                    }
                        break;
                case 23:
                    if (pturn == true)
                    {
                        visibility();
                        p14.Show();
                        money = money + 100;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b14.Show();
                        money2 = money2 + 100;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 24:
                    if (pturn == true)
                    {
                        visibility();
                        p15.Show();
                        moneyperfive();
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b15.Show();
                        moneyperfive();
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 25:
                    if (pturn == true)
                    {
                        visibility();
                        p16.Show();
                        money = money + 10;
                        label2.Text = "Player 1's Money: " + money;
                        dice_out_sum = dice_out_sum + 1;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b16.Show();
                        money2 = money2 + 10;
                        label3.Text = "Player 2's Money: " + money2;
                        dice_out_sum2 = dice_out_sum2 + 1;
                        pturn = true;
                    }
                        break;
                case 26:
                    if (pturn == true)
                    {
                        visibility();
                        p16.Show();
                        money = money + 10;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b16.Show();
                        money2 = money2 + 10;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 27:
                    if (pturn == true)
                    {
                        visibility();
                        p17.Show();
                        moneyperfifty();
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b17.Show();
                        moneyperfifty();
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 28:
                    if (pturn == true)
                    {
                        rdver();
                        visibility();
                        p1.Show();
                        dice_out_sum = 0;
                        dice_out = 0;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        visibilitytwo();
                        b1.Show();
                        dice_out_sum2 = 0;
                        dice_out = 0;
                        pturn = true;
                    }
                        break;
                case 29:
                    if (pturn == true)
                    {
                        visibility();
                        p18.Show();
                        money = money + 10;
                        label2.Text = "Player 1's Money: " + money;
                        pturn = false;
                    } else if(pturn == false)
                    {
                        visibilitytwo();
                        b18.Show();
                        money2 = money2 + 10;
                        label3.Text = "Player 2's Money: " + money2;
                        pturn = true;
                    }
                        break;
                case 30:
                    if (pturn == true)
                    {
                        rdver();
                        dice_out = 0;
                        if (verif < 3)
                        {
                            visibility();
                            p1.Show();
                        }
                        pturn = false;
                    } else if(pturn == false)
                    {
                        rdver();
                        dice_out = 0;
                        if (verif < 3)
                        {
                            visibilitytwo();
                            b1.Show();
                        }
                        pturn = true;
                    }
                    break;
                default:
                    verif++;
                    rdver();
                    dice_out = 0;
                    break;
            }

        }
        private void cards()
        {
            int card_out = RandomNumber(1, 14);
            if (card_out == 1)
            {
                if (pturn == true)
                {
                    string card1 = "Your GF/BF is a gold digger. -500$";
                    MessageBox.Show(card1);
                    if (money > 500)
                        money = money - 500;
                    else money = 0;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                }
                else
                {
                    string card1 = "Your GF/BF is a gold digger. -500$";
                    MessageBox.Show(card1);
                    if (money2 > 500)
                        money2 = money2 - 500;
                    else money2 = 0;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 2)
            {
                if (pturn == true)
                {
                    string card2 = "You were a special guest last night. You Rock! +2000$";
                    MessageBox.Show(card2);
                    money = money + 2000;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                }
                else
                {
                    string card2 = "You were a special guest last night. You Rock! +2000$";
                    MessageBox.Show(card2);
                    money2 = money2 + 2000;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 3)
            {
                if (pturn == true)
                {
                    string card3 = "You are in a bad mood. Stay here.";
                    MessageBox.Show(card3);
                    visibility();
                    p9.Show();
                    pturn = false;
                }
                else
                {
                    string card3 = "You are in a bad mood. Stay here.";
                    MessageBox.Show(card3);
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 4)
            {
                if (pturn == true)
                {
                    string card4 = "You met The Weeknd! He was up for a drink with you and you could have a huge impact to public soon. Roll the dice again!";
                    MessageBox.Show(card4);
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card4 = "You met The Weeknd! He was up for a drink with you and you could have a huge impact to public soon. Roll the dice again!";
                    MessageBox.Show(card4);
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 5)
            {
                if (pturn == true)
                {
                    string card5 = "Oh no! You had a car crash and you're badly injured. You have to pay all of your money for recovery.";
                    MessageBox.Show(card5);
                    money = 0;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card5 = "Oh no! You had a car crash and you're badly injured. You have to pay all of your money for recovery.";
                    MessageBox.Show(card5);
                    money2 = 0;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 6)
            {
                if (pturn == true)
                {
                    string card6 = "10 more spots forward. I have no story to tell you.";
                    MessageBox.Show(card6);
                    visibility();
                    p16.Show();
                    money = money + 10;
                    label2.Text = "Player 1's Money: " + money;
                    pturn = false;
                } else
                {
                    string card6 = "10 more spots forward. I have no story to tell you.";
                    MessageBox.Show(card6);
                    visibilitytwo();
                    b16.Show();
                    money2 = money2 + 10;
                    label3.Text = "Player 2's Money: " + money2;
                    pturn = true;
                }
            }
            else if (card_out == 7)
            {
                if (pturn == true)
                {
                    int turnv = 0; //counting twice when you have to repeat on taking cards by one single player
                    turnv++;
                    if (turnv == 2)
                    {
                        string card7 = "Take antoher card. This one is broken.";
                        MessageBox.Show(card7);
                        MessageBox.Show("Taking another card...");
                        cards();
                        visibility();
                        p9.Show();
                        pturn = false;
                        turnv = 0;
                    }
                    else if (turnv == 1)
                    {
                        string card7 = "Take antoher card. This one is broken.";
                        MessageBox.Show(card7);
                        MessageBox.Show("Taking another card...");
                        cards();
                        visibility();
                        p9.Show();
                        pturn = true;
                    }
                } else
                {
                    int turnv = 0;
                    turnv++;
                    if (turnv == 2)
                    {
                        string card7 = "Take antoher card. This one is broken.";
                        MessageBox.Show(card7);
                        MessageBox.Show("Taking another card...");
                        cards();
                        visibilitytwo();
                        b9.Show();
                        pturn = true;
                        turnv = 0;
                    }
                    else if (turnv == 1)
                    {
                        string card7 = "Take antoher card. This one is broken.";
                        MessageBox.Show(card7);
                        MessageBox.Show("Taking another card...");
                        cards();
                        visibility();
                        p9.Show();
                        pturn = false;
                    }
                }
            }
            else if (card_out == 8)
            {
                if (pturn == true)
                {
                    int turnv = 0;
                    turnv++;
                    if (turnv == 2)
                    {
                        string card8 = "Your latest single became a hit! 10,000$ and roll the dice again.";
                        MessageBox.Show(card8);
                        money = money + 10000;
                        label2.Text = "Player 1's Money: " + money;
                        visibility();
                        p9.Show();
                        pturn = false;
                        turnv = 0;
                    }
                    else if(turnv == 1)
                    {
                        string card8 = "Your latest single became a hit! 10,000$ and roll the dice again.";
                        MessageBox.Show(card8);
                        money = money + 10000;
                        label2.Text = "Player 1's Money: " + money;
                        visibility();
                        p9.Show();
                        pturn = true;
                    }
                } else
                {
                    int turnv = 0;
                    turnv++;
                    if (turnv == 2)
                    {
                        string card8 = "Your latest single became a hit! 10,000$ and roll the dice again.";
                        MessageBox.Show(card8);
                        money2 = money2 + 10000;
                        label3.Text = "Player 2's Money: " + money2;
                        visibilitytwo();
                        b9.Show();
                        pturn = false;
                        turnv = 0;
                    } else if(turnv == 1)
                    {
                        string card8 = "Your latest single became a hit! 10,000$ and roll the dice again.";
                        MessageBox.Show(card8);
                        money2 = money2 + 10000;
                        label3.Text = "Player 2's Money: " + money2;
                        visibilitytwo();
                        b9.Show();
                        pturn = true;
                    }
                }
            }
            else if (card_out == 9)
            {
                if (pturn == true)
                {
                    string card9 = "You want to collab with a rock band. You don't wanna miss it. -500$";
                    MessageBox.Show(card9);
                    if (money > 500)
                        money = money - 500;
                    else money = 0;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card9 = "You want to collab with a rock band. You don't wanna miss it. -500$";
                    MessageBox.Show(card9);
                    if (money2 > 500)
                        money2 = money2 - 500;
                    else money2 = 0;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 10)
            {
                if (pturn == true)
                {
                    string card10 = "Getting drunk was a bad idea. Pay 50$ for the mess you've made.";
                    MessageBox.Show(card10);
                    if (money > 50)
                        money = money - 50;
                    else money = 0;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card10 = "Getting drunk was a bad idea. Pay 50$ for the mess you've made.";
                    MessageBox.Show(card10);
                    if (money2 > 50)
                        money2 = money2 - 50;
                    else money2 = 0;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 11)
            {
                if (pturn == true)
                {
                    string card11 = "Take that 10$ from me.";
                    MessageBox.Show(card11);
                    money = money + 10;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card11 = "Take that 10$ from me.";
                    MessageBox.Show(card11);
                    money2 = money2 + 10;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 12)
            {
                if (pturn == true)
                {
                    string card12 = "To be honest, you can do better music. 50$ and try better.";
                    MessageBox.Show(card12);
                    money = money + 50;
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card12 = "To be honest, you can do better music. 50$ and try better.";
                    MessageBox.Show(card12);
                    money2 = money2 + 50;
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 13)
            {
                if (pturn = true)
                {
                    string card13 = "Bazinga! Pretty surprising card.";
                    MessageBox.Show(card13);
                    visibility();
                    p9.Show();
                    pturn = false;
                }
                else
                {
                    string card13 = "Bazinga! Pretty surprising card.";
                    MessageBox.Show(card13);
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
            else if (card_out == 14)
            {
                if (pturn == true)
                {
                    string card14 = "Freaking labels, they did it again...Say goodbye to 70% of your money.";
                    MessageBox.Show(card14);
                    if (money == 0) money = 0;
                    else
                        moneyperseventy();
                    label2.Text = "Player 1's Money: " + money;
                    visibility();
                    p9.Show();
                    pturn = false;
                } else
                {
                    string card14 = "Freaking labels, they did it again...Say goodbye to 70% of your money.";
                    MessageBox.Show(card14);
                    if (money2 == 0) money2 = 0;
                    else
                        moneyperseventy();
                    label3.Text = "Player 2's Money: " + money2;
                    visibilitytwo();
                    b9.Show();
                    pturn = true;
                }
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        private void play_Load(object sender, EventArgs e)
        {

        }
    }
}
