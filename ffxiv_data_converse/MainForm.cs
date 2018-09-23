using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ffxiv_data_converse
{
    public partial class MainForm : Form
    {
        OpenFileDialog file_Open = new OpenFileDialog();
        SaveFileDialog file_Save = new SaveFileDialog();


        public MainForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (file_Open.ShowDialog() == DialogResult.OK)
            {
                label_OpenFile.Text = file_Open.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(file_Save.ShowDialog() == DialogResult.OK)
            {
                label_SaveFile.Text = file_Save.FileName;
            }
        }

        private void button_StartConversion_Click(object sender, EventArgs e)
        {
            converse();
        }

        private int changeTypeToString(string type, int order)
        {
            if (type == "1" || type == "4")
            {
                if (order == 0 || order == 1)
                    return 2;
                else if (order == 2)
                    return 4;
            }
            else if (type == "2")
            {
                if (order == 0 || order == 1)
                    return 1;
                else if (order == 2)
                    return 2;
            }
                return 0;
        }

        private void converse()
        {
            /*
            레이드 : 1 -> 8인, 24인 구분 불가
            던전 : 2
            길드작전 : 3
            토벌전 : 4
            더 피스트 : 5
            전장 : 6
            초보자의 집 : 8
            딥 던전 : 9
            이벤트 인스턴스 : 11
            전장의 날개 : 12
             */
            if (label_OpenFile.Text == "선택한 파일 이름" || label_SaveFile.Text == "저장할 파일 이름")
            {
                label_Status.Text = "경로 지정 필요";
                return;
            }
            else if (textBox_getID.Text == "" || textBox_getName.Text == "")
            {
                label_Status.Text = "번호 지정 필요";
            }
            else
            {
                label_Status.Text = "변환 중";

                //읽기
                StreamReader reader = new StreamReader(label_OpenFile.Text);
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[Int32.Parse(textBox_getName.Text)-1] != "\"\"")
                    {
                        listA.Add(values[Int32.Parse(textBox_getID.Text) - 1]);
                        listB.Add(values[Int32.Parse(textBox_getName.Text) - 1]);
                        listC.Add(values[Int32.Parse(textBox_getType.Text) - 1]); //getType 텍스트 박스 생성필요
                    }
                }
                reader.Close();

                //쓰기
                StreamWriter writer = new StreamWriter(label_SaveFile.Text);
                if(radioButton_Duty.Checked)
                for (int i= 0; i < listA.Count; i++)
                    {
                        writer.WriteLine("    \"" + listA[i] + "\": {");
                        writer.WriteLine("      \"name\": " + listB[i] + ",");
                        writer.WriteLine("      \"tank\": \"" + changeTypeToString(listC[i], 0) + "\",");
                        writer.WriteLine("      \"healer\": \"" + changeTypeToString(listC[i], 1) + "\",");
                        writer.WriteLine("      \"dps\": \"" + changeTypeToString(listC[i], 2) + "\"");
                        writer.WriteLine("    },");
                    }
                else
                {
                    for (int i = 0; i < listA.Count; i++)
                    {
                        writer.WriteLine("        \"" + listA[i] + "\": " + listB[i] + ",");
                    }
                }
                writer.Close();
                label_Status.Text = "변환 완료";
            }
        }

        private void radioButton_Duty_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_getType.Enabled = true;
            textBox_getID.Text = "11";
            textBox_getName.Text = "5";
        }

        private void radioButton_Fate_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_getType.Text = "";
            textBox_getType.Enabled = false;
            textBox_getID.Text = "1";
            textBox_getName.Text = "28";
        }
    }
}
