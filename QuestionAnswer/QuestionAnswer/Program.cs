using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer
{
    class Program
    {

        static void Main(string[] args)
        {

            // 정답 카운트
            int count = 0;


            Console.WriteLine("출제를 시작합니다!");
            Console.WriteLine("====================================");
            Console.WriteLine("질문 1. 우리나라 최초의 국가는?");
            Console.WriteLine("1) 고구려");
            Console.WriteLine("2) 조선");
            Console.WriteLine("3) 고조선");
            Console.WriteLine("4) 고려");

            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer1 = Console.ReadLine();
            int iAnswer1;
            bool isNum = int.TryParse(answer1, out iAnswer1);
           

            if (isNum)
             {
                if(iAnswer1 == 3)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

             }

            Console.WriteLine("질문 2. '널리 인간을 이롭게 한다'는 고조선의 건국 이념은?");
            Console.WriteLine("1) ");
            Console.WriteLine("2) 홍익인간");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer2 = Console.ReadLine();
            int iAnswer2;
            bool isNum2 = int.TryParse(answer2, out iAnswer2);


            if (isNum2)
            {
                if (iAnswer2 == 2)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 3. 임진왜란이 일어난 연도는? ");
            Console.WriteLine("1) 1592년");
            Console.WriteLine("2) ");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer3 = Console.ReadLine();
            int iAnswer3;
            bool isNum3 = int.TryParse(answer3, out iAnswer3);


            if (isNum3)
            {
                if (iAnswer3 == 1)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 4. 조선의 수도는?");
            Console.WriteLine("1) ");
            Console.WriteLine("2) 한양 ");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer4 = Console.ReadLine();
            int iAnswer4;
            bool isNum4 = int.TryParse(answer4, out iAnswer4);


            if (isNum4)
            {
                if (iAnswer4 == 2)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 5. 우리나라는 언제 광복?");
            Console.WriteLine("1) ");
            Console.WriteLine("2) 1945년 8월 15일");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer5 = Console.ReadLine();
            int iAnswer5;
            bool isNum5 = int.TryParse(answer5, out iAnswer5);


            if (isNum5)
            {
                if (iAnswer5 == 2)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 6. 6.25전쟁이 일어난 연도는?");
            Console.WriteLine("1) ");
            Console.WriteLine("2) ");
            Console.WriteLine("3) 1950년");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer6 = Console.ReadLine();
            int iAnswer6;
            bool isNum6 = int.TryParse(answer6, out iAnswer6);


            if (isNum6)
            {
                if (iAnswer6 == 3)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 7. 이순신 장군이 학익진 전법으로 크게 승리한 해전의 이름은? ");
            Console.WriteLine("1) 한산도대첩");
            Console.WriteLine("2) ");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer7 = Console.ReadLine();
            int iAnswer7;
            bool isNum7 = int.TryParse(answer7, out iAnswer7);


            if (isNum7)
            {
                if (iAnswer7 == 1)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 8. 자유당의 부정과 3.15 부정 선거를 계기로 일어난 혁명의 이름은?");
            Console.WriteLine("1) ");
            Console.WriteLine("2) 4.19혁명");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer8 = Console.ReadLine();
            int iAnswer8;
            bool isNum8 = int.TryParse(answer8, out iAnswer8);


            if (isNum8)
            {
                if (iAnswer8 == 2)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 9. 임시 정부의 주석으로 한인 애국단을 조직하여 독립운동을 한 분은? ");
            Console.WriteLine("1) ");
            Console.WriteLine("2) ");
            Console.WriteLine("3) ");
            Console.WriteLine("4) 김구");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer9 = Console.ReadLine();
            int iAnswer9;
            bool isNum9 = int.TryParse(answer9, out iAnswer9);


            if (isNum9)
            {
                if (iAnswer9 == 4)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }

            Console.WriteLine("질문 10. 민족대표 33인이 독립 선언서를 낭독하고 만세 삼창을 한 곳은? ");
            Console.WriteLine("1) 탑골공원");
            Console.WriteLine("2) ");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("====================================");
            Console.Write("정답을 입력하세요 >>>  ");

            // 유효성 검증
            string answer10 = Console.ReadLine();
            int iAnswer10;
            bool isNum10 = int.TryParse(answer10, out iAnswer10);


            if (isNum10)
            {
                if (iAnswer10 == 1)
                {
                    Console.WriteLine("정답입니다!");
                    count++;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                }

            }
            // 10문제가 출제 끝

            float correctResult = ((float)count / 10)*100;

            Console.WriteLine("총 10개의 문제 중에 " + count + "개의 문제를 맞추셨습니다. 정답률은 " + correctResult + "% 입니다.");


        }
    }
}
