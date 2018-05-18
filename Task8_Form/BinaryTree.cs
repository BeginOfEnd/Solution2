using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task8_Form
{
    public class BinaryTree
    {
        public Node top;          // вершина дерева
        public Node selectNode;   // выделенный узел
        public Bitmap bitmap;     // канва для рисования
        const int step = 50;
        const int dh = 1;
        Graphics g;
        Pen myPen;
        SolidBrush myBrush = (SolidBrush)Brushes.White;
        Font myFont;






        Node q = new Node(null, null, 0, 0, 0);


        public BinaryTree(int VW, int VH)       // конструктор
        {
            top = null;
            bitmap = new Bitmap(VW, VH);
            myFont = new Font("Courier New", 10, FontStyle.Bold);
        }


        void Del(ref Node r)
        {
            if (r.right != null)
                Del(ref r.right);
            else
            {
                q.data = r.data;
                q = r;
                r = r.left;
            }
        }

        public void Delete(int data, ref Node tree)
        {
            if (tree != null)
                if (data < Convert.ToInt32(tree.data))
                    Delete(data, ref tree.left);
                else
                if (data > Convert.ToInt32(tree.data))
                    Delete(data, ref tree.right);
                else
                {
                    q = tree;
                    if (q.right == null)
                        tree = q.left;
                    else
                        if (q.left == null)
                        tree = q.right;
                    else
                        Del(ref q.left);
                }
        }
        public void DeSelect(Node p)               // снятие признака посещения
        {
            if (p != null)
            {
                //p.visit = false;
                DeSelect(p.left);
                p.visit = false;
                DeSelect(p.right);
            }
        }

        public void Delta(Node p, int dx, int dy)  // смещение поддерева
        {
            p.x -= dx; p.y -= dy;
            if (p.left != null)
                Delta(p.left, dx, dy);
            if (p.right != null)
                Delta(p.right, dx, dy);
        }
        public void Insert(ref Node t, int data, int x, int y)  // вставка
        {
            if (t == null)
                t = new Node(null, null, data, x, y);
            else
                if (data < Convert.ToInt32(t.data))
                Insert(ref t.left, data, t.x - step, t.y + dh * step);
            else
                    if (data > Convert.ToInt32(t.data))
                Insert(ref t.right, data, t.x + step, t.y + dh * step);
            else
                t.count++;
        }

        void DrawNode(Node p)               // рисование дерева
        {
            int R = 17;
            if (p.left != null)
                g.DrawLine(myPen, p.x, p.y, p.left.x, p.left.y);
            if (p.right != null)
                g.DrawLine(myPen, p.x, p.y, p.right.x, p.right.y);

            if (p.visit)
                myBrush = (SolidBrush)Brushes.Yellow;
            else
                myBrush = (SolidBrush)Brushes.LightYellow;

            g.FillEllipse(myBrush, p.x - R, p.y - R, 2 * R, 2 * R);
            g.DrawEllipse(myPen, p.x - R, p.y - R, 2 * R, 2 * R);
            string s = Convert.ToString(p.data) + ":" + Convert.ToString(p.count);
            SizeF size = g.MeasureString(s, myFont);
            g.DrawString(s, myFont, Brushes.Black,
                p.x - size.Width / 2,
                p.y - size.Height / 2);

            if (p.left != null)
                DrawNode(p.left);
            if (p.right != null)
                DrawNode(p.right);
        }

        public Node FindMinLeaf(Node node)
        {
            List<Node> Nodes = new List<Node>();
            if (node != null)
            {
                FindMinLeaf(node.left); // обойти левое поддерево
                if (node.left == null && node.right == null)
                    Nodes.Add(node);
            }
            Node min = Nodes[0];
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].data < min.data)
                    min = Nodes[i];
            }
            return min;
        }

        public void Draw()                  // рисование дерева
        {
            using (g = Graphics.FromImage(bitmap))
            {
                Color cl = Color.FromArgb(255, 255, 255);
                g.Clear(cl);
                myPen = Pens.Black;
                if (top != null)
                    DrawNode(top);
            }
        }
    }
    
}
