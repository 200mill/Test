using System.Threading;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(1);
            
            label1.Text = "Clicked"; // �̰� ���� �𸣰ڴµ� ����� �ȵǵ��
            Thread.Sleep(1000); // 1�� ����
            label1.Text = "Ready"; // Label1�� Ready�� ����
            MessageBox.Show("Hello World"); // Hello World��� �޼����� ���� �޼��� �ڽ� ���
            Text = "��"; // ������ ��� ����
            Thread.Sleep(1000); // ���� ����?
            Text = "���"; // ����� ���� ����
        }
    }
}