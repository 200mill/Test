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
            
            label1.Text = "Clicked"; // 이건 뭔지 모르겠는데 제대로 안되드라
            Thread.Sleep(1000); // 1초 정지
            label1.Text = "Ready"; // Label1을 Ready로 변경
            MessageBox.Show("Hello World"); // Hello World라는 메세지가 박힌 메세지 박스 출력
            Text = "뀨"; // 제목을 뀨로 변경
            Thread.Sleep(1000); // 뭔지 알죠?
            Text = "뀨뀨"; // 제목울 뀨뀨로 변경
        }
    }
}