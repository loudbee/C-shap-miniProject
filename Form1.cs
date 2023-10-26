using CarProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarProject;

namespace CarProject
{
    public partial class Form1 : Form
    {
        static int result = 55480000 + 5040000;
        public Form1()
        {
            InitializeComponent();
            lb_en_money.Text = string.Format("{0:#,0}", result);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_en_money.Text = string.Format("{0:#,0}", result);
            lb_wd_money.Text = string.Format("{0:#,0}", result);
            lb_color_money.Text = string.Format("{0:#,0}", result);
            lb_pakage_money.Text = string.Format("{0:#,0}", result);
            lb_tire_money.Text = string.Format("{0:#,0}", result);
            lb_indesign_money.Text = string.Format("{0:#,0}", result);
            lb_ganishi_money.Text = string.Format("{0:#,0}", result);
            lb_papul_money.Text = string.Format("{0:#,0}", result);
            lb_choice_money.Text = string.Format("{0:#,0}", result);

            if (tabControl1.SelectedIndex == 9)
            {
                if (rb_white.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190018.jpg");
                }
                else if (rb_gray.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190110.jpg");
                }
                else if (rb_silver.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190049.jpg");
                }
                else if (rb_black.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190129.jpg");
                }
                else if (rb_blue.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190200.jpg");
                }
                else if (rb_red.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190220.jpg");
                }
                else if (rb_green.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190239.jpg");
                }
                else if (rb_realblue.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190300.jpg");
                }
                else if (rb_nowhite.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190319.jpg");
                }
                else if (rb_nosilver.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190336.jpg");
                }
                else if (rb_nogray.Checked && rb_pakage.Checked)
                {
                    pb_see.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\미리보기\\화면 캡처 2023-07-27 190352.jpg");
                }
                else
                {
                    MessageBox.Show("다시 체크해주세요");
                }
            }
        }

        private void btn_next1_Click(object sender, EventArgs e)     //다음버튼
        {
            tabControl1.SelectedIndex += 1;      //클릭시 다음페이지 구동장치로 넘어감
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)     //첫번째 페이지면 이전 안되게 만듬
            {
                MessageBox.Show("첫번째 페이지 입니다.");
            }
        }

        private void rb2_5T_CheckedChanged(object sender, EventArgs e)      //2.5엔진 선택시
        {
            string[] str2 = lb_3_5money.Text.Split(" ");        // 3.5 돈 변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb2_5T.Checked)     //총돈 - 3.5돈
            {
                result -= result2;
                lb_en_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            pb_engine.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\엔진\\화면 캡처 2023-07-25 174300.jpg"); //2.5사진불러오기
            pb_endata.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\엔진\\화면 캡처 2023-07-26 171405.jpg"); //2.5엔진정보사진
        }

        private void rb_3_5T_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_3_5money.Text.Split(" ");        //3.5돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_3_5T.Checked)
            {
                result += result2;      //체크되면 총돈에 추가
                lb_en_money.Text = string.Format("{0:#,0}", result);       //총돈에 추가
            }

            pb_engine.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\엔진\\화면 캡처 2023-07-25 174309.jpg"); //3.5 엔진사진
            pb_endata.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\엔진\\화면 캡처 2023-07-26 171348.jpg"); //3.5 엔진정보사진
        }

        private void rb_2wd_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_4wd_money.Text.Split(" ");        // 4wd 돈 변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_2wd.Checked)     //총돈 - 2wd돈
            {
                result -= result2;
                lb_wd_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_wd.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\구동\\화면 캡처 2023-07-25 175154.jpg"); //2wd구동장치사진
            pb_wd_cumu.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\구동\\화면 캡처 2023-07-26 183402.jpg");//2wd설명사진
        }

        private void rb_4wd_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_4wd_money.Text.Split(" ");        //4wd 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_4wd.Checked)
            {
                result += result2;      //체크되면 총돈에 추가
                lb_wd_money.Text = string.Format("{0:#,0}", result);       //총돈에 추가
            }

            pb_wd.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\구동\\화면 캡처 2023-07-25 175202.jpg"); //4wd구동장치사진
            pb_wd_cumu.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\구동\\화면 캡처 2023-07-26 183416.jpg");//4wd설명사진
        }

        private void btn_next2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;      //클릭시 다음페이지 색깔로 넘어감
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;      //클릭시 이전페이지 구동장치로 넘어감
        }

        private void btn_next3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;      //클릭시 스포츠 패키지로 넘어감
        }

        private void btn_back3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;      //클릭시 구동장치로 넘어감
        }

        private void rb_white_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_white.Checked)     //흰색 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "우유니 화이트 [UYH]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175240.jpg"); //흰색사진
        }

        private void rb_silver_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_silver.Checked)     //실버 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "세빈실버 [SSS]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175249.jpg"); //실버사진
        }

        private void rb_gray_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_gray.Checked)     //그레이 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "마칼루 그레이 [NCM]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔 
            }
            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175258.jpg"); //그레이사진
        }

        private void rb_black_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_black.Checked)     //블랙 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "마비크 블랙 [PH3]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175309.jpg"); //블랙사진
        }

        private void rb_blue_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_blue.Checked)     //블루 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "태즈먼 블루 [URA]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175318.jpg"); //블루사진
        }

        private void rb_red_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_red.Checked)     //빨강 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "캐번디시 레드 [RLA]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔    
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175326.jpg"); //블루사진
        }

        private void rb_green_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_green.Checked)     //빨강 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "한라산 그린 [MDY]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔    
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175334.jpg"); //빨강사진
        }

        private void rb_realblue_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_glosy_money.Text.Split(" ");        // 유광 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_realblue.Checked)     //찐블루 체크
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "카프리 블루 [NRB]";        //색깔 이름 보여줌
                lb_mat.Text = "";       //무광색깔 
            }
            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\유광\\화면 캡처 2023-07-25 175342.jpg"); //찐블루사진
        }

        private void rb_nowhite_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_mat_money.Text.Split(" ");        //무광 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);

            if (rb_nowhite.Checked)
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "";        //유광색깔 이름 보여줌
                lb_mat.Text = "베르비에 화이트 [NA3]";       //무광색깔 
            }
            else
            {
                result -= result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "";        //유광색깔 이름 보여줌
                lb_mat.Text = "베르비에 화이트 [NA3]";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\무광\\화면 캡처 2023-07-25 175350.jpg"); //무광흰색사진
        }

        private void rb_nosilver_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_mat_money.Text.Split(" ");        //무광 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);

            if (rb_nosilver.Checked)
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "";        //유광색깔 이름 보여줌
                lb_mat.Text = "본드 실버 [SMT]";       //무광색깔 
            }
            else
            {
                result -= result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "";        //유광색깔 이름 보여줌
                lb_mat.Text = "본드 실버 [SMT]";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\무광\\화면 캡처 2023-07-25 175359.jpg"); //무광실버사진
        }

        private void rb_nogray_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_mat_money.Text.Split(" ");        //무광 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);

            if (rb_nogray.Checked)
            {
                result += result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "";        //유광색깔 이름 보여줌
                lb_mat.Text = "마칼루 그레이 [MPE]";       //무광색깔 
            }
            else
            {
                result -= result2;
                lb_color_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_glosy.Text = "";        //유광색깔 이름 보여줌
                lb_mat.Text = "마칼루 그레이 [MPE]";       //무광색깔 
            }

            pb_color.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\색깔\\무광\\화면 캡처 2023-07-25 175405.jpg"); //무광실버사진
        }

        private void btn_next4_Click(object sender, EventArgs e)
        {
            if (rb_pakage.Checked)
            {
                tabControl1.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show("패키지를 선택해주세요");        //패키지 선택안하면 못넘어감
            }
        }

        private void btn_back4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void rb_pakage_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_pakage.Text.Split(" ");        //스포츠패키지 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_pakage.Checked)
            {
                result += result2;
                lb_pakage_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
        }

        private void btn_next5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void btn_back5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void rb_tire19_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_tire20.Text.Split(" ");        //20인치타이어 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);

            if (rb_tire19.Checked)
            {
                result -= result2;      //체크되면 총돈에 추가
                lb_tire_money.Text = string.Format("{0:#,0}", result);       //총돈에 추가
            }

            pb_tire.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\휠\\화면 캡처 2023-07-27 121214.jpg"); //19인치휠사진
        }

        private void rb_tire20_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_tire20.Text.Split(" ");        //20인지타이어 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);

            if (rb_tire20.Checked)
            {
                result += result2;      //체크되면 총돈에 추가
                lb_tire_money.Text = string.Format("{0:#,0}", result);       //총돈에 추가
            }

            pb_tire.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\휠\\화면 캡처 2023-07-27 121222.jpg"); //20인치휠사진
        }

        private void btn_next6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void btn_back6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void rb_inred1_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_in_std.Text.Split(" ");        // 기본 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_inred1.Checked)     //기본 빨강시트 체크
            {
                result += result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "옵시디언 블랙 모노톤 (레드 스티치)";        //디자인 이름색깔 보여줌
                lb_sport.Text = "";       //스포츠형디자인 이름색깔보여줌
            }

            pb_incolor.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장디자인\\화면 캡처 2023-07-25 175522.jpg"); //빨강시트사진
            lb_intext.Text = "블랙 원톤의 인테리어에 고채도 레드 스티치, 크래쉬패드와 도어 트림에 " +
                "\r\n블랙키쉬 리얼 알루미늄 내장재, " +
                "\r\n센터콘솔에는 블랙 하이그로시가 적용되어 스피드함을 연상시킵니다. " +
                "\r\n퀼팅이 포함된 천연 가죽 시트가 더욱 강렬한 인상을 주며, " +
                "\r\n스티어링 휠 혼 커버에는 프라임 나파 가죽 내장재가 적용되어 있습니다. " +
                "\r\n※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ////////////////////////////////////////////////////////////////////////////설명글
        }

        private void rb_ingray_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_in_std.Text.Split(" ");        // 기본 돈 없음 추가해도 변화 없음
            int result2 = int.Parse(str2[1]);

            if (rb_ingray.Checked)     //기본 그레이시트 체크
            {
                result += result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "옵시디언 블랙 모노톤 (그레이 스티치)";        //디자인 이름색깔 보여줌
                lb_sport.Text = "";       //스포츠형디자인 이름색깔보여줌
            }

            pb_incolor.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장디자인\\화면 캡처 2023-07-25 175531.jpg"); //그레이시트사진
            lb_intext.Text = "블랙 원톤의 인테리어에 그레이 스티치, \n" +
                "크래쉬패드와 도어 트림에 블랙키쉬 리얼 알루미늄 내장재, \n" +
                "센터콘솔에는 블랙 하이그로시가 만나 경쾌함을 만듭니다. \n" +
                "퀼팅이 포함된 천연 가죽 시트가 더욱 강렬한 인상을 주며, \n" +
                "스티어링 휠 혼 커버에는 프라임 나파 가죽 내장재가 적용되어 있습니다. \n" +
                "※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ///////////////////////////////////////////////////////////////////////////////설명글
        }

        private void rb_inred2_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_insport.Text.Split(" ");        //스포츠시트 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_inred2.Checked)
            {
                result += result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "";        //디자인 이름 보여줌
                lb_sport.Text = "옵시디언 블랙 모노톤 (레드 스티치)";       //스포츠형 디자인 이름 
            }
            else
            {
                result -= result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "";        //디자인 이름 보여줌
                lb_sport.Text = "옵시디언 블랙 모노톤 (레드 스티치)";       //스포츠형 디자인 이름
            }
            pb_incolor.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장디자인\\화면 캡처 2023-07-25 175539.jpg"); //스포츠형레드시트사진
            lb_intext.Text = "퀼팅과 파이핑이 적용된 블랙 원톤의 프라임 나파 가죽 시트에 \n" +
                "고채도 레드 스티치가 더해져 스피드함을 연상시킵니다. \n" +
                "자카드 리얼 카본 또는 실버 하이브리드 위빙 내장재(크래쉬패드, 센터콘솔, 도어 트림)와 \n" +
                "고급스러운 스웨이드 내장재(헤드라이닝, 필라 트림 등),\n" +
                "인조 실크 카매트가 적용된 디자인 패키지입니다. \n" +
                "센터콘솔 암레스트, 스티어링 휠 혼 커버에는 프라임 나파 가죽 내장재가, \n" +
                "크래쉬패드 및 도어 센터트림에는 인조 가죽 내장재가 적용되어 있습니다. \n" +
                "※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ///////////////////////////////////////////////////////////////////////////////설명
        }

        private void rb_inblre_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_insport.Text.Split(" ");        //스포츠시트 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_inblre.Checked)
            {
                result += result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "";        //디자인 이름 보여줌
                lb_sport.Text = "옵시디언 블랙 / 세비야 레드 투톤";       //스포츠형 디자인 이름 
            }
            else
            {
                result -= result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "";        //디자인 이름 보여줌
                lb_sport.Text = "옵시디언 블랙 / 세비야 레드 투톤";       //스포츠형 디자인 이름
            }

            pb_incolor.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장디자인\\화면 캡처 2023-07-25 175546.jpg"); //스포츠형레드블랙시트사진
            lb_intext.Text = "퀼팅과 파이핑이 적용된 블랙과 레드 투톤 인테리어에 \n" +
                "자카드 리얼 카본 또는 실버 \n" +
                "하이브리드 위빙 내장재(크래쉬패드, 센터콘솔, 도어 트림)가 어우러져 강렬한 인상을 줍니다. \n" +
                "고급스러운 스웨이드 내장재(헤드라이닝, 필라 트림 등), \n" +
                "인조 실크 카매트가 적용된 디자인 패키지입니다. \n" +
                "센터콘솔 암레스트, 스티어링 휠 혼 커버에는 프라임 나파 가죽 내장재가, \n" +
                "크래쉬패드 및 도어 센터트림에는 인조 가죽 내장재가 적용되어 있습니다. \n" +
                "※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ///////////////////////////////////////////////////////////////////////////////설명
        }

        private void rb_ingrba_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_insport.Text.Split(" ");        //스포츠시트 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_ingrba.Checked)
            {
                result += result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "";        //디자인 이름 보여줌
                lb_sport.Text = "안트라사이트 그레이 / 바닐라 베이지 투톤";       //스포츠형 디자인 이름 
            }
            else
            {
                result -= result2;
                lb_indesign_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_standard.Text = "";        //디자인 이름 보여줌
                lb_sport.Text = "안트라사이트 그레이 / 바닐라 베이지 투톤";       //스포츠형 디자인 이름
            }

            pb_incolor.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장디자인\\화면 캡처 2023-07-25 175553.jpg"); //스포츠형그레이베이지시트사진
            lb_intext.Text = "퀼팅과 파이핑이 적용된 그레이와 바닐라 베이지 투톤 인테리어에 \n" +
                "자카드 리얼 카본 또는 실버 \n" +
                "하이브리드 위빙 내장재(크래쉬패드, 센터콘솔, 도어 트림)가 만나 경쾌함을 만듭니다. \n" +
                "고급스러운 스웨이드 내장재(헤드라이닝, 필라 트림 등), \n" +
                "인조 실크 카매트가 적용된 디자인 패키지입니다. \n" +
                "센터콘솔 암레스트, 스티어링 휠 혼 커버에는 프라임 나파 가죽 내장재가, \n" +
                "크래쉬패드 및 도어 센터트림에는 인조 가죽 내장재가 적용되어 있습니다. \n" +
                "※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ///////////////////////////////////////////////////////////////////////////////설명
        }

        private void btn_next7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void btn_back7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void rb_ganish_cabon_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ganish_cabon.Checked)     //기본 가니쉬 선택
            {
                lb_ganishi_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_ganishi_text.Text = "자카드 리얼 카본 (스포츠 디자인 셀렉션)";        //가니쉬 모양 설명
            }
            pb_ganishi.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장 가니쉬\\가니쉬\\화면 캡처 2023-07-25 175612.jpg");   //가니쉬사진
            lb_ganishi.Text = "자카드 조직의 리얼 카본이 적용된 스포츠 전용 내장재로 \n" +
                "섬세하면서도 단단하며 고급스러움을 느낄 수 있습니다. \n" +
                "※ 뒷좌석 암레스트 센터콘솔에 리얼 카본 또는 하이브리드 위빙 가니쉬가 적용됩니다. \n" +
                "(단, 파퓰러 패키지 또는 2열 컴포트 패키지Ⅰ 미적용 시 블랙 하이그로시 가니쉬 적용) \n" +
                "※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ///////////////////////////////////////가니쉬 설명
        }

        private void rd_ganish_silver_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ganish_silver.Checked)     //기본 가니쉬 선택
            {
                lb_ganishi_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_ganishi_text.Text = "실버 하이브리드 위빙 (스포츠 디자인 셀렉션)";        //가니쉬 모양 설명
            }
            pb_ganishi.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\내장 가니쉬\\가니쉬\\화면 캡처 2023-07-25 175621.jpg"); //가니쉬사진
            lb_ganishi.Text = "폴리에스터와 실버 컬러의 실로 직조하여 \n" +
                "실버의 반짝이는 금속감이 매력적인 스포츠 전용 내장재이며, \n" +
                "지-매트릭스(G-Matrix)를 형상화하여 세련된 조형미를 느낄 수 있습니다. \n" +
                "※ 뒷좌석 암레스트 센터콘솔에 리얼 카본 또는 하이브리드 위빙 가니쉬가 적용됩니다. \n" +
                "(단, 파퓰러 패키지 또는 2열 컴포트 패키지Ⅰ 미적용 시 블랙 하이그로시 가니쉬 적용)\n" +
                " ※ 해당 이미지는 풀옵션 기준 대표 이미지 컷입니다.";
            ///////////////////////////////////가니쉬 설명
        }

        private void btn_next8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void btn_back8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void rb_papul_CheckedChanged(object sender, EventArgs e)
        {
            rb_com2.Enabled = false;
            rb_duo.Enabled = false;
            rb_head.Checked = true;

            string[] str2 = lb_papul.Text.Split(" ");        //퍼풀러 기본 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_papul.Checked)
            {
                result += result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
            else
            {
                result -= result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
        }

        private void rb_papulcom_CheckedChanged(object sender, EventArgs e)
        {
            rb_com2.Enabled = true;
            rb_duo.Enabled = false;
            rb_head.Checked = true;

            string[] str2 = lb_papulcom.Text.Split(" ");        //퍼풀러뒷좌석 기본 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_papulcom.Checked)
            {
                result += result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
            else
            {
                result -= result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
        }

        private void rb_papulduo_CheckedChanged(object sender, EventArgs e)
        {
            rb_com2.Enabled = false;
            rb_duo.Enabled = true;
            rb_head.Checked = true;

            string[] str2 = lb_papulduo.Text.Split(" ");        //퍼풀러뒷좌석 기본 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_papulduo.Checked)
            {
                result += result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
            else
            {
                result -= result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
        }

        private void rb_papulcomdou_CheckedChanged(object sender, EventArgs e)
        {
            rb_com2.Enabled = true;
            rb_duo.Enabled = true;
            rb_head.Checked = true;

            string[] str2 = lb_papulcomduo.Text.Split(" ");        //퍼풀러뒷좌석컴포즈 기본 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);

            if (rb_papulcomdou.Checked)
            {
                result += result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
            else
            {
                result -= result2;
                lb_papul_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
        }

        private void rb_head_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_head.Checked)        //헤드업디스플레이 설명
            {
                pb_papul.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\퍼플러패키지\\화면 캡처 2023-07-27 171827.jpg");
                lb_papultext.Text = "더욱 안전하고 편안한 주행을 위해 필수 정보를 운전자의 눈높이에 맞춰 표시합니다. \n" +
                    "스마트 크루즈 컨트롤, 과속단속 카메라 감지, 차로 이탈방지 보조 등을 \n" +
                    "헤드업 디스플레이에 적용하여 주행 편의성을 향상시켰습니다.";
            }
        }

        private void rb_high_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_high.Checked)        //하이테크설명
            {
                pb_papul.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\퍼플러패키지\\화면 캡처 2023-07-27 171841.jpg");
                lb_papultext.Text = "운전자의 안전과 편의를 위한 12.3인치 3D 클러스터, \n" +
                    "전방 주시 경고와 지능형 헤드 램프를 포함한 옵션 패키지입니다.";
            }
        }

        private void rb_drive_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_drive.Checked)       //드라이빙어시스턴스 설명
            {
                pb_papul.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\퍼플러패키지\\화면 캡처 2023-07-27 171849.jpg");
                lb_papultext.Text = "안전하고 편안한 주/출차를 지원하며 \n" +
                    "증강 현실 내비게이션을 통해 직관적인 길 안내를 제공합니다. \n" +
                    "이 패키지에는 서라운드 뷰 모니터, 증강현실 내비게이션, 후측방 모니터, \n" +
                    "원격 스마트 주차 보조, 후방 주차 충돌방지 보조가 포함됩니다.";
            }
        }

        private void rb_com1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_com1.Checked)        //컴포즈패키지1설명
            {
                pb_papul.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\퍼플러패키지\\화면 캡처 2023-07-27 171857.jpg");
                lb_papultext.Text = "뒷좌석 수동식 도어 커튼, 뒷면 전동식 커튼, \n" +
                    "3존 공조(2열 LCD 공조 조절장치 포함), \n" +
                    "뒷좌석 다기능 암레스트가 포함되어 있습니다.";
            }
        }

        private void rb_com2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_com2.Checked)        //컴포즈패키지2설명
            {
                pb_papul.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\퍼플러패키지\\화면 캡처 2023-07-27 171904.jpg");
                lb_papultext.Text = "뒷좌석 승객을 배려한 뒷좌석 전동 및 통풍 & 열선 시트, \n" +
                    "뒷좌석 목베개, 뒷좌석 무선 충전 & 다기능 암레스트, \n" +
                    "뒷좌석 화장거울이 포함되어 있습니다.";
            }
        }

        private void rb_duo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_duo.Checked)     //뒷좌석듀얼모니터설명
            {
                pb_papul.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\퍼플러패키지\\화면 캡처 2023-07-27 171911.jpg");
                lb_papultext.Text = "뒷좌석에는 다양한 콘텐츠들을 편안하게 사용할 수 있는 \n" +
                    "9.2인치 대화면 광시야각의 듀얼 모니터가 적용되어 있습니다. \n" +
                    "좌/우 독립적으로 사용이 가능하여 뒷좌석 승객 각자의 취향에 맞는 콘텐츠를 즐길 수 있습니다. \n" +
                    "터치스크린 방식으로 조작할 수 있어 더욱 편리하며, \n" +
                    "시트백 기울기에 따라 모니터의 각도 조절이 가능합니다.";
            }
        }

        private void btn_next9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 1;
        }

        private void btn_back9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void cb_pano_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_pano.Text.Split(" ");        //파노라마선루프 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);
            if (cb_pano.Checked)
            {
                result += result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            else
            {
                result -= result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_choice.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\선택품목\\화면 캡처 2023-07-25 180308.jpg");
            lb_choice.Text = "탁 트인 개방감을 선사하여 채광과 환기 효과를 더하며, 드라이브의 즐거움을 더합니다.";
        }

        private void cb_conbi_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_conbi.Text.Split(" ");        //컨비니언스 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);
            if (cb_conbi.Checked)
            {
                result += result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            else
            {
                result -= result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_choice.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\선택품목\\화면 캡처 2023-07-25 180318.jpg");
            lb_choice.Text = "7개의 공기주머니를 시트 내부에 적용해 주행 모드별 최적의 운전 자세를 잡아주고, \n" +
                "체형에 맞는 시트 설정으로 편안한 착좌감을 제공합니다. \n" +
                "운전석 시트는 독일 허리건강협회(AGR)로부터 최고 수준의 편안함을 인정받았습니다.";
        }

        private void cb_dras_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_dras.Text.Split(" ");        //드라이빙어시스턴스 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);
            if (cb_dras.Checked)
            {
                result += result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            else
            {
                result -= result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_choice.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\선택품목\\화면 캡처 2023-07-25 180250.jpg");
            lb_choice.Text = "차량의 전/후/측면에 장착된 HD급 카메라가 \n" +
                "기존 서라운드뷰 모니터 대비 탑뷰/후방뷰 등 \n" +
                "다양한 각도의 화면을 보여주어 보다 안전한 주/출차를 보조합니다. \n" +
                "또한 14.5인치의 와이드한 화면에 전방 카메라를 활용한 \n" +
                "증강현실 내비게이션 적용으로 길 안내 직관성 및 편의성을 향상시켰습니다.";
        }

        private void cb_sound_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_sound.Text.Split(" ");        //렉시콘사운드 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1] + result_str2[2]);
            if (cb_sound.Checked)
            {
                result += result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            else
            {
                result -= result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_choice.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\선택품목\\화면 캡처 2023-07-25 180259.jpg");
            lb_choice.Text = "18 스피커 시스템을 통해 \n" +
                "다이내믹하고 왜곡 없는 명료한 사운드를 감상할 수 있으며, \n" +
                "퀀텀로직 서라운드를 적용하여 보다 입체감 있는 사운드를 제공합니다.";
        }

        private void cb_built_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_built.Text.Split(" ");        //빌트인캠 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);
            if (cb_built.Checked)
            {
                result += result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            else
            {
                result -= result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_choice.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\선택품목\\화면 캡처 2023-07-25 180336.jpg");
            lb_choice.Text = "차량의 트림을 제거할 필요 없이 \n" +
                "빌트인 적용된 주행 중 영상기록장치로, \n" +
                "AVN 화면을 통해 영상을 바로 확인할 수 있을 뿐만 아니라 \n" +
                "스마트폰 앱 연동을 통해 영상 확인 및 SNS 공유가 가능합니다.";
        }

        private void cb_cover_CheckedChanged(object sender, EventArgs e)
        {
            string[] str2 = lb_cover.Text.Split(" ");        //빌트인캠 돈변환
            string[] result_str2 = str2[1].Split(",");
            int result2 = int.Parse(result_str2[0] + result_str2[1]);
            if (cb_cover.Checked)
            {
                result += result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }
            else
            {
                result -= result2;
                lb_choice_money.Text = string.Format("{0:#,0}", result);   //총돈에 추가
            }

            pb_choice.Load("C:\\LeeDongUk\\C#\\CarProject\\bin\\개프용 사진들\\선택품목\\화면 캡처 2023-07-25 180344.jpg");
            lb_choice.Text = "카라이프 중 손상되기 쉬운 \n" +
                "프론트 & 리어 범퍼등 7부위에 \n" +
                "우레탄 계열의 투명한 보호 필름을 부착하여 \n" +
                "스톤칩으로 인한 페인트 손상 및 생활 스크래치 예방하여 \n" +
                "깨끗한 바디를 유지할 수 있도록 합니다. \n" +
                "또한 3년/6만km의 보증을 제공해드립니다.";
        }

        private void btn_cashok_Click(object sender, EventArgs e)
        {
            if (rb2_5T.Checked)
            {
                lb_All.Text += rb2_5T.Text + "\n";
            }
            if (rb_3_5T.Checked)
            {
                lb_All.Text += rb_3_5T.Text + "\n";
            }
            if (rb_2wd.Checked)
            {
                lb_All.Text += rb_2wd.Text + "\n";
            }
            if (rb_4wd.Checked)
            {
                lb_All.Text += rb_4wd.Text + "\n";
            }
            if (rb_white.Checked || rb_silver.Checked || rb_gray.Checked || rb_black.Checked || rb_red.Checked ||
                rb_blue.Checked || rb_green.Checked || rb_realblue.Checked)
            {
                lb_All.Text += lb_glosy.Text + "\n";
            }
            if (rb_nowhite.Checked || rb_nosilver.Checked || rb_nogray.Checked)
            {
                lb_All.Text += lb_mat.Text + "\n";
            }
            if (rb_pakage.Checked)
            {
                lb_All.Text += rb_pakage.Text + "\n";
            }
            if (rb_tire19.Checked)
            {
                lb_All.Text += rb_tire19.Text + "\n";
            }
            if (rb_tire20.Checked)
            {
                lb_All.Text += rb_tire20.Text + "\n";
            }
            if (rb_inred1.Checked || rb_ingray.Checked)
            {
                lb_All.Text += lb_standard.Text + "\n";
            }
            if (rb_inred2.Checked || rb_inblre.Checked || rb_ingrba.Checked)
            {
                lb_All.Text += lb_sport.Text + "\n";
            }
            if (rb_ganish_cabon.Checked || rd_ganish_silver.Checked)
            {
                lb_All.Text += lb_ganishi_text.Text + "\n";
            }
            if (rb_papul.Checked)
            {
                lb_All.Text += rb_papul.Text + "\n";
            }
            if (rb_papulcom.Checked)
            {
                lb_All.Text += rb_papulcom.Text + "\n";
            }
            if (rb_papulduo.Checked)
            {
                lb_All.Text += rb_papulduo.Text + "\n";
            }
            if (rb_papulcomdou.Checked)
            {
                lb_All.Text += rb_papulcomdou.Text + "\n";
            }
            if (cb_pano.Checked)
            {
                lb_All.Text += cb_pano.Text + "\n";
            }
            if (cb_conbi.Checked)
            {
                lb_All.Text += cb_conbi.Text + "\n";
            }
            if (cb_dras.Checked)
            {
                lb_All.Text += cb_dras.Text + "\n";
            }
            if (cb_sound.Checked)
            {
                lb_All.Text += cb_sound.Text + "\n";
            }
            if (cb_built.Checked)
            {
                lb_All.Text += cb_built.Text + "\n";
            }
            if (cb_cover.Checked)
            {
                lb_All.Text += cb_cover.Text + "\n";
            }

            tabControl1.SelectedIndex += 1;
        }

        private void btn_back10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0:#,0}", result) + "원이 결제되었습니다.");
            Application.Exit();
        }
    }
}
