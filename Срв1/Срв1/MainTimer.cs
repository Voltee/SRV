using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
namespace Срв1
{
    class MainTimer
    {
        
        List<BoxController> boxes = new List<BoxController>();
        List<BoxController> dividedboxes = new List<BoxController>();
        Random rnd = new Random(0);
       public System.Windows.Forms.Timer timer;
        CheckBox chbx;
        Panel panel;

        int moveSpeed = 1;
      public  MainTimer(Panel p,CheckBox ch)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += OnTickTimer;
            panel = p;
            chbx = ch;
            //add boxes
            BoxController b1 = new BoxController("b1", Color.Blue,
                panel,
                new Point(0, 0),
                new Point(0, 0),
                true);
            boxes.Add(b1);

            BoxController b2 = new BoxController("b2",Color.Red,
              panel,
              new Point(250, 250),
              new Point(-1, -1),
              false);
            boxes.Add(b2);

          /*  BoxController b3 = new BoxController("b3", Color.Yellow,
             panel,
             new Point(300, 300),
             new Point(-1, 1),
             false);
            boxes.Add(b3);
            */
        }
     public   void tStart() {
            timer.Start();
        }
     public   void tStop() {
            timer.Stop();
        }

        public void tRestart() {
            boxes.Clear();
            panel.Controls.Clear();
            BoxController b1 = new BoxController(Guid.NewGuid().ToString(), Color.Blue,
               panel,
               new Point(0, 0),
               new Point(0, 0),
               true);
            boxes.Add(b1);

            BoxController b2 = new BoxController(Guid.NewGuid().ToString(), Color.Red,
              panel,
              new Point(250, 250),
              new Point(-1, -1),
              false);
            boxes.Add(b2);

         /*   BoxController b3 = new BoxController(Guid.NewGuid().ToString(), Color.Yellow,
              panel,
              new Point(300, 300),
              new Point(-1, 1),
              false);
            boxes.Add(b3);
            */
        }
        public void rand()
        {
            foreach (BoxController box in boxes)
            {
                Point direction = box.move_directon;
                direction.X = rnd.Next(3) - 1;
                direction.Y = rnd.Next(3) - 1;
                box.move_directon = direction;
                box.move();
            }
        }

        void OnTickTimer(object sender, EventArgs e) {
            foreach (BoxController box in boxes) {
                Point direction = box.move_directon;
                //столкновение с границами поля
                if (Math.Abs(0 - box.bounds.l_down_corner.X) <= 1) direction.X = 1;
                else if (Math.Abs(500 - box.bounds.r_down_corner.X) <= 1) direction.X = -1;
                else if (Math.Abs(0 - box.bounds.l_upper_corner.Y) <= 1) direction.Y = 1;
                else if (Math.Abs(500 - box.bounds.l_down_corner.Y) <= 1) direction.Y = -1;
                
                //столкновение с другими объектами
                else foreach (BoxController other in boxes)
                    {
                        if (box.name != other.name && (Math.Abs(other.bounds.l_down_corner.X - box.bounds.l_down_corner.X) <= other.getSize().Width  &&
                                                       Math.Abs(other.bounds.l_down_corner.Y - box.bounds.l_down_corner.Y) <= other.getSize().Height ))
                        {
                            Console.WriteLine("COLLISION");
                            other.isStopped = false;
                         
                            direction.X = rnd.Next(3) - 1 * moveSpeed;
                            direction.Y = rnd.Next(3) - 1 * moveSpeed;
                            if (chbx.Checked)
                            {

                                for (int i = 0; i < 10; i++) dividedboxes.Add(createBox(box, other, new Size(5, 5)));
                                box.changeSize(new Size(5, 5));
                                other.changeSize(new Size(5, 5));
                                chbx.Checked = false;
                            }
                        }
                    }
                
                box.move_directon = direction;
                box.move();
                
                
            }
            boxes.AddRange(dividedboxes);
            dividedboxes.Clear();
            
        }

        BoxController createBox(BoxController box, BoxController other,Size s) {
            Point direction = box.move_directon;
            BoxController b1 = new BoxController(Guid.NewGuid().ToString(), Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)),
             panel,
             new Point(box.current_location.X + rnd.Next(20) - 10, box.current_location.Y + rnd.Next(20) - 10),
             new Point(direction.X = rnd.Next(3) - 1 * moveSpeed, direction.Y = rnd.Next(3) - 1 * moveSpeed),
             true);
            b1.changeSize(s);
            return b1;
        }
    }


    
}
