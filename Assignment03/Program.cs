using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment03
{
    public class Program : Engine
    {

        public static SlideSprite elephant;


        protected override void OnKeyDown(KeyEventArgs e)
        {
            //base.OnKeyDown(e);
            //Console.WriteLine("asdffasdf");
            if (e.KeyCode == Keys.Left && parent.children.Count > 0) elephant.TargetX -= 30;
            if (e.KeyCode == Keys.Right && parent.children.Count > 0) elephant.TargetX += 30;
            if (e.KeyCode == Keys.Up && parent.children.Count > 0) elephant.TargetY -= 30;
            if (e.KeyCode == Keys.Down && parent.children.Count > 0) elephant.TargetY += 30;
            if (e.KeyCode == Keys.A && parent.children.Count == 0) parent.add(elephant);
            if (e.KeyCode == Keys.D && parent.children.Count > 0) parent.children[0].Kill();
            if (e.ToString().Equals("=") && parent.children.Count > 0) elephant.Velocity+=5;
            if (e.KeyCode == Keys.Subtract && parent.children.Count > 0) elephant.Velocity-=5;
            if (e.KeyCode == Keys.R && parent.children.Count > 0)
            {
                elephant.TargetX = 0;
                elephant.TargetY = 0;
            }
            if (e.KeyCode == Keys.P) jukebox.PlayLooping();
            if (e.KeyCode == Keys.M) jukebox.Stop();
            if (e.KeyCode == Keys.T && parent.children.Count > 0) phwoah.Play();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            elephant = new SlideSprite(Properties.Resources.elephant);
            elephant.TargetX = 100;
            elephant.TargetY = 100;
            elephant.Velocity = 5;
            Application.Run(new Program());
        }
    }
}