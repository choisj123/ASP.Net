using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer
{
    class Program
    {
        class Question
        {
            public string QuestionText { get; set; }
            public string[] Options { get; set; }
            public int CorrectAnswer { get; set; }

        }

        static void Main(string[] args)
        {
            // 문제 목록
            List<Question> questions = new List<Question> {
                new Question
                {
                    QuestionText = "우리나라 최초의 국가는?",
                    Options = new string[] {"고구려", "조선", "고조선", "고려"},
                    CorrectAnswer = 2
                },

                new Question
                {
                    QuestionText = "널리 인간을 이롭게 한다'는 고조선의 건국 이념은??",
                    Options = new string[] {"고구려", "홍익인간", "고조선", "고려"},
                    CorrectAnswer = 2
                },

                new Question
                {
                    QuestionText = "임진왜란이 일어난 연도는?",
                    Options = new string[] {"1592년", "조선", "고조선", "고려"},
                    CorrectAnswer = 1
                },

                new Question
                {
                    QuestionText = "조선의 수도는?",
                    Options = new string[] {"고구려", "한양", "고조선", "고려"},
                    CorrectAnswer = 2
                },

                new Question
                {
                    QuestionText = "우리나라는 언제 광복?",
                    Options = new string[] {"고구려", "조선", "1945년 8월 15일", "고려"},
                    CorrectAnswer = 3
                },

                new Question
                {
                    QuestionText = "6.25전쟁이 일어난 연도는?",
                    Options = new string[] {"고구려", "조선", "고조선", "1950년"},
                    CorrectAnswer = 4
                },

                new Question
                {
                    QuestionText = "이순신 장군이 학익진 전법으로 크게 승리한 해전의 이름은?",
                    Options = new string[] {"한산도대첩", "조선", "고조선", "고려"},
                    CorrectAnswer = 1
                },

                new Question
                {
                    QuestionText = "자유당의 부정과 3.15 부정 선거를 계기로 일어난 혁명의 이름은?",
                    Options = new string[] {"고구려", "4.19혁명", "고조선", "고려"},
                    CorrectAnswer = 2
                },

                new Question
                {
                    QuestionText = "임시 정부의 주석으로 한인 애국단을 조직하여 독립운동을 한 분은?",
                    Options = new string[] {"고구려", "조선", "고조선", "김구"},
                    CorrectAnswer = 4
                },

                new Question
                {
                    QuestionText = "민족대표 33인이 독립 선언서를 낭독하고 만세 삼창을 한 곳은?",
                    Options = new string[] {"고구려", "탑골공원", "고조선", "고려"},
                    CorrectAnswer = 2
                },

            };

            Random random = new Random();
            bool continueQuiz = true;

            while (continueQuiz)
            {
                // 정답 카운트
                int count = 0;


                Console.WriteLine("출제를 시작합니다!");

                // 질문 리스트에서 꺼내기 
                foreach(var question in questions)
                {
                    Console.WriteLine("====================================");

                    // 질문 텍스트 + 보기 꺼내기
                    for(int i = 0; i < question.Options.Length; i++)
                    {
                        Console.WriteLine("질문 " + i + "." + question.QuestionText);
                        Console.WriteLine($"{i + 1}) {question.Options[i]}");
                    }

                    Console.Write("정답을 입력하세요 >>> ");

                    // 유효성 검증
                    string answer = Console.ReadLine();
                    int userAnswer;
                    bool isNum = int.TryParse(answer, out userAnswer);

                    if (isNum && userAnswer - 1 == question.CorrectAnswer)
                    {
                        Console.WriteLine("정답입니다!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다.");
                    }
                    // 10문제가 출제 끝

                    float correctResult = ((float)count / questions.Count)*100;

                    Console.WriteLine("총 " + questions.Count + "개의 문제 중에 " + count + "개의 문제를 맞추셨습니다. 정답률은 " + correctResult + "% 입니다.");

                    Console.Write("퀴즈를 계속 푸시겠어요? (Y/N) >>> ");
                    string continueInput = Console.ReadLine();


                    }

                }

            }






        }
    }
}
