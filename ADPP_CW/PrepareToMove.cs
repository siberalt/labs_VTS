
using System.Windows.Forms;

namespace ADPP_CW
{
    public class PrepareToMove : State
    {
        public PrepareToMove(Instructor instructor) : base(instructor) { Answer = "Здарова салага! Сегодня я твой инструктор Саня. Начнём... Выжимай сцепление (Q)"; }

        public override void brakePedalHandler(object sender, object obj)
        {
            Answer = "Тормоз щас не к чему. Нам бы поехать для начала. Ну ты тооормоз";
        }

        public override void clutchPedalHandler(object sender, object obj)
        {
            if(instructor.HasClutch && ((ClutchPedal)obj).HasPressure) return;
            instructor.HasClutch = ((ClutchPedal)obj).HasPressure;
            if (instructor.HasClutch && !instructor.HasEngine) Answer = "Отлично! Сцепление есть. Так давай, заводи машину теперь.(E)";
            else Answer = "Ну и чего сцепление отпустил?";
        }

        public override void engineHandler(object sender, object obj)
        {
            instructor.HasEngine = (obj as EngineIgnition).HasIngnition;
            if (instructor.HasEngine)
            {
                if (instructor.HasClutch)
                    Answer = "Хорошо. Теперь давай снимай ручник (H)";
                else
                    Answer = "Да ёмаё. А кто сцепление держать то будет!?";
            }
            else
            {
                Answer = "Зачем двигатель заглушил?";
            }
        }

        public override void gasPedalHandler(object sender, object obj)
        {
            if(!instructor.HasEngine) Answer = "Куда газуешь с выключенным движком?";
        }

        public override void handbrakeHandler(object sender, object obj)
        {
            instructor.HasHandbrake = (obj as Handbrake).Anchored;
            if(!instructor.HasHandbrake)
            {
                if(instructor.HasEngine && instructor.HasClutch)
                {
                    Answer = "Хорошо. Переходим к следующему этапу";
                    instructor.ChangeState(new MoveState(instructor));
                }
                else
                {
                    Answer = "Рано ты за ручник хватаешься! А как же предудущие шаги?";
                }
            }
        }

        public override void steeringWheelHandler(object sender, object obj)
        {
            
        }

        public override void transmissionHandler(object sender, object obj)
        {
            Answer = "Рано ещё передачи дёргать!";
        }
    }
}
