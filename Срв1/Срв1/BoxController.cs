using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Срв1
{
    class BoxController
    {
       public struct BOUNDS {
           public Point l_upper_corner, l_down_corner;
           public Point r_upper_corner, r_down_corner;
        }
       public BOUNDS bounds = new BOUNDS();
        public Point current_location, move_directon;
       
        public bool isStopped;
        public string name;
        PictureBox box = new PictureBox();

       public BoxController(string Name,Color color,Panel panel, Point spawnpoint, Point direction,bool isstopped)
        {
            name = Name;
           box.Location = spawnpoint;
            move_directon = direction;
            box.BackColor = color;
            box.Size = new Size(20,20);
            box.Enabled = true;
            panel.Controls.Add(box);
            update();
            isStopped = isstopped;
        }
       
        void update() {

            bounds.l_upper_corner = new Point(box.Location.X, box.Location.Y);
            bounds.l_down_corner = new Point(box.Location.X, box.Location.Y + box.Size.Height );
            bounds.r_upper_corner = new Point(box.Location.X + box.Size.Width, box.Location.Y);
            bounds.r_down_corner = new Point(box.Location.X + box.Size.Width, box.Location.Y + box.Size.Height );

            current_location = new Point(box.Location.X + box.Size.Width/2, box.Location.Y - box.Size.Height/2); ;
        }

    

       public void move() {
            if (!isStopped)
            {
                box.Location = new Point(box.Location.X + move_directon.X , box.Location.Y + move_directon.Y);
                update();
            }
        }

        public void changeSize(Size s) { box.Size = s; }
        public Size getSize() { return box.Size; }
    }
}
