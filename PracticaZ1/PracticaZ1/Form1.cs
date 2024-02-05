using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaZ1
{
    public partial class Form1 : Form
    {
       // Создали объекты, с которыми дальше взаимодействуем (экземпляры документа и диалогового окна)  )
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public Form1()
        {
            InitializeComponent();
            // Передали на печать метод, в котором указали, откуда берем текст и как он будет выглядеть
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Вызвали диалог печати документа
            dialog.Document = document;
            // Диалог печати.Показать диалог() == Результат диалога.OK значит печатаем
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        // Метод e.Graphics создает заданную текстовую строку в нужном нам формате
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 100, 100);
        }
    }
}
