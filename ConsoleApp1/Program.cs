Random random = new Random();
int randomValue = random.Next(1,10);

// %연산을 이용해서 0 또는 1만 값이 나오도록 작성
// 1이 나오면 승리를 출력
// 0이 나오면 패배 출력

if (randomValue % 2 == 0)
{
    Console.WriteLine("패배");
}
else
{
    Console.WriteLine("승리");
}

