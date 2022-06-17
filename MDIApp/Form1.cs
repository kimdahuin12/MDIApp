using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //IsMdiContainer = true;  //MDI를 사용할 수 있도록 함(이 폼 안에 다른 폼을 넣을 수 있도록)
        }

        //이벤트 핸들러
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            } while (result == DialogResult.Retry);//DialogResult안에 다양한 상수가 선언돼있음
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomForm customForm = new CustomForm();
            //customForm.MdiParent = this; //Form 안에 customForm을 뛰워줌!
            customForm.Show();//모달리스창()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomForm customForm = new CustomForm();
            //customForm.MdiParent = this; //모달창은 MDI를 사용할 수 없음
            customForm.ShowDialog();//모달창(customForm창이 종료되기전까지 다른 창을 선택할 수 없음)
        }
    }
}
