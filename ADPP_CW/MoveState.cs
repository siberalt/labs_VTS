using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    class MoveState : State
    {
        int move = 300;
        int left = 50;
        bool gear = false;
        bool turn = false;
        public MoveState(Instructor instructor):base(instructor)
        {
            if (instructor.Gear != 1)
                MessageBox.Show("Включай первую (1)");
        }
        public override void brakePedalHandler(object sender, object obj)
        {
            
        }

        public override void clutchPedalHandler(object sender, object obj)
        {
            instructor.HasClutch = (obj as ClutchPedal).HasPressure;
        }

        public override void engineHandler(object sender, object obj)
        {
            
        }

        public override void gasPedalHandler(object sender, object obj)
        {
            if (left == 0) MessageBox.Show("Всё приехали. Пересдача через год...");
            if (!gear)
            {
                if (!instructor.HasClutch) { MessageBox.Show("Сцепление выжимай..."); return; }
                if (instructor.Gear != 1) { MessageBox.Show("Включи первую..."); return; }

            }
            else if (move > 0)
            {
                move--;
            }
            else 
            {
                if (!turn)
                {
                    MessageBox.Show("Поворачивай налево (A,D) ");
                    turn = true;
                }
                else left--;
            }     
        }

        public override void handbrakeHandler(object sender, object obj)
        {
            MessageBox.Show("Ну вот щас на ручник встать в движении вообще не хватало");
        }

        public override void steeringWheelHandler(object sender, object obj)
        {
            if(turn)
            {
                if (instructor.Angle > 0) MessageBox.Show("Тебя в школе не учили где право, а где лево? Это вообще то право!");
            }
        }

        public override void transmissionHandler(object sender, object obj)
        {
            if (!instructor.HasClutch) { MessageBox.Show("Сцепление..."); return; }
            instructor.Gear = (obj as Transmission).CurrentGear;
            if(instructor.Gear == 1)
            {
                gear = true;
                MessageBox.Show("Молодец, а теперь газуй (W)");
            }
            else
            {
               if(!gear) MessageBox.Show("Ой да блин не та передача ты Олежа");
            }
        }
    }
}
