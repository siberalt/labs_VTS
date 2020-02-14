using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADPP_CW
{
    public partial class Form1 : Form,ICarListener
    {
        static PictureBox current;
        static Form1 form1;
        public static PictureBox Picture => current;
        public static Form1 Form => form1;
        Graphics2D graphics;
        CarModel model;
        Instructor instructor = new Instructor();
        Car car;
        public Form1()
        {
            InitializeComponent();
            current = pictureBox1;
            form1 = this;
            //DevicePool.Instance.IntitialziePool(new Device[] { new KeyboardSteeringWheel(),
            //                                                   new KeyboardHandbrake(),
            //                                                   new GasPedal(),
            //                                                   new ClutchPedal(),
            //                                                   new BrakePedal(),
            //                                                   new MonitorWindshield(),
            //                                                   new KeyboardEngine()});

            graphics = new Graphics2D(pictureBox1.BackColor);
            model = new CarModel("car.jpg",new Size(120,60),new Point(100,100));
            graphics.AddModel(model);
            CarBuilder builder = new CarBuilder(CarTypes.M_Vas2120);
            builder.Build(graphics,model);
            car = builder.Result;
            car.Enabled = true;
            car.AddHandler(this);
            car.AddHandler(instructor);
            
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.W) model.Move(1, 0);
            //if (e.KeyCode == Keys.Space) model.Rotate(1);
            //if (e.KeyCode == Keys.Y) model.Move(1, 1);
            //if (e.KeyCode == Keys.A) model.RotateWheelVector(1);
            //if (e.KeyCode == Keys.D) model.RotateWheelVector(-1);
            //Form1.Picture.Invalidate();
        }

        public void steeringWheelHandler(object sender, object obj)
        {

        }

        public void gasPedalHandler(object sender, object obj)
        {

        }

        public void clutchPedalHandler(object sender, object obj)
        {
            radioClutch.Checked = ((ClutchPedal)obj).HasPressure;
        }

        public void brakePedalHandler(object sender, object obj)
        {

        }

        public void transmissionHandler(object sender, object obj)
        {
            label1.Text = "Передача: " + (obj as Transmission).CurrentGear;
        }

        public void handbrakeHandler(object sender, object obj)
        {
            radioHanbrake.Checked = (obj as KeyboardHandbrake).Anchored;
        }

        public void engineHandler(object sender, object obj)
        {
            radioEngine.Checked = (obj as KeyboardEngine).HasIngnition;
        }

        private void checkInstructor_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkInstructor.Checked)
            //{
            //    instructor = new Instructor();
            //    //car.AddHandler(instructor);
            //}
            //else
            //{
            //   // car.RemoveHandler(instructor);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                car.AddHandler(instructor);
            else
                car.RemoveHandler(instructor);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Механическая": car.Transmission = new MechanicTransmission(0,5); break;
                case "Автоматическая": car.Transmission = new Device_adapters.AutomaticTransmission(0,5,car.GasPedal); break;
            }
        }
    }
}
