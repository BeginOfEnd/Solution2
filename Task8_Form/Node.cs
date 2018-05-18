using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Task8_Form
{
    public class Node
    {
        public int data;// значение ключа
        public Node left;  // ссылка на левое поддерево
        public Node right; // ссылка на правое поддерево

        public int x;
        public int y;
        public bool visit; // признак выделенности узла
        public int count;  // счетчик повторений значений
                           //конструктор
        public Node(Node left, Node right, int data, int x, int y)
        {
            this.left = left;
            this.right = right;
            this.data = data;
            this.x = x;
            this.y = y;
            this.visit = false;
            this.count = 1;
        }
    }
}
